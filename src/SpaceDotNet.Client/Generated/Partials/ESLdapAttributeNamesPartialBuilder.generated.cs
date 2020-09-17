// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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

namespace SpaceDotNet.Client.ESLdapAttributeNamesPartialBuilder
{
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
    
}