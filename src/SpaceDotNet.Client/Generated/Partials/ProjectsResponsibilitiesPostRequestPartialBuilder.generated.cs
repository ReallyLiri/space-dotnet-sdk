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

namespace SpaceDotNet.Client.ProjectsResponsibilitiesPostRequestPartialBuilder
{
    public static class ProjectsResponsibilitiesPostRequestPartialExtensions
    {
        public static Partial<ProjectsResponsibilitiesPostRequest> WithSubjectId(this Partial<ProjectsResponsibilitiesPostRequest> it)
            => it.AddFieldName("subjectId");
        
        public static Partial<ProjectsResponsibilitiesPostRequest> WithSummary(this Partial<ProjectsResponsibilitiesPostRequest> it)
            => it.AddFieldName("summary");
        
        public static Partial<ProjectsResponsibilitiesPostRequest> WithNotes(this Partial<ProjectsResponsibilitiesPostRequest> it)
            => it.AddFieldName("notes");
        
    }
    
}