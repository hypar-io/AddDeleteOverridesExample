using System;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Newtonsoft.Json;

namespace Elements
{
    public class Box : GeometricElement
    {
        private Vector3 origin;
        private double depth;

        public double Depth
        {
            get; set;
        }
        public double Width { get; set; }
        public double Height { get; set; }

        public Vector3 Origin
        {
            get => origin;
            set
            {
                origin = value;
                Transform = new Transform(origin);
            }
        }

        [JsonProperty("Original Position")]
        public Vector3 OriginalPosition { get; set; }

        public Box(Vector3 origin, double depth, double width, double height) : base(null, null, null, false, Guid.NewGuid(), null)
        {
            this.Depth = depth;
            this.Width = width;
            this.Height = height;
            this.Origin = origin;
            this.OriginalPosition = origin;
            this.UpdateRepresentations();
        }

        public override void UpdateRepresentations()
        {
            this.Representation = new Extrude(Polygon.Rectangle(this.Width, this.Depth), this.Height, Vector3.ZAxis, false);
        }
    }
}