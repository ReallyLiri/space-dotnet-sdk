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

namespace JetBrains.Space.Client.InitPayloadPartialBuilder;

public static class InitPayloadPartialExtensions
{
    public static Partial<InitPayload> WithClientSecret(this Partial<InitPayload> it)
        => it.AddFieldName("clientSecret");
    
    public static Partial<InitPayload> WithServerUrl(this Partial<InitPayload> it)
        => it.AddFieldName("serverUrl");
    
    public static Partial<InitPayload> WithState(this Partial<InitPayload> it)
        => it.AddFieldName("state");
    
    public static Partial<InitPayload> WithClientId(this Partial<InitPayload> it)
        => it.AddFieldName("clientId");
    
    public static Partial<InitPayload> WithUserId(this Partial<InitPayload> it)
        => it.AddFieldName("userId");
    
    public static Partial<InitPayload> WithVerificationToken(this Partial<InitPayload> it)
        => it.AddFieldName("verificationToken");
    
}

