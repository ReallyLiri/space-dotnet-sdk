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

namespace SpaceDotNet.Client.CreateImportSourceRequestDtoExtensions
{
    public static class CreateImportSourceRequestDtoPartialExtensions
    {
        public static Partial<CreateImportSourceRequestDto> WithName(this Partial<CreateImportSourceRequestDto> it)    => it.AddFieldName("name");
        
        public static Partial<CreateImportSourceRequestDto> WithImporterPrincipal(this Partial<CreateImportSourceRequestDto> it)    => it.AddFieldName("importerPrincipal");
        
    }
    
}
