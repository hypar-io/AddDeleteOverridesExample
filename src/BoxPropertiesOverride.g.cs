using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for BoxPropertiesOverride
	/// </summary>
	public partial class BoxPropertiesOverride : IOverride
	{
        public static string Name = "Box Properties";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.Box]";

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