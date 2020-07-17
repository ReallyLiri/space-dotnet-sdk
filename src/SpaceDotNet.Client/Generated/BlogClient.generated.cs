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
    public partial class BlogClient
    {
        private readonly Connection _connection;
        
        public BlogClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<string> ConvertMarkdownToHTMLAsync(string markdown)
            => await _connection.RequestResourceAsync<BlogsMarkdown2htmlPostRequest, string>("POST", $"api/http/blogs/markdown2html", 
                new BlogsMarkdown2htmlPostRequest { 
                    Markdown = markdown,
                }
        );
    
        public ArticleClient Articles => new ArticleClient(_connection);
        
        public partial class ArticleClient
        {
            private readonly Connection _connection;
            
            public ArticleClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<List<ArticleImportResultDto>> ImportArticlesAsync(ImportMetadataDto metadata, List<ExternalArticleDto> articles, Func<Partial<ArticleImportResultDto>, Partial<ArticleImportResultDto>>? partial = null)
                => await _connection.RequestResourceAsync<BlogsArticlesImportPostRequest, List<ArticleImportResultDto>>("POST", $"api/http/blogs/articles/import?$fields={(partial != null ? partial(new Partial<ArticleImportResultDto>()) : Partial<ArticleImportResultDto>.Default())}", 
                    new BlogsArticlesImportPostRequest { 
                        Metadata = metadata,
                        Articles = articles,
                    }
            );
        
            public async Task<Batch<ArticleRecordDto>> GetAllArticlesAsync(string? skip = null, int? top = 100, string? term = null, SpaceTime? dateFrom = null, SpaceTime? dateTo = null, string? authorId = null, string? teamId = null, string? locationId = null, string? forProfile = null, Func<Partial<Batch<ArticleRecordDto>>, Partial<Batch<ArticleRecordDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<ArticleRecordDto>>("GET", $"api/http/blogs/articles?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&term={term?.ToString() ?? "null"}&dateFrom={dateFrom?.ToString() ?? "null"}&dateTo={dateTo?.ToString() ?? "null"}&authorId={authorId?.ToString() ?? "null"}&teamId={teamId?.ToString() ?? "null"}&locationId={locationId?.ToString() ?? "null"}&forProfile={forProfile?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<ArticleRecordDto>>()) : Partial<Batch<ArticleRecordDto>>.Default())}");
            
            public IAsyncEnumerable<ArticleRecordDto> GetAllArticlesAsyncEnumerable(string? skip = null, int? top = 100, string? term = null, SpaceTime? dateFrom = null, SpaceTime? dateTo = null, string? authorId = null, string? teamId = null, string? locationId = null, string? forProfile = null, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllArticlesAsync(top: top, term: term, dateFrom: dateFrom, dateTo: dateTo, authorId: authorId, teamId: teamId, locationId: locationId, forProfile: forProfile, skip: batchSkip, partial: builder => Partial<Batch<ArticleRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<ArticleRecordDto>.Default())), skip);
        
            public async Task<ArticleRecordDto> GetArticleByAliasAsync(string alias, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/alias:{alias}?$fields={(partial != null ? partial(new Partial<ArticleRecordDto>()) : Partial<ArticleRecordDto>.Default())}");
        
            public async Task<ArticleRecordDto> GetArticleByExternalIdAsync(string id, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/external-id:{id}?$fields={(partial != null ? partial(new Partial<ArticleRecordDto>()) : Partial<ArticleRecordDto>.Default())}");
        
            public async Task<ArticleRecordDto> GetArticleAsync(string id, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/{id}?$fields={(partial != null ? partial(new Partial<ArticleRecordDto>()) : Partial<ArticleRecordDto>.Default())}");
        
            /// <summary>
            /// Unpublish the article and delete its draft (if any)
            /// </summary>
            public async Task DeleteArticleAsync(string articleId)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/blogs/articles/article-id:{articleId}/delete");
        
            /// <summary>
            /// Unpublish the article, but keeps its draft
            /// </summary>
            public async Task UnpublishArticleAsync(string articleId)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/blogs/articles/article-id:{articleId}/unpublish");
        
            public DraftClient Drafts => new DraftClient(_connection);
            
            public partial class DraftClient
            {
                private readonly Connection _connection;
                
                public DraftClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<BGArticleIdDto> PublishArticleAsync(string draftId, Func<Partial<BGArticleIdDto>, Partial<BGArticleIdDto>>? partial = null)
                    => await _connection.RequestResourceAsync<BGArticleIdDto>("POST", $"api/http/blogs/articles/drafts/{draftId}/publish?$fields={(partial != null ? partial(new Partial<BGArticleIdDto>()) : Partial<BGArticleIdDto>.Default())}");
            
                public async Task<DRDraftIdDto> GetDraftByArticleIdAsync(string articleId, Func<Partial<DRDraftIdDto>, Partial<DRDraftIdDto>>? partial = null)
                    => await _connection.RequestResourceAsync<DRDraftIdDto>("GET", $"api/http/blogs/articles/drafts/article-id:{articleId}?$fields={(partial != null ? partial(new Partial<DRDraftIdDto>()) : Partial<DRDraftIdDto>.Default())}");
            
                public async Task<ArticleRecordDto> GetDraftByDraftIdAsync(string draftId, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>>? partial = null)
                    => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/drafts/draft-id:{draftId}?$fields={(partial != null ? partial(new Partial<ArticleRecordDto>()) : Partial<ArticleRecordDto>.Default())}");
            
                /// <summary>
                /// Unpublish the article, but keeps its draft
                /// </summary>
                public async Task UnpublishArticleAsync(string draftId)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/blogs/articles/drafts/{draftId}/unpublish");
            
            }
        
        }
    
        public DateClient Dates => new DateClient(_connection);
        
        public partial class DateClient
        {
            private readonly Connection _connection;
            
            public DateClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BGDatesDto> GetDatesAsync(Func<Partial<BGDatesDto>, Partial<BGDatesDto>>? partial = null)
                => await _connection.RequestResourceAsync<BGDatesDto>("GET", $"api/http/blogs/dates?$fields={(partial != null ? partial(new Partial<BGDatesDto>()) : Partial<BGDatesDto>.Default())}");
        
        }
    
        public StatClient Stats => new StatClient(_connection);
        
        public partial class StatClient
        {
            private readonly Connection _connection;
            
            public StatClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BGStatsDto> GetStatsAsync(SpaceTime? dateFrom = null, SpaceTime? dateTo = null, string? authorId = null, string? teamId = null, string? locationId = null, Func<Partial<BGStatsDto>, Partial<BGStatsDto>>? partial = null)
                => await _connection.RequestResourceAsync<BGStatsDto>("GET", $"api/http/blogs/stats?dateFrom={dateFrom?.ToString() ?? "null"}&dateTo={dateTo?.ToString() ?? "null"}&authorId={authorId?.ToString() ?? "null"}&teamId={teamId?.ToString() ?? "null"}&locationId={locationId?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<BGStatsDto>()) : Partial<BGStatsDto>.Default())}");
        
        }
    
    }
    
}
