using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for BoxPositionOverrideRemoval
	/// </summary>
	public partial class BoxPositionOverrideRemoval : IOverride
	{
        public static string Name = "Box Position Removal";
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