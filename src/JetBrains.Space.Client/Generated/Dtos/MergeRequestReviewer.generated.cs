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
    public sealed class MergeRequestReviewer
         : IPropagatePropertyAccessPath
    {
        public MergeRequestReviewer() { }
        
        public MergeRequestReviewer(string profileId, CodeReviewParticipantQualityGateSlot? qualityGateSlot = null)
        {
            ProfileId = profileId;
            QualityGateSlot = qualityGateSlot;
        }
        
        private PropertyValue<string> _profileId = new PropertyValue<string>(nameof(MergeRequestReviewer), nameof(ProfileId));
        
        [Required]
        [JsonPropertyName("profileId")]
        public string ProfileId
        {
            get => _profileId.GetValue();
            set => _profileId.SetValue(value);
        }
    
        private PropertyValue<CodeReviewParticipantQualityGateSlot?> _qualityGateSlot = new PropertyValue<CodeReviewParticipantQualityGateSlot?>(nameof(MergeRequestReviewer), nameof(QualityGateSlot));
        
        [JsonPropertyName("qualityGateSlot")]
        public CodeReviewParticipantQualityGateSlot? QualityGateSlot
        {
            get => _qualityGateSlot.GetValue();
            set => _qualityGateSlot.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profileId.SetAccessPath(path, validateHasBeenSet);
            _qualityGateSlot.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}