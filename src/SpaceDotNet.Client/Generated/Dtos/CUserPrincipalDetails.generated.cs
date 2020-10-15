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

namespace SpaceDotNet.Client
{
    public sealed class CUserPrincipalDetails
         : CPrincipalDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CUserPrincipalDetails";
        
        public CUserPrincipalDetails() { }
        
        public CUserPrincipalDetails(TDMemberProfile user)
        {
            User = user;
        }
        
        private PropertyValue<TDMemberProfile> _user = new PropertyValue<TDMemberProfile>(nameof(CUserPrincipalDetails), nameof(User));
        
        [Required]
        [JsonPropertyName("user")]
        public TDMemberProfile User
        {
            get { return _user.GetValue(); }
            set { _user.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _user.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
