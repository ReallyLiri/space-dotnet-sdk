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

namespace SpaceDotNet.Client.ImportArticlesRequestDtoExtensions
{
    public static class ImportArticlesRequestDtoPartialExtensions
    {
        public static Partial<ImportArticlesRequestDto> WithMetadata(this Partial<ImportArticlesRequestDto> it)    => it.AddFieldName("metadata");
        
        public static Partial<ImportArticlesRequestDto> WithMetadata(this Partial<ImportArticlesRequestDto> it, Func<Partial<ImportMetadataDto>, Partial<ImportMetadataDto>> partialBuilder)    => it.AddFieldName("metadata", partialBuilder(new Partial<ImportMetadataDto>()));
        
        public static Partial<ImportArticlesRequestDto> WithArticles(this Partial<ImportArticlesRequestDto> it)    => it.AddFieldName("articles");
        
        public static Partial<ImportArticlesRequestDto> WithArticles(this Partial<ImportArticlesRequestDto> it, Func<Partial<ExternalArticleDto>, Partial<ExternalArticleDto>> partialBuilder)    => it.AddFieldName("articles", partialBuilder(new Partial<ExternalArticleDto>()));
        
    }
    
}
