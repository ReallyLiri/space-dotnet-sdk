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

namespace SpaceDotNet.Client.CreateTrustedCertificateRequestExtensions
{
    public static class CreateTrustedCertificateRequestDtoPartialExtensions
    {
        public static Partial<CreateTrustedCertificateRequestDto> WithAlias(this Partial<CreateTrustedCertificateRequestDto> it)
            => it.AddFieldName("alias");
        
        public static Partial<CreateTrustedCertificateRequestDto> WithData(this Partial<CreateTrustedCertificateRequestDto> it)
            => it.AddFieldName("data");
        
        public static Partial<CreateTrustedCertificateRequestDto> WithArchived(this Partial<CreateTrustedCertificateRequestDto> it)
            => it.AddFieldName("archived");
        
    }
    
}