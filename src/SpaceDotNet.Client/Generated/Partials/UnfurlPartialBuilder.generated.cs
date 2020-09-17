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

namespace SpaceDotNet.Client.UnfurlPartialBuilder
{
    public static class UnfurlPartialExtensions
    {
        public static Partial<Unfurl> WithTitle(this Partial<Unfurl> it)
            => it.AddFieldName("title");
        
        public static Partial<Unfurl> WithLink(this Partial<Unfurl> it)
            => it.AddFieldName("link");
        
        public static Partial<Unfurl> WithText(this Partial<Unfurl> it)
            => it.AddFieldName("text");
        
        public static Partial<Unfurl> WithDetails(this Partial<Unfurl> it)
            => it.AddFieldName("details");
        
        public static Partial<Unfurl> WithDetails(this Partial<Unfurl> it, Func<Partial<UnfurlDetails>, Partial<UnfurlDetails>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<UnfurlDetails>(it)));
        
        public static Partial<Unfurl> WithSitename(this Partial<Unfurl> it)
            => it.AddFieldName("sitename");
        
        public static Partial<Unfurl> WithImage(this Partial<Unfurl> it)
            => it.AddFieldName("image");
        
        public static Partial<Unfurl> WithImageMime(this Partial<Unfurl> it)
            => it.AddFieldName("imageMime");
        
        public static Partial<Unfurl> WithImageWidth(this Partial<Unfurl> it)
            => it.AddFieldName("imageWidth");
        
        public static Partial<Unfurl> WithImageHeight(this Partial<Unfurl> it)
            => it.AddFieldName("imageHeight");
        
        public static Partial<Unfurl> WithVideo(this Partial<Unfurl> it)
            => it.AddFieldName("video");
        
        public static Partial<Unfurl> WithVideoIFrame(this Partial<Unfurl> it)
            => it.AddFieldName("videoIFrame");
        
        public static Partial<Unfurl> WithVideoMime(this Partial<Unfurl> it)
            => it.AddFieldName("videoMime");
        
        public static Partial<Unfurl> WithVideoHeight(this Partial<Unfurl> it)
            => it.AddFieldName("videoHeight");
        
        public static Partial<Unfurl> WithVideoWidth(this Partial<Unfurl> it)
            => it.AddFieldName("videoWidth");
        
        public static Partial<Unfurl> WithFavicon(this Partial<Unfurl> it)
            => it.AddFieldName("favicon");
        
    }
    
}