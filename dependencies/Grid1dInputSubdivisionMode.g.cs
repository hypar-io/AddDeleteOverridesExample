//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum Grid1dInputSubdivisionMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Manual")]
        Manual = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Divide by count")]
        Divide_by_count = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Divide by approximate length")]
        Divide_by_approximate_length = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Divide by fixed length")]
        Divide_by_fixed_length = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Divide by pattern")]
        Divide_by_pattern = 4,
    
    }
}