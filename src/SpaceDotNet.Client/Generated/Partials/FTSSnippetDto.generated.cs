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

namespace SpaceDotNet.Client.FTSSnippetDtoExtensions
{
    public static class FTSSnippetDtoPartialExtensions
    {
        public static Partial<FTSSnippetDto> WithField(this Partial<FTSSnippetDto> it)    => it.AddFieldName("field");
        
        public static Partial<FTSSnippetDto> WithSnippet(this Partial<FTSSnippetDto> it)    => it.AddFieldName("snippet");
        
    }
    
}
