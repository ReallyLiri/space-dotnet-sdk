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

namespace SpaceDotNet.Client.CollabDocumentDtoExtensions
{
    public static class CollabDocumentDtoPartialExtensions
    {
        public static Partial<CollabDocumentDto> WithId(this Partial<CollabDocumentDto> it)    => it.AddFieldName("id");
        
        public static Partial<CollabDocumentDto> WithResetCounter(this Partial<CollabDocumentDto> it)    => it.AddFieldName("resetCounter");
        
        public static Partial<CollabDocumentDto> WithVersion(this Partial<CollabDocumentDto> it)    => it.AddFieldName("version");
        
        public static Partial<CollabDocumentDto> WithType(this Partial<CollabDocumentDto> it)    => it.AddFieldName("type");
        
        public static Partial<CollabDocumentDto> WithType(this Partial<CollabDocumentDto> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)    => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>()));
        
        public static Partial<CollabDocumentDto> WithText(this Partial<CollabDocumentDto> it)    => it.AddFieldName("text");
        
    }
    
}
