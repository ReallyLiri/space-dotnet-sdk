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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class HAEndpoint
         : IPropagatePropertyAccessPath
    {
        public HAEndpoint() { }
        
        public HAEndpoint(HAResource resource, HAMethod method, List<HAParameter> parameters, HAPath path, string displayName, HATypeObject? requestBody = null, HAType? responseBody = null, string? doc = null, HADeprecation? deprecation = null, List<HARight>? rights = null)
        {
            Resource = resource;
            Method = method;
            Parameters = parameters;
            RequestBody = requestBody;
            ResponseBody = responseBody;
            Path = path;
            DisplayName = displayName;
            Doc = doc;
            Deprecation = deprecation;
            Rights = rights;
        }
        
        private PropertyValue<HAResource> _resource = new PropertyValue<HAResource>(nameof(HAEndpoint), nameof(Resource));
        
        [Required]
        [JsonPropertyName("resource")]
        public HAResource Resource
        {
            get { return _resource.GetValue(); }
            set { _resource.SetValue(value); }
        }
    
        private PropertyValue<HAMethod> _method = new PropertyValue<HAMethod>(nameof(HAEndpoint), nameof(Method));
        
        [Required]
        [JsonPropertyName("method")]
        public HAMethod Method
        {
            get { return _method.GetValue(); }
            set { _method.SetValue(value); }
        }
    
        private PropertyValue<List<HAParameter>> _parameters = new PropertyValue<List<HAParameter>>(nameof(HAEndpoint), nameof(Parameters));
        
        [Required]
        [JsonPropertyName("parameters")]
        public List<HAParameter> Parameters
        {
            get { return _parameters.GetValue(); }
            set { _parameters.SetValue(value); }
        }
    
        private PropertyValue<HATypeObject?> _requestBody = new PropertyValue<HATypeObject?>(nameof(HAEndpoint), nameof(RequestBody));
        
        [JsonPropertyName("requestBody")]
        public HATypeObject? RequestBody
        {
            get { return _requestBody.GetValue(); }
            set { _requestBody.SetValue(value); }
        }
    
        private PropertyValue<HAType?> _responseBody = new PropertyValue<HAType?>(nameof(HAEndpoint), nameof(ResponseBody));
        
        [JsonPropertyName("responseBody")]
        public HAType? ResponseBody
        {
            get { return _responseBody.GetValue(); }
            set { _responseBody.SetValue(value); }
        }
    
        private PropertyValue<HAPath> _path = new PropertyValue<HAPath>(nameof(HAEndpoint), nameof(Path));
        
        [Required]
        [JsonPropertyName("path")]
        public HAPath Path
        {
            get { return _path.GetValue(); }
            set { _path.SetValue(value); }
        }
    
        private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(HAEndpoint), nameof(DisplayName));
        
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName
        {
            get { return _displayName.GetValue(); }
            set { _displayName.SetValue(value); }
        }
    
        private PropertyValue<string?> _doc = new PropertyValue<string?>(nameof(HAEndpoint), nameof(Doc));
        
        [JsonPropertyName("doc")]
        public string? Doc
        {
            get { return _doc.GetValue(); }
            set { _doc.SetValue(value); }
        }
    
        private PropertyValue<HADeprecation?> _deprecation = new PropertyValue<HADeprecation?>(nameof(HAEndpoint), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecation? Deprecation
        {
            get { return _deprecation.GetValue(); }
            set { _deprecation.SetValue(value); }
        }
    
        private PropertyValue<List<HARight>?> _rights = new PropertyValue<List<HARight>?>(nameof(HAEndpoint), nameof(Rights));
        
        [JsonPropertyName("rights")]
        public List<HARight>? Rights
        {
            get { return _rights.GetValue(); }
            set { _rights.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _resource.SetAccessPath(path, validateHasBeenSet);
            _method.SetAccessPath(path, validateHasBeenSet);
            _parameters.SetAccessPath(path, validateHasBeenSet);
            _requestBody.SetAccessPath(path, validateHasBeenSet);
            _responseBody.SetAccessPath(path, validateHasBeenSet);
            _path.SetAccessPath(path, validateHasBeenSet);
            _displayName.SetAccessPath(path, validateHasBeenSet);
            _doc.SetAccessPath(path, validateHasBeenSet);
            _deprecation.SetAccessPath(path, validateHasBeenSet);
            _rights.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
