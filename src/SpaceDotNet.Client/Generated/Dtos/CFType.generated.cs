// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CFType
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CFType";
        
        public static BooleanCFType Boolean()
            => new BooleanCFType();
        
        public static DateCFType Date()
            => new DateCFType();
        
        public static EnumCFType Enum(List<EnumValueData> values)
            => new EnumCFType(values: values);
        
        public static EnumListCFType EnumList(List<EnumValueData> values)
            => new EnumListCFType(values: values);
        
        public static FractionCFType Fraction()
            => new FractionCFType();
        
        public static IntCFType Int()
            => new IntCFType();
        
        public static IntListCFType IntList()
            => new IntListCFType();
        
        public static ProfileCFType Profile()
            => new ProfileCFType();
        
        public static ProfileListCFType ProfileList()
            => new ProfileListCFType();
        
        public static StringCFType String()
            => new StringCFType();
        
        public static StringListCFType StringList()
            => new StringListCFType();
        
        public static UrlCFType Url()
            => new UrlCFType();
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
