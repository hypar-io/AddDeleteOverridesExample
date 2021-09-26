using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for BoxPositionOverride
	/// </summary>
	public partial class BoxPositionOverride : IOverride
	{
        public static string Name = "Box Position";
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