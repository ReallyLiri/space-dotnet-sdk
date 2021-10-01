// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public partial class UnfurlClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public UnfurlClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <summary>
    /// Block link unfurling
    /// </summary>
    public async Task BlockUnfurlAsync(string link, bool wholeHost, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/unfurls/block-unfurl{queryParameters.ToQueryString()}", 
            new UnfurlsBlockUnfurlPostRequest
            { 
                Link = link,
                IsWholeHost = wholeHost,
            }, cancellationToken);
    }
    

    /// <summary>
    /// Block link unfurling for organization
    /// </summary>
    public async Task BlockUnfurlGlobalAsync(string link, bool wholeHost, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/unfurls/block-unfurl-global{queryParameters.ToQueryString()}", 
            new UnfurlsBlockUnfurlGlobalPostRequest
            { 
                Link = link,
                IsWholeHost = wholeHost,
            }, cancellationToken);
    }
    

    public async Task<bool> CheckBlockedAsync(string link, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        return await _connection.RequestResourceAsync<UnfurlsCheckBlockedPostRequest, bool>("POST", $"api/http/unfurls/check-blocked{queryParameters.ToQueryString()}", 
            new UnfurlsCheckBlockedPostRequest
            { 
                Link = link,
            }, cancellationToken);
    }
    

    /// <summary>
    /// Unblock link unfurling
    /// </summary>
    public async Task UnblockUnfurlAsync(string link, bool wholeHost, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/unfurls/unblock-unfurl{queryParameters.ToQueryString()}", 
            new UnfurlsUnblockUnfurlPostRequest
            { 
                Link = link,
                IsWholeHost = wholeHost,
            }, cancellationToken);
    }
    

    /// <summary>
    /// Unblock link unfurling for organization
    /// </summary>
    public async Task UnblockUnfurlGlobalAsync(string link, bool wholeHost, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/unfurls/unblock-unfurl-global{queryParameters.ToQueryString()}", 
            new UnfurlsUnblockUnfurlGlobalPostRequest
            { 
                Link = link,
                IsWholeHost = wholeHost,
            }, cancellationToken);
    }
    

    public async Task<Batch<UnfurlsBlockListEntry>> ListBlockedAsync(string? skip = null, int? top = 100, Func<Partial<Batch<UnfurlsBlockListEntry>>, Partial<Batch<UnfurlsBlockListEntry>>>? partial = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        if (skip != null) queryParameters.Append("$skip", skip);
        if (top != null) queryParameters.Append("$top", top?.ToString());
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<UnfurlsBlockListEntry>>()) : Partial<Batch<UnfurlsBlockListEntry>>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<Batch<UnfurlsBlockListEntry>>("GET", $"api/http/unfurls/list-blocked{queryParameters.ToQueryString()}", cancellationToken);
    }
    
    
    public IAsyncEnumerable<UnfurlsBlockListEntry> ListBlockedAsyncEnumerable(string? skip = null, int? top = 100, Func<Partial<UnfurlsBlockListEntry>, Partial<UnfurlsBlockListEntry>>? partial = null, CancellationToken cancellationToken = default)
        => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => ListBlockedAsync(top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<UnfurlsBlockListEntry>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<UnfurlsBlockListEntry>.Default())), skip, cancellationToken);

}

