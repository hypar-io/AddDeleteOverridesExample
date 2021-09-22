using Elements;
using Elements.Geometry;
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
            // Auto-generate a box
            var box = new Box(Vector3.Origin, 1, 1, 1);
            output.Model.AddElement(box);

            // add additional boxes

            if (input.Overrides?.BoxPosition != null)
            {
                foreach (var boxPositionOverride in input.Overrides.BoxPosition)
                {
                    var matchingBox = output.Model.AllElementsOfType<Box>().OrderBy(b => b.Origin.DistanceTo(boxPositionOverride.Value.Origin)).First();
                    matchingBox.Origin = boxPositionOverride.Value.Origin;
                }
            }

            return output;
        }
    }
}