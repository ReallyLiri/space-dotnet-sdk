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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.UAJetBrainsUserAgreementStatusAcceptedDtoPartialBuilder
{
    public static class UAJetBrainsUserAgreementStatusAcceptedDtoPartialExtensions
    {
        public static Partial<UAJetBrainsUserAgreementStatusAcceptedDto> WithProfile(this Partial<UAJetBrainsUserAgreementStatusAcceptedDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<UAJetBrainsUserAgreementStatusAcceptedDto> WithProfile(this Partial<UAJetBrainsUserAgreementStatusAcceptedDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<UAJetBrainsUserAgreementStatusAcceptedDto> WithVersion(this Partial<UAJetBrainsUserAgreementStatusAcceptedDto> it)
            => it.AddFieldName("version");
        
        public static Partial<UAJetBrainsUserAgreementStatusAcceptedDto> WithVersion(this Partial<UAJetBrainsUserAgreementStatusAcceptedDto> it, Func<Partial<UAVersionDto>, Partial<UAVersionDto>> partialBuilder)
            => it.AddFieldName("version", partialBuilder(new Partial<UAVersionDto>(it)));
        
        public static Partial<UAJetBrainsUserAgreementStatusAcceptedDto> WithAccepted(this Partial<UAJetBrainsUserAgreementStatusAcceptedDto> it)
            => it.AddFieldName("accepted");
        
    }
    
}