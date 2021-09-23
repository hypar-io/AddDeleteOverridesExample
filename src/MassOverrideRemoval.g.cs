using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for MassOverrideRemoval
	/// </summary>
	public partial class MassOverrideRemoval
	{
        public static string Name = "Mass Removal";
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