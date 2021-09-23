// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace AddDeleteOverridesTest
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public  class AddDeleteOverridesTestInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public AddDeleteOverridesTestInputs(Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<AddDeleteOverridesTestInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @overrides});
            }
        
            this.Overrides = @overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; }
    
    
    }
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class SubdivisionSettings 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SubdivisionSettings(int @count, double @targetLength, double @length, SubdivisionSettingsRemainderMode @remainderMode, SubdivisionSettingsCycleMode @cycleMode)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SubdivisionSettings>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @count, @targetLength, @length, @remainderMode, @cycleMode});
            }
        
            this.Count = @count;
            this.TargetLength = @targetLength;
            this.Length = @length;
            this.RemainderMode = @remainderMode;
            this.CycleMode = @cycleMode;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Count { get; set; } = 1;
    
        [Newtonsoft.Json.JsonProperty("Target Length", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TargetLength { get; set; } = 1D;
    
        [Newtonsoft.Json.JsonProperty("Length", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Length { get; set; } = 1D;
    
        [Newtonsoft.Json.JsonProperty("Remainder Mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SubdivisionSettingsRemainderMode RemainderMode { get; set; } = SubdivisionSettingsRemainderMode.Remainder_at_both_ends;
    
        [Newtonsoft.Json.JsonProperty("Cycle Mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SubdivisionSettingsCycleMode CycleMode { get; set; } = SubdivisionSettingsCycleMode.Cycle;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class Overrides 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(OverrideAdditions @additions, OverrideRemovals @removals, IList<BoxPositionOverride> @boxPosition, IList<BoxPropertiesOverride> @boxProperties, IList<MassOverride> @mass, IList<MassPropertiesOverride> @massProperties, IList<FacadeOverride> @facade)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @additions, @removals, @boxPosition, @boxProperties, @mass, @massProperties, @facade});
            }
        
            this.Additions = @additions;
            this.Removals = @removals;
            this.BoxPosition = @boxPosition;
            this.BoxProperties = @boxProperties;
            this.Mass = @mass;
            this.MassProperties = @massProperties;
            this.Facade = @facade;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Additions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideAdditions Additions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Removals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideRemovals Removals { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Box Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<BoxPositionOverride> BoxPosition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Box Properties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<BoxPropertiesOverride> BoxProperties { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Mass", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<MassOverride> Mass { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Mass Properties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<MassPropertiesOverride> MassProperties { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Facade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<FacadeOverride> Facade { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum SubdivisionSettingsRemainderMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Remainder at end")]
        Remainder_at_end = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Remainder at start")]
        Remainder_at_start = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Remainder at both ends")]
        Remainder_at_both_ends = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum SubdivisionSettingsCycleMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Repeat Last")]
        Repeat_Last = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Cycle")]
        Cycle = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wrap")]
        Wrap = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class OverrideAdditions 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public OverrideAdditions(IList<BoxPositionOverrideAddition> @boxPosition, IList<MassOverrideAddition> @mass, IList<FacadeOverrideAddition> @facade)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideAdditions>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @boxPosition, @mass, @facade});
            }
        
            this.BoxPosition = @boxPosition;
            this.Mass = @mass;
            this.Facade = @facade;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Box Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<BoxPositionOverrideAddition> BoxPosition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Mass", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<MassOverrideAddition> Mass { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Facade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<FacadeOverrideAddition> Facade { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class OverrideRemovals 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public OverrideRemovals(IList<BoxPositionOverrideRemoval> @boxPosition, IList<MassOverrideRemoval> @mass, IList<FacadeOverrideRemoval> @facade)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideRemovals>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @boxPosition, @mass, @facade});
            }
        
            this.BoxPosition = @boxPosition;
            this.Mass = @mass;
            this.Facade = @facade;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Box Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<BoxPositionOverrideRemoval> BoxPosition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Mass", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<MassOverrideRemoval> Mass { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Facade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<FacadeOverrideRemoval> Facade { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionOverride(string @id, BoxPositionIdentity @identity, BoxPositionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPositionIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPositionValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPropertiesOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPropertiesOverride(string @id, BoxPropertiesIdentity @identity, BoxPropertiesValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPropertiesOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPropertiesIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPropertiesValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassOverride(string @id, MassIdentity @identity, MassValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassPropertiesOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassPropertiesOverride(string @id, MassPropertiesIdentity @identity, MassPropertiesValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassPropertiesOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassPropertiesIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassPropertiesValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeOverride(string @id, FacadeIdentity @identity, FacadeValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FacadeIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FacadeValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionOverrideAddition(string @id, BoxPositionOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionOverrideAddition>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @value});
            }
        
            this.Id = @id;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPositionOverrideAdditionValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassOverrideAddition(string @id, MassOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassOverrideAddition>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @value});
            }
        
            this.Id = @id;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassOverrideAdditionValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeOverrideAddition(string @id, FacadeOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeOverrideAddition>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @value});
            }
        
            this.Id = @id;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FacadeOverrideAdditionValue Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionOverrideRemoval(string @id, BoxPositionIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionOverrideRemoval>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity});
            }
        
            this.Id = @id;
            this.Identity = @identity;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxPositionIdentity Identity { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassOverrideRemoval(string @id, MassIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassOverrideRemoval>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity});
            }
        
            this.Id = @id;
            this.Identity = @identity;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassIdentity Identity { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeOverrideRemoval(string @id, FacadeIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeOverrideRemoval>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity});
            }
        
            this.Id = @id;
            this.Identity = @identity;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FacadeIdentity Identity { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionIdentity(Vector3 @originalPosition)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @originalPosition});
            }
        
            this.OriginalPosition = @originalPosition;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Original Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 OriginalPosition { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionValue(Transform @transform)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @transform});
            }
        
            this.Transform = @transform;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transform", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transform Transform { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPropertiesIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPropertiesIdentity(Vector3 @originalPosition)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPropertiesIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @originalPosition});
            }
        
            this.OriginalPosition = @originalPosition;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Original Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 OriginalPosition { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPropertiesValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPropertiesValue(double @width, double @depth, double @height)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPropertiesValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @width, @depth, @height});
            }
        
            this.Width = @width;
            this.Depth = @depth;
            this.Height = @height;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Width", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Width { get; set; } = 1D;
    
        [Newtonsoft.Json.JsonProperty("Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Depth { get; set; } = 1D;
    
        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Height { get; set; } = 1D;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassIdentity(Vector3 @profileCentroid)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @profileCentroid});
            }
        
            this.ProfileCentroid = @profileCentroid;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Profile Centroid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 ProfileCentroid { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassValue(Polygon @perimeter)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter});
            }
        
            this.Perimeter = @perimeter;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polygon Perimeter { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassPropertiesIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassPropertiesIdentity(Vector3 @profileCentroid)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassPropertiesIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @profileCentroid});
            }
        
            this.ProfileCentroid = @profileCentroid;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Profile Centroid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 ProfileCentroid { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassPropertiesValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassPropertiesValue(double @height, Color @color)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassPropertiesValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @height, @color});
            }
        
            this.Height = @height;
            this.Color = @color;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Height { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Color { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeIdentity(Vector3 @roughLocation)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @roughLocation});
            }
        
            this.RoughLocation = @roughLocation;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Rough Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 RoughLocation { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeValue(Grid1dInput @grid)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @grid});
            }
        
            this.Grid = @grid;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Grid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Grid1dInput Grid { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BoxPositionOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BoxPositionOverrideAdditionValue(Vector3 @origin)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BoxPositionOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @origin});
            }
        
            this.Origin = @origin;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Origin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 Origin { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassOverrideAdditionValue(Polygon @perimeter)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter});
            }
        
            this.Perimeter = @perimeter;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polygon Perimeter { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class FacadeOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public FacadeOverrideAdditionValue(Line @line)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<FacadeOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @line});
            }
        
            this.Line = @line;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Line", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Line Line { get; set; }
    
    
    }
}