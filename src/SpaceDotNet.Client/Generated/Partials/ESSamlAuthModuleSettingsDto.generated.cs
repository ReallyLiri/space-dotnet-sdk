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

namespace SpaceDotNet.Client.ESSamlAuthModuleSettingsDtoExtensions
{
    public static class ESSamlAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESSamlAuthModuleSettingsDto> WithIdpUrl(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("idpUrl");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithIdpEntityId(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("idpEntityId");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithIdpCertificateSHA256(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("idpCertificateSHA256");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithSpEntityId(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("spEntityId");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithSslKeystore(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("sslKeystore");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithSslKeystore(this Partial<ESSamlAuthModuleSettingsDto> it, Func<Partial<SSLKeystoreDto>, Partial<SSLKeystoreDto>> partialBuilder)
            => it.AddFieldName("sslKeystore", partialBuilder(new Partial<SSLKeystoreDto>(it)));
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithContactProfileId(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("contactProfileId");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithAttributeNames(this Partial<ESSamlAuthModuleSettingsDto> it)
            => it.AddFieldName("attributeNames");
        
        public static Partial<ESSamlAuthModuleSettingsDto> WithAttributeNames(this Partial<ESSamlAuthModuleSettingsDto> it, Func<Partial<ESSamlAttributeNamesDto>, Partial<ESSamlAttributeNamesDto>> partialBuilder)
            => it.AddFieldName("attributeNames", partialBuilder(new Partial<ESSamlAttributeNamesDto>(it)));
        
    }
    
}
