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

namespace JetBrains.Space.Client.ApplicationAuthorizedWebhookEventPartialBuilder;

public static class ApplicationAuthorizedWebhookEventPartialExtensions
{
    public static Partial<ApplicationAuthorizedWebhookEvent> WithMeta(this Partial<ApplicationAuthorizedWebhookEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<ApplicationAuthorizedWebhookEvent> WithMeta(this Partial<ApplicationAuthorizedWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<ApplicationAuthorizedWebhookEvent> WithApplication(this Partial<ApplicationAuthorizedWebhookEvent> it)
        => it.AddFieldName("application");
    
    public static Partial<ApplicationAuthorizedWebhookEvent> WithApplication(this Partial<ApplicationAuthorizedWebhookEvent> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
        => it.AddFieldName("application", partialBuilder(new Partial<ESApp>(it)));
    
    public static Partial<ApplicationAuthorizedWebhookEvent> WithScope(this Partial<ApplicationAuthorizedWebhookEvent> it)
        => it.AddFieldName("scope");
    
    public static Partial<ApplicationAuthorizedWebhookEvent> WithScope(this Partial<ApplicationAuthorizedWebhookEvent> it, Func<Partial<AuthScope>, Partial<AuthScope>> partialBuilder)
        => it.AddFieldName("scope", partialBuilder(new Partial<AuthScope>(it)));
    
}

