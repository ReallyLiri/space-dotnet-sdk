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

namespace SpaceDotNet.Client.MdMarkupDtoExtensions
{
    public static class MdMarkupDtoPartialExtensions
    {
        public static Partial<MdMarkupDto> WithUnfurl(this Partial<MdMarkupDto> it)
            => it.AddFieldName("unfurl");
        
        public static Partial<MdMarkupDto> WithUnfurl(this Partial<MdMarkupDto> it, Func<Partial<UnfurlDto>, Partial<UnfurlDto>> partialBuilder)
            => it.AddFieldName("unfurl", partialBuilder(new Partial<UnfurlDto>(it)));
        
    }
    
}
