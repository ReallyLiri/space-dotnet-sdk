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

namespace SpaceDotNet.Client.ImportIssueCommentHistoryRequestDtoExtensions
{
    public static class ImportIssueCommentHistoryRequestDtoPartialExtensions
    {
        public static Partial<ImportIssueCommentHistoryRequestDto> WithComments(this Partial<ImportIssueCommentHistoryRequestDto> it)    => it.AddFieldName("comments");
        
        public static Partial<ImportIssueCommentHistoryRequestDto> WithComments(this Partial<ImportIssueCommentHistoryRequestDto> it, Func<Partial<MessageForImportDto>, Partial<MessageForImportDto>> partialBuilder)    => it.AddFieldName("comments", partialBuilder(new Partial<MessageForImportDto>()));
        
    }
    
}
