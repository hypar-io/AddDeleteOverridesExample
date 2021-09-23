using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for FacadeOverrideAddition
	/// </summary>
	public partial class FacadeOverrideAddition
	{
        public static string Name = "Facade Addition";
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