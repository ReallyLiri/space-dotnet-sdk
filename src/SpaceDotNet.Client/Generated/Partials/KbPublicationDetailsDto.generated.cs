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

namespace SpaceDotNet.Client.KbPublicationDetailsDtoExtensions
{
    public static class KbPublicationDetailsDtoPartialExtensions
    {
        public static Partial<KbPublicationDetailsDto> WithBook(this Partial<KbPublicationDetailsDto> it)
            => it.AddFieldName("book");
        
        public static Partial<KbPublicationDetailsDto> WithBook(this Partial<KbPublicationDetailsDto> it, Func<Partial<KBBookDto>, Partial<KBBookDto>> partialBuilder)
            => it.AddFieldName("book", partialBuilder(new Partial<KBBookDto>(it)));
        
        public static Partial<KbPublicationDetailsDto> WithFolder(this Partial<KbPublicationDetailsDto> it)
            => it.AddFieldName("folder");
        
        public static Partial<KbPublicationDetailsDto> WithFolder(this Partial<KbPublicationDetailsDto> it, Func<Partial<KBFolderDto>, Partial<KBFolderDto>> partialBuilder)
            => it.AddFieldName("folder", partialBuilder(new Partial<KBFolderDto>(it)));
        
        public static Partial<KbPublicationDetailsDto> WithArticleId(this Partial<KbPublicationDetailsDto> it)
            => it.AddFieldName("articleId");
        
        public static Partial<KbPublicationDetailsDto> WithArticleId(this Partial<KbPublicationDetailsDto> it, Func<Partial<KBArticleDto>, Partial<KBArticleDto>> partialBuilder)
            => it.AddFieldName("articleId", partialBuilder(new Partial<KBArticleDto>(it)));
        
    }
    
}
