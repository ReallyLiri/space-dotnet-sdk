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

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryPostRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> WithDescription(this Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> WithInitialize(this Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> it)
            => it.AddFieldName("initialize");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> WithDefaultSetup(this Partial<ProjectsForProjectRepositoriesForRepositoryPostRequest> it)
            => it.AddFieldName("defaultSetup");
        
    }
    
}
