// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ProjectsSecretsPostRequestPartialBuilder
{
    public static class ProjectsSecretsPostRequestPartialExtensions
    {
        public static Partial<ProjectsSecretsPostRequest> WithBundleId(this Partial<ProjectsSecretsPostRequest> it)
            => it.AddFieldName("bundleId");
        
        public static Partial<ProjectsSecretsPostRequest> WithKey(this Partial<ProjectsSecretsPostRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<ProjectsSecretsPostRequest> WithValueBase64(this Partial<ProjectsSecretsPostRequest> it)
            => it.AddFieldName("valueBase64");
        
        public static Partial<ProjectsSecretsPostRequest> WithPublicKeyId(this Partial<ProjectsSecretsPostRequest> it)
            => it.AddFieldName("publicKeyId");
        
    }
    
}
