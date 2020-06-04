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

namespace SpaceDotNet.Client.BGStatsDtoExtensions
{
    public static class BGStatsDtoPartialExtensions
    {
        public static Partial<BGStatsDto> WithTotalBlogs(this Partial<BGStatsDto> it)    => it.AddFieldName("totalBlogs");
        
        public static Partial<BGStatsDto> WithTeams(this Partial<BGStatsDto> it)    => it.AddFieldName("teams");
        
        public static Partial<BGStatsDto> WithTeams(this Partial<BGStatsDto> it, Func<Partial<Pair<TDTeamDto, int>>, Partial<Pair<TDTeamDto, int>>> partialBuilder)    => it.AddFieldName("teams", partialBuilder(new Partial<Pair<TDTeamDto, int>>()));
        
        public static Partial<BGStatsDto> WithProjects(this Partial<BGStatsDto> it)    => it.AddFieldName("projects");
        
        public static Partial<BGStatsDto> WithProjects(this Partial<BGStatsDto> it, Func<Partial<Pair<PRProjectDto, int>>, Partial<Pair<PRProjectDto, int>>> partialBuilder)    => it.AddFieldName("projects", partialBuilder(new Partial<Pair<PRProjectDto, int>>()));
        
        public static Partial<BGStatsDto> WithLocations(this Partial<BGStatsDto> it)    => it.AddFieldName("locations");
        
        public static Partial<BGStatsDto> WithLocations(this Partial<BGStatsDto> it, Func<Partial<Pair<TDLocationDto, int>>, Partial<Pair<TDLocationDto, int>>> partialBuilder)    => it.AddFieldName("locations", partialBuilder(new Partial<Pair<TDLocationDto, int>>()));
        
    }
    
}
