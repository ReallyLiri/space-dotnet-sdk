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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class TeamDirectoryInvitationsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryInvitationsPostRequest() { }
        
        public TeamDirectoryInvitationsPostRequest(string inviteeEmail, string? inviteeFirstName = null, string? inviteeLastName = null, TDTeam? team = null, TDRole? role = null)
        {
            InviteeEmail = inviteeEmail;
            InviteeFirstName = inviteeFirstName;
            InviteeLastName = inviteeLastName;
            Team = team;
            Role = role;
        }
        
        private PropertyValue<string> _inviteeEmail = new PropertyValue<string>(nameof(TeamDirectoryInvitationsPostRequest), nameof(InviteeEmail));
        
        [Required]
        [JsonPropertyName("inviteeEmail")]
        public string InviteeEmail
        {
            get => _inviteeEmail.GetValue();
            set => _inviteeEmail.SetValue(value);
        }
    
        private PropertyValue<string?> _inviteeFirstName = new PropertyValue<string?>(nameof(TeamDirectoryInvitationsPostRequest), nameof(InviteeFirstName));
        
        [JsonPropertyName("inviteeFirstName")]
        public string? InviteeFirstName
        {
            get => _inviteeFirstName.GetValue();
            set => _inviteeFirstName.SetValue(value);
        }
    
        private PropertyValue<string?> _inviteeLastName = new PropertyValue<string?>(nameof(TeamDirectoryInvitationsPostRequest), nameof(InviteeLastName));
        
        [JsonPropertyName("inviteeLastName")]
        public string? InviteeLastName
        {
            get => _inviteeLastName.GetValue();
            set => _inviteeLastName.SetValue(value);
        }
    
        private PropertyValue<TDTeam?> _team = new PropertyValue<TDTeam?>(nameof(TeamDirectoryInvitationsPostRequest), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeam? Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<TDRole?> _role = new PropertyValue<TDRole?>(nameof(TeamDirectoryInvitationsPostRequest), nameof(Role));
        
        [JsonPropertyName("role")]
        public TDRole? Role
        {
            get => _role.GetValue();
            set => _role.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _inviteeEmail.SetAccessPath(path, validateHasBeenSet);
            _inviteeFirstName.SetAccessPath(path, validateHasBeenSet);
            _inviteeLastName.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}