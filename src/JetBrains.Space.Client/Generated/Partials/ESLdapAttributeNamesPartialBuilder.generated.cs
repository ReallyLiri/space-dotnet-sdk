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

namespace JetBrains.Space.Client.ESLdapAttributeNamesPartialBuilder;

public static class ESLdapAttributeNamesPartialExtensions
{
    public static Partial<ESLdapAttributeNames> WithFullNameAttributeName(this Partial<ESLdapAttributeNames> it)
        => it.AddFieldName("fullNameAttributeName");
    
    public static Partial<ESLdapAttributeNames> WithUsernameAttributeName(this Partial<ESLdapAttributeNames> it)
        => it.AddFieldName("usernameAttributeName");
    
    public static Partial<ESLdapAttributeNames> WithEmailAttributeName(this Partial<ESLdapAttributeNames> it)
        => it.AddFieldName("emailAttributeName");
    
    public static Partial<ESLdapAttributeNames> WithGroupsAttributeName(this Partial<ESLdapAttributeNames> it)
        => it.AddFieldName("groupsAttributeName");
    
}

