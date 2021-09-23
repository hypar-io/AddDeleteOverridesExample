using System;
using System.Linq;
using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Newtonsoft.Json;

namespace Elements
{
    public class FacadeFace : GeometricElement
    {
        [JsonProperty("Rough Location")]
        public Vector3 RoughLocation { get; set; }
        public Grid1dInput Grid { get; set; }

        public Polygon Boundary { get; set; }

        [JsonIgnore]
        private Grid1d grid1d;
        public FacadeFace(Polygon p) : base()
        {
            Boundary = p;
            var crv = p.Segments().OrderBy(s => s.PointAt(0.5).Z).First().ToPolyline(1);
            RoughLocation = p.Centroid().Project(new Plane((0, 0, 0), (0, 0, 1)));
            Representation = new Lamina(p);
            grid1d = new Grid1d(crv);
            grid1d.DivideByApproximateLength(2);
            Grid = new Grid1dInput(
                    crv,
                    grid1d.GetCellSeparators(),
                    Grid1dInputSubdivisionMode.Divide_by_approximate_length,
                    new SubdivisionSettings(1, 2, 2, SubdivisionSettingsRemainderMode.Remainder_at_both_ends, SubdivisionSettingsCycleMode.Wrap)
                );
        }

        public void AddFacadeGeometry(Model m)
        {
            var verticalEdge = Boundary.Segments().OrderBy(s => s.Direction().Dot(Vector3.ZAxis)).Last().ToPolyline(1);
            var vGrid = new Grid1d(verticalEdge);
            var grid2d = new Grid2d(grid1d, vGrid);
            vGrid.DivideByApproximateLength(1);
            m.AddElements(grid2d.ToModelCurves(new Transform(Boundary.Normal() * 0.05)));
        }

        public void UpdateGrid(Grid1dInput grid)
        {

            this.grid1d = new Grid1d(grid1d.Curve);
            switch (grid.SubdivisionMode)
            {
                case Grid1dInputSubdivisionMode.Divide_by_approximate_length:
                    grid1d.DivideByApproximateLength(grid.SubdivisionSettings.TargetLength);
                    break;
                case Grid1dInputSubdivisionMode.Divide_by_count:
                    grid1d.DivideByCount(grid.SubdivisionSettings.Count);
                    break;
                case Grid1dInputSubdivisionMode.Divide_by_fixed_length:
                    grid1d.DivideByFixedLength(grid.SubdivisionSettings.Length, FixedDivisionMode.RemainderAtBothEnds);
                    break;
                case Grid1dInputSubdivisionMode.Manual:
                    grid1d.SplitAtPoints(grid.SplitPoints);
                    break;
            }
            this.grid1d.SplitAtPoints(grid.SplitPoints);
        }
    }

}