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

namespace SpaceDotNet.Client.KBFolderPartialBuilder
{
    public static class KBFolderPartialExtensions
    {
        public static Partial<KBFolder> WithId(this Partial<KBFolder> it)
            => it.AddFieldName("id");
        
        public static Partial<KBFolder> WithIsArchived(this Partial<KBFolder> it)
            => it.AddFieldName("archived");
        
        public static Partial<KBFolder> WithName(this Partial<KBFolder> it)
            => it.AddFieldName("name");
        
        public static Partial<KBFolder> WithParent(this Partial<KBFolder> it)
            => it.AddFieldName("parent");
        
        public static Partial<KBFolder> WithParentRecursive(this Partial<KBFolder> it)
            => it.AddFieldName("parent!");
        
        public static Partial<KBFolder> WithParent(this Partial<KBFolder> it, Func<Partial<KBFolder>, Partial<KBFolder>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<KBFolder>(it)));
        
        public static Partial<KBFolder> WithSubfolders(this Partial<KBFolder> it)
            => it.AddFieldName("subfolders");
        
        public static Partial<KBFolder> WithSubfoldersRecursive(this Partial<KBFolder> it)
            => it.AddFieldName("subfolders!");
        
        public static Partial<KBFolder> WithSubfolders(this Partial<KBFolder> it, Func<Partial<KBFolder>, Partial<KBFolder>> partialBuilder)
            => it.AddFieldName("subfolders", partialBuilder(new Partial<KBFolder>(it)));
        
        public static Partial<KBFolder> WithArticles(this Partial<KBFolder> it)
            => it.AddFieldName("articles");
        
        public static Partial<KBFolder> WithArticles(this Partial<KBFolder> it, Func<Partial<KBArticle>, Partial<KBArticle>> partialBuilder)
            => it.AddFieldName("articles", partialBuilder(new Partial<KBArticle>(it)));
        
        public static Partial<KBFolder> WithBook(this Partial<KBFolder> it)
            => it.AddFieldName("book");
        
        public static Partial<KBFolder> WithBook(this Partial<KBFolder> it, Func<Partial<KBBook>, Partial<KBBook>> partialBuilder)
            => it.AddFieldName("book", partialBuilder(new Partial<KBBook>(it)));
        
        public static Partial<KBFolder> WithCover(this Partial<KBFolder> it)
            => it.AddFieldName("cover");
        
        public static Partial<KBFolder> WithCover(this Partial<KBFolder> it, Func<Partial<KBArticle>, Partial<KBArticle>> partialBuilder)
            => it.AddFieldName("cover", partialBuilder(new Partial<KBArticle>(it)));
        
        public static Partial<KBFolder> WithAlias(this Partial<KBFolder> it)
            => it.AddFieldName("alias");
        
    }
    
}