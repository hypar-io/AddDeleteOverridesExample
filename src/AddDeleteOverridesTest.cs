using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddDeleteOverridesTest
{
    public static class AddDeleteOverridesTest
    {
        /// <summary>
        /// The AddDeleteOverridesTest function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A AddDeleteOverridesTestOutputs instance containing computed results and the model with any new elements.</returns>
        public static AddDeleteOverridesTestOutputs Execute(Dictionary<string, Model> inputModels, AddDeleteOverridesTestInputs input)
        {
            var output = new AddDeleteOverridesTestOutputs();
            // Auto-generate some boxes 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var box = new Box((i * 2, j * 2, 0), 1, 1, 1);
                    box.Material = BuiltInMaterials.XAxis;
                    output.Model.AddElement(box);
                }
            }

            // add additional boxes
            if (input.Overrides?.Additions?.BoxPosition != null)
            {
                foreach (var boxPosition in input.Overrides.Additions.BoxPosition)
                {
                    var newBox = new Box(boxPosition.Value.Origin, 1, 1, 1);
                    output.Model.AddElement(newBox);
                    Identity.AddOverrideIdentity(newBox, boxPosition);
                }
            }

            // apply edit overrides
            if (input.Overrides?.BoxPosition != null)
            {
                foreach (var boxPositionOverride in input.Overrides.BoxPosition)
                {
                    var matchingBox = output.Model.AllElementsOfType<Box>().OrderBy(b => b.OriginalPosition.DistanceTo(boxPositionOverride.Identity.OriginalPosition)).First();
                    matchingBox.Transform = boxPositionOverride.Value.Transform;
                    Identity.AddOverrideIdentity(matchingBox, boxPositionOverride);
                }
            }

            if (input.Overrides?.BoxProperties != null)
            {
                foreach (var boxPropertiesOverride in input.Overrides.BoxProperties)
                {
                    var matchingBox = output.Model.AllElementsOfType<Box>().OrderBy(b => b.OriginalPosition.DistanceTo(boxPropertiesOverride.Identity.OriginalPosition)).First();
                    matchingBox.Height = boxPropertiesOverride.Value.Height;
                    matchingBox.Width = boxPropertiesOverride.Value.Width;
                    matchingBox.Depth = boxPropertiesOverride.Value.Depth;
                }
            }

            // apply delete overrides
            if (input.Overrides?.Removals?.BoxPosition != null)
            {
                foreach (var boxPosition in input.Overrides.Removals.BoxPosition)
                {
                    var matchingBox = output.Model.AllElementsOfType<Box>().OrderBy(b => b.OriginalPosition.DistanceTo(boxPosition.Identity.OriginalPosition)).First();
                    output.Model.Elements.Remove(matchingBox.Id);
                }
            }

            // Add masses 
            var rand = new Random(16);

            if (input.Overrides?.Additions?.Mass != null)
            {
                foreach (var mass in input.Overrides.Additions.Mass)
                {
                    var massElement = new Mass(mass.Value.Perimeter, 1);
                    massElement.AdditionalProperties["Profile Centroid"] = mass.Value.Perimeter.Centroid();
                    massElement.AdditionalProperties["Perimeter"] = mass.Value.Perimeter;
                    var col = rand.NextColor();
                    massElement.AdditionalProperties["Color"] = col;
                    massElement.Material = new Material(col.ToString(), col);
                    output.Model.AddElement(massElement);
                    Identity.AddOverrideIdentity(massElement, mass);
                }
            }

            // apply edit overrides
            if (input.Overrides?.Mass != null)
            {
                foreach (var mass in input.Overrides.Mass)
                {
                    var matchingMass = output.Model.AllElementsOfType<Mass>().OrderBy(m => ((Vector3)m.AdditionalProperties["Profile Centroid"]).DistanceTo(mass.Identity.ProfileCentroid)).First();
                    matchingMass.Profile = mass.Value.Perimeter;
                    matchingMass.AdditionalProperties["Perimeter"] = mass.Value.Perimeter;
                }
            }

            if (input.Overrides?.MassProperties != null)
            {
                foreach (var massProperties in input.Overrides.MassProperties)
                {
                    var matchingMass = output.Model.AllElementsOfType<Mass>().OrderBy(m => ((Vector3)m.AdditionalProperties["Profile Centroid"]).DistanceTo(massProperties.Identity.ProfileCentroid)).First();
                    matchingMass.AdditionalProperties["Color"] = massProperties.Value.Color;
                    matchingMass.Material = new Material(massProperties.Value.Color.ToString(), massProperties.Value.Color);
                    output.Model.AddElement(matchingMass.Material);
                    matchingMass.Height = massProperties.Value.Height;
                    matchingMass.UpdateRepresentations();
                }
            }

            // apply delete overrides
            if (input.Overrides?.Removals?.Mass != null)
            {
                foreach (var mass in input.Overrides.Removals.Mass)
                {
                    var matchingMass = output.Model.AllElementsOfType<Mass>().OrderBy(m => ((Vector3)m.AdditionalProperties["Profile Centroid"]).DistanceTo(mass.Identity.ProfileCentroid)).First();
                    output.Model.Elements.Remove(matchingMass.Id);
                }
            }

            // add facades 
            if (input.Overrides?.Additions?.Facade != null)
            {
                foreach (var facade in input.Overrides.Additions.Facade)
                {
                    var line = facade.Value.Line;
                    var midpt = line.PointAt(0.5);
                    var closestMass = output.Model.AllElementsOfType<Mass>().OrderBy(m => ((Vector3)m.AdditionalProperties["Profile Centroid"]).DistanceTo(midpt)).FirstOrDefault();
                    if (closestMass == null)
                    {
                        output.Warnings.Add("You added a facade but no masses. Add a mass to see your facade");
                        continue;
                    }
                    // find sideways-oriented faces
                    var faces = closestMass.Representation.SolidOperations.OfType<Extrude>()
                        .SelectMany(e => e.Solid.Faces.Select(f => f.Value.Outer.ToPolygon()).Where(p => Math.Abs(p.Normal().Dot(Vector3.ZAxis)) < 0.2));
                    var closestFace = faces.OrderBy(f => f.Centroid().DistanceTo(midpt)).First();
                    var facadeFace = new FacadeFace(closestFace);
                    output.Model.AddElement(facadeFace);
                    Identity.AddOverrideIdentity(facadeFace, facade);
                }
            }

            // apply edit overrides
            if (input.Overrides?.Facade != null)
            {
                foreach (var facade in input.Overrides.Facade)
                {
                    var matchingFacade = output.Model.AllElementsOfType<FacadeFace>().OrderBy(f => f.RoughLocation.DistanceTo(facade.Identity.RoughLocation)).First();
                    matchingFacade.UpdateGrid(facade.Value.Grid);
                }
            }

            // remove facades
            if (input.Overrides?.Removals?.Facade != null)
            {
                foreach (var facade in input.Overrides.Removals.Facade)
                {
                    var matchingFacade = output.Model.AllElementsOfType<FacadeFace>().OrderBy(f => f.RoughLocation.DistanceTo(facade.Identity.RoughLocation)).First();
                    output.Model.Elements.Remove(matchingFacade.Id);
                }
            }

            foreach (var facade in output.Model.AllElementsOfType<FacadeFace>().ToList())
            {
                facade.AddFacadeGeometry(output.Model);
            }

            return output;
        }
    }
}