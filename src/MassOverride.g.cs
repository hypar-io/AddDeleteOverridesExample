using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for MassOverride
	/// </summary>
	public partial class MassOverride : IOverride
	{
        public static string Name = "Mass";
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