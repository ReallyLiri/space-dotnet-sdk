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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForProfileSpokenLanguagesPostRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForProfileSpokenLanguagesPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> WithLanguage(this Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> it)
            => it.AddFieldName("language");
        
        public static Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> WithFirstName(this Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> it)
            => it.AddFieldName("firstName");
        
        public static Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> WithLastName(this Partial<TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest> it)
            => it.AddFieldName("lastName");
        
    }
    
}