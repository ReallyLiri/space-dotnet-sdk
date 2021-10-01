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

namespace JetBrains.Space.Client.OrganizationForUpdatePartialBuilder;

public static class OrganizationForUpdatePartialExtensions
{
    public static Partial<OrganizationForUpdate> WithName(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("name");
    
    public static Partial<OrganizationForUpdate> WithSlogan(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("slogan");
    
    public static Partial<OrganizationForUpdate> WithLogoSmall(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("logoSmall");
    
    public static Partial<OrganizationForUpdate> WithLogo(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("logo");
    
    public static Partial<OrganizationForUpdate> WithLogoId(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("logoId");
    
    public static Partial<OrganizationForUpdate> WithSlackWorkspace(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("slackWorkspace");
    
    public static Partial<OrganizationForUpdate> WithIsOnboardingRequired(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("onboardingRequired");
    
    public static Partial<OrganizationForUpdate> WithTimezone(this Partial<OrganizationForUpdate> it)
        => it.AddFieldName("timezone");
    
    public static Partial<OrganizationForUpdate> WithTimezone(this Partial<OrganizationForUpdate> it, Func<Partial<ATimeZone>, Partial<ATimeZone>> partialBuilder)
        => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZone>(it)));
    
}

