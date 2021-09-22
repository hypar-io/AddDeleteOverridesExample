using Elements;
using System.Collections.Generic;

namespace AddDeleteOverridesTest
{
	/// <summary>
	/// Override metadata for BoxPropertiesOverride
	/// </summary>
	public partial class BoxPropertiesOverride
	{
        public static string Name = "Box Properties";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.Box]";

	}
}