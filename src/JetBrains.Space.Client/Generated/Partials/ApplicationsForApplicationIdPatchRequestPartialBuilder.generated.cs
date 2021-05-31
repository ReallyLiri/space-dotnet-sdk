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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ApplicationsForApplicationIdPatchRequestPartialBuilder
{
    public static class ApplicationsForApplicationIdPatchRequestPartialExtensions
    {
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithName(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithClientSecret(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("clientSecret");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsClientCredentialsFlowEnabled(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("clientCredentialsFlowEnabled");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsCodeFlowEnabled(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("codeFlowEnabled");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithCodeFlowRedirectURIs(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("codeFlowRedirectURIs");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsPkceRequired(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("pkceRequired");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsImplicitFlowEnabled(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("implicitFlowEnabled");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithImplicitFlowRedirectURIs(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("implicitFlowRedirectURIs");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithEndpointUri(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("endpointUri");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsEndpointSslVerification(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("endpointSslVerification");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsHasVerificationToken(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("hasVerificationToken");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithIsHasSigningKey(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("hasSigningKey");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithBasicAuthUsername(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("basicAuthUsername");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithBasicAuthPassword(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("basicAuthPassword");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithBearerAuthToken(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("bearerAuthToken");
        
        public static Partial<ApplicationsForApplicationIdPatchRequest> WithSslKeystoreAuth(this Partial<ApplicationsForApplicationIdPatchRequest> it)
            => it.AddFieldName("sslKeystoreAuth");
        
    }
    
}
