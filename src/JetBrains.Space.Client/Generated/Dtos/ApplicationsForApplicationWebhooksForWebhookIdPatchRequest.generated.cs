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

public class ApplicationsForApplicationWebhooksForWebhookIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationWebhooksForWebhookIdPatchRequest() { }
    
    public ApplicationsForApplicationWebhooksForWebhookIdPatchRequest(List<int> acceptedHttpResponseCodes, string? name = null, bool? enabled = null, bool? doRetries = null, string? description = null, ExternalEndpointUpdateDTO? endpoint = null, EndpointAuthUpdateDTO? endpointAuth = null)
    {
        Name = name;
        Description = description;
        IsEnabled = enabled;
        Endpoint = endpoint;
        EndpointAuth = endpointAuth;
        AcceptedHttpResponseCodes = acceptedHttpResponseCodes;
        IsDoRetries = doRetries;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<bool?> _enabled = new PropertyValue<bool?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(IsEnabled), "enabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("enabled")]
    public bool? IsEnabled
    {
        get => _enabled.GetValue(InlineErrors);
        set => _enabled.SetValue(value);
    }

    private PropertyValue<ExternalEndpointUpdateDTO?> _endpoint = new PropertyValue<ExternalEndpointUpdateDTO?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(Endpoint), "endpoint");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("endpoint")]
    public ExternalEndpointUpdateDTO? Endpoint
    {
        get => _endpoint.GetValue(InlineErrors);
        set => _endpoint.SetValue(value);
    }

    private PropertyValue<EndpointAuthUpdateDTO?> _endpointAuth = new PropertyValue<EndpointAuthUpdateDTO?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(EndpointAuth), "endpointAuth");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("endpointAuth")]
    public EndpointAuthUpdateDTO? EndpointAuth
    {
        get => _endpointAuth.GetValue(InlineErrors);
        set => _endpointAuth.SetValue(value);
    }

    private PropertyValue<List<int>> _acceptedHttpResponseCodes = new PropertyValue<List<int>>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(AcceptedHttpResponseCodes), "acceptedHttpResponseCodes", new List<int>());
    
    [JsonPropertyName("acceptedHttpResponseCodes")]
    public List<int> AcceptedHttpResponseCodes
    {
        get => _acceptedHttpResponseCodes.GetValue(InlineErrors);
        set => _acceptedHttpResponseCodes.SetValue(value);
    }

    private PropertyValue<bool?> _doRetries = new PropertyValue<bool?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdPatchRequest), nameof(IsDoRetries), "doRetries");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("doRetries")]
    public bool? IsDoRetries
    {
        get => _doRetries.GetValue(InlineErrors);
        set => _doRetries.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endpoint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endpointAuth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _acceptedHttpResponseCodes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _doRetries.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

