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

public partial class CallClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public CallClient(Connection connection)
    {
        _connection = connection;
    }
    
    public async Task<Room> CreateCallAsync(List<ProfileIdentifier> participants, bool @private, string? channelId = null, string? description = null, Func<Partial<Room>, Partial<Room>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<Room>()) : Partial<Room>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<CallsPostRequest, Room>("POST", $"api/http/calls{queryParameters.ToQueryString()}", 
            new CallsPostRequest
            { 
                Participants = participants,
                IsPrivate = @private,
                ChannelId = channelId,
                Description = description,
            }, requestHeaders: null, cancellationToken: cancellationToken);
    }
    

}

