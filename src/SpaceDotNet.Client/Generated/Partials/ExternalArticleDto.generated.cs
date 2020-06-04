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

namespace SpaceDotNet.Client.ExternalArticleDtoExtensions
{
    public static class ExternalArticleDtoPartialExtensions
    {
        public static Partial<ExternalArticleDto> WithTitle(this Partial<ExternalArticleDto> it)    => it.AddFieldName("title");
        
        public static Partial<ExternalArticleDto> WithContent(this Partial<ExternalArticleDto> it)    => it.AddFieldName("content");
        
        public static Partial<ExternalArticleDto> WithAuthorId(this Partial<ExternalArticleDto> it)    => it.AddFieldName("authorId");
        
        public static Partial<ExternalArticleDto> WithCreated(this Partial<ExternalArticleDto> it)    => it.AddFieldName("created");
        
        public static Partial<ExternalArticleDto> WithTeams(this Partial<ExternalArticleDto> it)    => it.AddFieldName("teams");
        
        public static Partial<ExternalArticleDto> WithLocations(this Partial<ExternalArticleDto> it)    => it.AddFieldName("locations");
        
        public static Partial<ExternalArticleDto> WithExternalId(this Partial<ExternalArticleDto> it)    => it.AddFieldName("externalId");
        
        public static Partial<ExternalArticleDto> WithExternalUrl(this Partial<ExternalArticleDto> it)    => it.AddFieldName("externalUrl");
        
    }
    
}
