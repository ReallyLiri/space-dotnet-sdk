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

namespace SpaceDotNet.Client.UnfurlDetailsChecklistDtoExtensions
{
    public static class UnfurlDetailsChecklistDtoPartialExtensions
    {
        public static Partial<UnfurlDetailsChecklistDto> WithChecklist(this Partial<UnfurlDetailsChecklistDto> it)
            => it.AddFieldName("checklist");
        
        public static Partial<UnfurlDetailsChecklistDto> WithChecklist(this Partial<UnfurlDetailsChecklistDto> it, Func<Partial<ChecklistDto>, Partial<ChecklistDto>> partialBuilder)
            => it.AddFieldName("checklist", partialBuilder(new Partial<ChecklistDto>(it)));
        
    }
    
}
