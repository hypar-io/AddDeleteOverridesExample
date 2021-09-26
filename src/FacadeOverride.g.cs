using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for FacadeOverride
	/// </summary>
	public partial class FacadeOverride : IOverride
	{
        public static string Name = "Facade";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.FacadeFace]";

        /// <summary>
        /// Get the override name for this override.
        /// </summary>
        public string GetName() {
			return Name;
		}

		public object GetIdentity() {
			return Identity;
		}

	}
}