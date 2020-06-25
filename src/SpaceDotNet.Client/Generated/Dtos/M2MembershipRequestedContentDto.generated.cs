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
    public sealed class M2MembershipRequestedContentDto
         : M2MembershipContentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "M2MembershipRequestedContent";
        
        public M2MembershipRequestedContentDto() { }
        
        public M2MembershipRequestedContentDto(TDMembershipDto membership, bool leave)
        {
            Membership = membership;
            Leave = leave;
        }
        
        private PropertyValue<TDMembershipDto> _membership = new PropertyValue<TDMembershipDto>(nameof(M2MembershipRequestedContentDto), nameof(Membership));
        
        [Required]
        [JsonPropertyName("membership")]
        public TDMembershipDto Membership
        {
            get { return _membership.GetValue(); }
            set { _membership.SetValue(value); }
        }
    
        private PropertyValue<bool> _leave = new PropertyValue<bool>(nameof(M2MembershipRequestedContentDto), nameof(Leave));
        
        [Required]
        [JsonPropertyName("leave")]
        public bool Leave
        {
            get { return _leave.GetValue(); }
            set { _leave.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _membership.SetAccessPath(path, validateHasBeenSet);
            _leave.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
