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

namespace SpaceDotNet.Client.SyntaxMarkupExtensions
{
    public static class SyntaxMarkupDtoPartialExtensions
    {
        public static Partial<SyntaxMarkupDto> WithType(this Partial<SyntaxMarkupDto> it)
            => it.AddFieldName("type");
        
        public static Partial<SyntaxMarkupDto> WithRange(this Partial<SyntaxMarkupDto> it)
            => it.AddFieldName("range");
        
        public static Partial<SyntaxMarkupDto> WithRange(this Partial<SyntaxMarkupDto> it, Func<Partial<TextRangeDto>, Partial<TextRangeDto>> partialBuilder)
            => it.AddFieldName("range", partialBuilder(new Partial<TextRangeDto>()));
        
    }
    
}