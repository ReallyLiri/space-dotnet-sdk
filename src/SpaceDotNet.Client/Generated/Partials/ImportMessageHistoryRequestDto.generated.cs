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

namespace SpaceDotNet.Client.ImportMessageHistoryRequestDtoExtensions
{
    public static class ImportMessageHistoryRequestDtoPartialExtensions
    {
        public static Partial<ImportMessageHistoryRequestDto> WithMessages(this Partial<ImportMessageHistoryRequestDto> it)    => it.AddFieldName("messages");
        
        public static Partial<ImportMessageHistoryRequestDto> WithMessages(this Partial<ImportMessageHistoryRequestDto> it, Func<Partial<MessageForImportDto>, Partial<MessageForImportDto>> partialBuilder)    => it.AddFieldName("messages", partialBuilder(new Partial<MessageForImportDto>()));
        
    }
    
}
