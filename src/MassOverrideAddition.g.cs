using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for MassOverrideAddition
	/// </summary>
	public partial class MassOverrideAddition : IOverride
	{
        public static string Name = "Mass Addition";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.Mass]";

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