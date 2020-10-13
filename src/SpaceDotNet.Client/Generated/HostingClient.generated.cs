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

namespace SpaceDotNet.Client
{
    public partial class HostingClient
    {
        private readonly Connection _connection;
        
        public HostingClient(Connection connection)
        {
            _connection = connection;
        }
        
        public SiteClient Site => new SiteClient(_connection);
        
        public partial class SiteClient
        {
            private readonly Connection _connection;
            
            public SiteClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Publish new site or refresh existing. 
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Publish static site</term>
            /// <description>Allow publish static sites from Automations job</description>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<PublishSite> PublishSiteAsync(string siteName, string versionId, HostingSiteSettings settings, Func<Partial<PublishSite>, Partial<PublishSite>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<HostingSitePostRequest, PublishSite>("POST", $"api/http/hosting/site?$fields={(partial != null ? partial(new Partial<PublishSite>()) : Partial<PublishSite>.Default())}", 
                    new HostingSitePostRequest { 
                        SiteName = siteName,
                        VersionId = versionId,
                        Settings = settings,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Get URL to upload site archive before publish
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Publish static site</term>
            /// <description>Allow publish static sites from Automations job</description>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<CreateUploadUrlResponse> CreateUploadURLAsync(string siteName, Func<Partial<CreateUploadUrlResponse>, Partial<CreateUploadUrlResponse>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<HostingSiteUploadUrlPostRequest, CreateUploadUrlResponse>("POST", $"api/http/hosting/site/upload-url?$fields={(partial != null ? partial(new Partial<CreateUploadUrlResponse>()) : Partial<CreateUploadUrlResponse>.Default())}", 
                    new HostingSiteUploadUrlPostRequest { 
                        SiteName = siteName,
                    }
            , cancellationToken);
        
        }
    
    }
    
}