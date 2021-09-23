using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for MassPropertiesOverride
	/// </summary>
	public partial class MassPropertiesOverride
	{
        public static string Name = "Mass Properties";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.Mass]";

        /// <summary>
        /// Get the override name for this override.
        /// </summary>
        public string GetName() {
			return Name;
		}

	}
}