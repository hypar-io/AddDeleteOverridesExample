using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for FacadeOverrideRemoval
	/// </summary>
	public partial class FacadeOverrideRemoval
	{
        public static string Name = "Facade Removal";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.FacadeFace]";

        /// <summary>
        /// Get the override name for this override.
        /// </summary>
        public string GetName() {
			return Name;
		}

	}
}