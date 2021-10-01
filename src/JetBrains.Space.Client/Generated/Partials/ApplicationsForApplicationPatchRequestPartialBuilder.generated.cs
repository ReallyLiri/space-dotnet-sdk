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

namespace JetBrains.Space.Client.ApplicationsForApplicationPatchRequestPartialBuilder;

public static class ApplicationsForApplicationPatchRequestPartialExtensions
{
    public static Partial<ApplicationsForApplicationPatchRequest> WithName(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("name");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithPictureAttachmentId(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("pictureAttachmentId");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithDefaultExternalPicture(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("defaultExternalPicture");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithClientSecret(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("clientSecret");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsClientCredentialsFlowEnabled(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("clientCredentialsFlowEnabled");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsCodeFlowEnabled(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("codeFlowEnabled");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithCodeFlowRedirectURIs(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("codeFlowRedirectURIs");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsPkceRequired(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("pkceRequired");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsImplicitFlowEnabled(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("implicitFlowEnabled");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithImplicitFlowRedirectURIs(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("implicitFlowRedirectURIs");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithEndpointUri(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("endpointUri");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsEndpointSslVerification(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("endpointSslVerification");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsHasVerificationToken(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("hasVerificationToken");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsHasPublicKeySignature(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("hasPublicKeySignature");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithIsHasSigningKey(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("hasSigningKey");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithAppLevelAuth(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("appLevelAuth");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithAppLevelAuth(this Partial<ApplicationsForApplicationPatchRequest> it, Func<Partial<EndpointAppLevelAuthUpdateType>, Partial<EndpointAppLevelAuthUpdateType>> partialBuilder)
        => it.AddFieldName("appLevelAuth", partialBuilder(new Partial<EndpointAppLevelAuthUpdateType>(it)));
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithSslKeystoreAuth(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("sslKeystoreAuth");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithBasicAuthUsername(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("basicAuthUsername");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithBasicAuthPassword(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("basicAuthPassword");
    
    public static Partial<ApplicationsForApplicationPatchRequest> WithBearerAuthToken(this Partial<ApplicationsForApplicationPatchRequest> it)
        => it.AddFieldName("bearerAuthToken");
    
}

