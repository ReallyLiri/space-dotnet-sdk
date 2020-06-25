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

namespace SpaceDotNet.Client
{
    public abstract class ESFederatedAuthModuleSettingsDto
         : ESAuthModuleSettingsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_FederatedAuthModuleSettings";
        
        public static ESSamlAuthModuleSettingsDto ESSamlAuthModuleSettings(string idpUrl, string idpEntityId, string idpCertificateSHA256, string spEntityId, bool registerNewUsers, ESSamlAttributeNamesDto attributeNames, SSLKeystoreDto? sslKeystore = null, string? contactProfileId = null)
            => new ESSamlAuthModuleSettingsDto(idpUrl: idpUrl, idpEntityId: idpEntityId, idpCertificateSHA256: idpCertificateSHA256, spEntityId: spEntityId, registerNewUsers: registerNewUsers, attributeNames: attributeNames, sslKeystore: null, contactProfileId: null);
        
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
