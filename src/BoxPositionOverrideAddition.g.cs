using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for BoxPositionOverrideAddition
	/// </summary>
	public partial class BoxPositionOverrideAddition : IOverride
	{
        public static string Name = "Box Position Addition";
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