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

namespace SpaceDotNet.Client.IssueDescriptionChangedDetailsDtoExtensions
{
    public static class IssueDescriptionChangedDetailsDtoPartialExtensions
    {
        public static Partial<IssueDescriptionChangedDetailsDto> WithOldDescription(this Partial<IssueDescriptionChangedDetailsDto> it)
            => it.AddFieldName("oldDescription");
        
        public static Partial<IssueDescriptionChangedDetailsDto> WithNewDescription(this Partial<IssueDescriptionChangedDetailsDto> it)
            => it.AddFieldName("newDescription");
        
    }
    
}
