// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.TDProfileLanguageDtoExtensions
{
    public static class TDProfileLanguageDtoPartialExtensions
    {
        public static Partial<TDProfileLanguageDto> WithName(this Partial<TDProfileLanguageDto> it)
            => it.AddFieldName("name");
        
        public static Partial<TDProfileLanguageDto> WithName(this Partial<TDProfileLanguageDto> it, Func<Partial<TDProfileNameDto>, Partial<TDProfileNameDto>> partialBuilder)
            => it.AddFieldName("name", partialBuilder(new Partial<TDProfileNameDto>(it)));
        
        public static Partial<TDProfileLanguageDto> WithLanguage(this Partial<TDProfileLanguageDto> it)
            => it.AddFieldName("language");
        
        public static Partial<TDProfileLanguageDto> WithLanguage(this Partial<TDProfileLanguageDto> it, Func<Partial<TDLanguageDto>, Partial<TDLanguageDto>> partialBuilder)
            => it.AddFieldName("language", partialBuilder(new Partial<TDLanguageDto>(it)));
        
        public static Partial<TDProfileLanguageDto> WithLanguageCode(this Partial<TDProfileLanguageDto> it)
            => it.AddFieldName("languageCode");
        
    }
    
}
