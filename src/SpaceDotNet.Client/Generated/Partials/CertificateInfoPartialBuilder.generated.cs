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

namespace SpaceDotNet.Client.CertificateInfoPartialBuilder
{
    public static class CertificateInfoPartialExtensions
    {
        public static Partial<CertificateInfo> WithCertificateType(this Partial<CertificateInfo> it)
            => it.AddFieldName("certificateType");
        
        public static Partial<CertificateInfo> WithVersion(this Partial<CertificateInfo> it)
            => it.AddFieldName("version");
        
        public static Partial<CertificateInfo> WithSerialNumber(this Partial<CertificateInfo> it)
            => it.AddFieldName("serialNumber");
        
        public static Partial<CertificateInfo> WithIssuedBy(this Partial<CertificateInfo> it)
            => it.AddFieldName("issuedBy");
        
        public static Partial<CertificateInfo> WithIssuedTo(this Partial<CertificateInfo> it)
            => it.AddFieldName("issuedTo");
        
        public static Partial<CertificateInfo> WithValidFrom(this Partial<CertificateInfo> it)
            => it.AddFieldName("validFrom");
        
        public static Partial<CertificateInfo> WithValidTo(this Partial<CertificateInfo> it)
            => it.AddFieldName("validTo");
        
        public static Partial<CertificateInfo> WithAlgorithm(this Partial<CertificateInfo> it)
            => it.AddFieldName("algorithm");
        
        public static Partial<CertificateInfo> WithFingerprint(this Partial<CertificateInfo> it)
            => it.AddFieldName("fingerprint");
        
        public static Partial<CertificateInfo> WithFingerprint(this Partial<CertificateInfo> it, Func<Partial<Fingerprint>, Partial<Fingerprint>> partialBuilder)
            => it.AddFieldName("fingerprint", partialBuilder(new Partial<Fingerprint>(it)));
        
    }
    
}
