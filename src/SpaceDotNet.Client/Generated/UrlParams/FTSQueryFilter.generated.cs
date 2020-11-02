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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class FTSQueryFilter : IUrlParameter
    {
        public static FTSQueryFilter Channel(string channelId)
            => new FTSQueryFilterChannel(channelId);
        
        public static FTSQueryFilter Book(string bookId)
            => new FTSQueryFilterBook(bookId);
        
        public static FTSQueryFilter Project(string projectId)
            => new FTSQueryFilterProject(projectId);
        
        private class FTSQueryFilterChannel : FTSQueryFilter
        {
            private readonly string _channelId;
            
            public FTSQueryFilterChannel(string channelId)
                => _channelId = channelId;
            
            public override string ToString()
                => $"channelId:{_channelId}";
        }
        
        private class FTSQueryFilterBook : FTSQueryFilter
        {
            private readonly string _bookId;
            
            public FTSQueryFilterBook(string bookId)
                => _bookId = bookId;
            
            public override string ToString()
                => $"bookId:{_bookId}";
        }
        
        private class FTSQueryFilterProject : FTSQueryFilter
        {
            private readonly string _projectId;
            
            public FTSQueryFilterProject(string projectId)
                => _projectId = projectId;
            
            public override string ToString()
                => $"projectId:{_projectId}";
        }
        
    }
    
}
