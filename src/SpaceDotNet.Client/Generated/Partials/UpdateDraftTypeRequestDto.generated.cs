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

namespace SpaceDotNet.Client.UpdateDraftTypeRequestDtoExtensions
{
    public static class UpdateDraftTypeRequestDtoPartialExtensions
    {
        public static Partial<UpdateDraftTypeRequestDto> WithDraftType(this Partial<UpdateDraftTypeRequestDto> it)    => it.AddFieldName("draftType");
        
        public static Partial<UpdateDraftTypeRequestDto> WithDraftType(this Partial<UpdateDraftTypeRequestDto> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)    => it.AddFieldName("draftType", partialBuilder(new Partial<DraftDocumentType>()));
        
    }
    
}
