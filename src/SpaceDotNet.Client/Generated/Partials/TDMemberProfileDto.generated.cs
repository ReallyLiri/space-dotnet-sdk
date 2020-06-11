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

namespace SpaceDotNet.Client.TDMemberProfileDtoExtensions
{
    public static class TDMemberProfileDtoPartialExtensions
    {
        public static Partial<TDMemberProfileDto> WithId(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDMemberProfileDto> WithUsername(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("username");
        
        public static Partial<TDMemberProfileDto> WithName(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("name");
        
        public static Partial<TDMemberProfileDto> WithName(this Partial<TDMemberProfileDto> it, Func<Partial<TDProfileNameDto>, Partial<TDProfileNameDto>> partialBuilder)
            => it.AddFieldName("name", partialBuilder(new Partial<TDProfileNameDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithSpeaksEnglish(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("speaksEnglish");
        
        public static Partial<TDMemberProfileDto> WithSmallAvatar(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("smallAvatar");
        
        public static Partial<TDMemberProfileDto> WithAvatar(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("avatar");
        
        public static Partial<TDMemberProfileDto> WithProfilePicture(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("profilePicture");
        
        public static Partial<TDMemberProfileDto> WithLanguages(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("languages");
        
        public static Partial<TDMemberProfileDto> WithLanguages(this Partial<TDMemberProfileDto> it, Func<Partial<TDProfileLanguageDto>, Partial<TDProfileLanguageDto>> partialBuilder)
            => it.AddFieldName("languages", partialBuilder(new Partial<TDProfileLanguageDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithArchived(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<TDMemberProfileDto> WithNotAMember(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<TDMemberProfileDto> WithJoined(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("joined");
        
        public static Partial<TDMemberProfileDto> WithLeft(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("left");
        
        public static Partial<TDMemberProfileDto> WithLeftAt(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("leftAt");
        
        public static Partial<TDMemberProfileDto> WithAbsences(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("absences");
        
        public static Partial<TDMemberProfileDto> WithAbsences(this Partial<TDMemberProfileDto> it, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder)
            => it.AddFieldName("absences", partialBuilder(new Partial<AbsenceRecordDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithEmails(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("emails");
        
        public static Partial<TDMemberProfileDto> WithEmails(this Partial<TDMemberProfileDto> it, Func<Partial<TDProfileEmailDto>, Partial<TDProfileEmailDto>> partialBuilder)
            => it.AddFieldName("emails", partialBuilder(new Partial<TDProfileEmailDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithLinks(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("links");
        
        public static Partial<TDMemberProfileDto> WithMessengers(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("messengers");
        
        public static Partial<TDMemberProfileDto> WithPhones(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("phones");
        
        public static Partial<TDMemberProfileDto> WithHolidays(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("holidays");
        
        public static Partial<TDMemberProfileDto> WithHolidays(this Partial<TDMemberProfileDto> it, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder)
            => it.AddFieldName("holidays", partialBuilder(new Partial<PublicHolidayDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithLocations(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("locations");
        
        public static Partial<TDMemberProfileDto> WithLocations(this Partial<TDMemberProfileDto> it, Func<Partial<TDMemberLocationDto>, Partial<TDMemberLocationDto>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDMemberLocationDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithManagers(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("managers");
        
        public static Partial<TDMemberProfileDto> WithManagersRecursive(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("managers!");
        
        public static Partial<TDMemberProfileDto> WithManagers(this Partial<TDMemberProfileDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("managers", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithMembershipHistory(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("membershipHistory");
        
        public static Partial<TDMemberProfileDto> WithMembershipHistory(this Partial<TDMemberProfileDto> it, Func<Partial<TDMembershipDto>, Partial<TDMembershipDto>> partialBuilder)
            => it.AddFieldName("membershipHistory", partialBuilder(new Partial<TDMembershipDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithMemberships(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("memberships");
        
        public static Partial<TDMemberProfileDto> WithMemberships(this Partial<TDMemberProfileDto> it, Func<Partial<TDMembershipDto>, Partial<TDMembershipDto>> partialBuilder)
            => it.AddFieldName("memberships", partialBuilder(new Partial<TDMembershipDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithAbout(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("about");
        
        public static Partial<TDMemberProfileDto> WithAvatarCropSquare(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("avatarCropSquare");
        
        public static Partial<TDMemberProfileDto> WithAvatarCropSquare(this Partial<TDMemberProfileDto> it, Func<Partial<AvatarCropSquareDto>, Partial<AvatarCropSquareDto>> partialBuilder)
            => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquareDto>(it)));
        
        public static Partial<TDMemberProfileDto> WithBirthday(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("birthday");
        
        public static Partial<TDMemberProfileDto> WithGender(this Partial<TDMemberProfileDto> it)
            => it.AddFieldName("gender");
        
        public static Partial<TDMemberProfileDto> WithGender(this Partial<TDMemberProfileDto> it, Func<Partial<Gender>, Partial<Gender>> partialBuilder)
            => it.AddFieldName("gender", partialBuilder(new Partial<Gender>(it)));
        
    }
    
}
