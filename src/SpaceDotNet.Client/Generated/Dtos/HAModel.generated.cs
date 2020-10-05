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
    public sealed class HAModel
         : IPropagatePropertyAccessPath
    {
        public HAModel() { }
        
        public HAModel(List<HADto> dto, List<HAEnum> enums, List<HAUrlParameter> urlParams, List<HAResource> resources, List<HAResource> allResources, List<HAMenuId> menuIds)
        {
            Dto = dto;
            Enums = enums;
            UrlParams = urlParams;
            Resources = resources;
            AllResources = allResources;
            MenuIds = menuIds;
        }
        
        private PropertyValue<List<HADto>> _dto = new PropertyValue<List<HADto>>(nameof(HAModel), nameof(Dto));
        
        [Required]
        [JsonPropertyName("dto")]
        public List<HADto> Dto
        {
            get { return _dto.GetValue(); }
            set { _dto.SetValue(value); }
        }
    
        private PropertyValue<List<HAEnum>> _enums = new PropertyValue<List<HAEnum>>(nameof(HAModel), nameof(Enums));
        
        [Required]
        [JsonPropertyName("enums")]
        public List<HAEnum> Enums
        {
            get { return _enums.GetValue(); }
            set { _enums.SetValue(value); }
        }
    
        private PropertyValue<List<HAUrlParameter>> _urlParams = new PropertyValue<List<HAUrlParameter>>(nameof(HAModel), nameof(UrlParams));
        
        [Required]
        [JsonPropertyName("urlParams")]
        public List<HAUrlParameter> UrlParams
        {
            get { return _urlParams.GetValue(); }
            set { _urlParams.SetValue(value); }
        }
    
        private PropertyValue<List<HAResource>> _resources = new PropertyValue<List<HAResource>>(nameof(HAModel), nameof(Resources));
        
        [Required]
        [JsonPropertyName("resources")]
        public List<HAResource> Resources
        {
            get { return _resources.GetValue(); }
            set { _resources.SetValue(value); }
        }
    
        private PropertyValue<List<HAResource>> _allResources = new PropertyValue<List<HAResource>>(nameof(HAModel), nameof(AllResources));
        
        [Required]
        [JsonPropertyName("allResources")]
        public List<HAResource> AllResources
        {
            get { return _allResources.GetValue(); }
            set { _allResources.SetValue(value); }
        }
    
        private PropertyValue<List<HAMenuId>> _menuIds = new PropertyValue<List<HAMenuId>>(nameof(HAModel), nameof(MenuIds));
        
        [Required]
        [JsonPropertyName("menuIds")]
        public List<HAMenuId> MenuIds
        {
            get { return _menuIds.GetValue(); }
            set { _menuIds.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _dto.SetAccessPath(path, validateHasBeenSet);
            _enums.SetAccessPath(path, validateHasBeenSet);
            _urlParams.SetAccessPath(path, validateHasBeenSet);
            _resources.SetAccessPath(path, validateHasBeenSet);
            _allResources.SetAccessPath(path, validateHasBeenSet);
            _menuIds.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
