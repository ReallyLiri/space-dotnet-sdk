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

namespace SpaceDotNet.Client.ArticleContentRecordDtoExtensions
{
    public static class ArticleContentRecordDtoPartialExtensions
    {
        public static Partial<ArticleContentRecordDto> WithId(this Partial<ArticleContentRecordDto> it)    => it.AddFieldName("id");
        
        public static Partial<ArticleContentRecordDto> WithArchived(this Partial<ArticleContentRecordDto> it)    => it.AddFieldName("archived");
        
        public static Partial<ArticleContentRecordDto> WithContent(this Partial<ArticleContentRecordDto> it)    => it.AddFieldName("content");
        
    }
    
}
