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

namespace SpaceDotNet.Client
{
    public class BlogsArticlesImportRequest
         : IPropagatePropertyAccessPath
    {
        public BlogsArticlesImportRequest() { }
        
        public BlogsArticlesImportRequest(ImportMetadataDto metadata, List<ExternalArticleDto> articles)
        {
            Metadata = metadata;
            Articles = articles;
        }
        
        private PropertyValue<ImportMetadataDto> _metadata = new PropertyValue<ImportMetadataDto>(nameof(BlogsArticlesImportRequest), nameof(Metadata));
        
        [Required]
        [JsonPropertyName("metadata")]
        public ImportMetadataDto Metadata
        {
            get { return _metadata.GetValue(); }
            set { _metadata.SetValue(value); }
        }
    
        private PropertyValue<List<ExternalArticleDto>> _articles = new PropertyValue<List<ExternalArticleDto>>(nameof(BlogsArticlesImportRequest), nameof(Articles));
        
        [Required]
        [JsonPropertyName("articles")]
        public List<ExternalArticleDto> Articles
        {
            get { return _articles.GetValue(); }
            set { _articles.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _metadata.SetAccessPath(path, validateHasBeenSet);
            _articles.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
