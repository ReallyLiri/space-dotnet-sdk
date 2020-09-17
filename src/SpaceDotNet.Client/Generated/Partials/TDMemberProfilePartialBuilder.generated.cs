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

namespace SpaceDotNet.Client.TDMemberProfilePartialBuilder
{
    public static class TDMemberProfilePartialExtensions
    {
        public static Partial<TDMemberProfile> WithId(this Partial<TDMemberProfile> it)
            => it.AddFieldName("id");
        
        public static Partial<TDMemberProfile> WithUsername(this Partial<TDMemberProfile> it)
            => it.AddFieldName("username");
        
        public static Partial<TDMemberProfile> WithName(this Partial<TDMemberProfile> it)
            => it.AddFieldName("name");
        
        public static Partial<TDMemberProfile> WithName(this Partial<TDMemberProfile> it, Func<Partial<TDProfileName>, Partial<TDProfileName>> partialBuilder)
            => it.AddFieldName("name", partialBuilder(new Partial<TDProfileName>(it)));
        
        public static Partial<TDMemberProfile> WithIsSpeaksEnglish(this Partial<TDMemberProfile> it)
            => it.AddFieldName("speaksEnglish");
        
        public static Partial<TDMemberProfile> WithSmallAvatar(this Partial<TDMemberProfile> it)
            => it.AddFieldName("smallAvatar");
        
        public static Partial<TDMemberProfile> WithAvatar(this Partial<TDMemberProfile> it)
            => it.AddFieldName("avatar");
        
        public static Partial<TDMemberProfile> WithProfilePicture(this Partial<TDMemberProfile> it)
            => it.AddFieldName("profilePicture");
        
        public static Partial<TDMemberProfile> WithLanguages(this Partial<TDMemberProfile> it)
            => it.AddFieldName("languages");
        
        public static Partial<TDMemberProfile> WithLanguages(this Partial<TDMemberProfile> it, Func<Partial<TDProfileLanguage>, Partial<TDProfileLanguage>> partialBuilder)
            => it.AddFieldName("languages", partialBuilder(new Partial<TDProfileLanguage>(it)));
        
        public static Partial<TDMemberProfile> WithIsArchived(this Partial<TDMemberProfile> it)
            => it.AddFieldName("archived");
        
        public static Partial<TDMemberProfile> WithIsNotAMember(this Partial<TDMemberProfile> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<TDMemberProfile> WithJoined(this Partial<TDMemberProfile> it)
            => it.AddFieldName("joined");
        
        public static Partial<TDMemberProfile> WithLeft(this Partial<TDMemberProfile> it)
            => it.AddFieldName("left");
        
        public static Partial<TDMemberProfile> WithLeftAt(this Partial<TDMemberProfile> it)
            => it.AddFieldName("leftAt");
        
        public static Partial<TDMemberProfile> WithAbsences(this Partial<TDMemberProfile> it)
            => it.AddFieldName("absences");
        
        public static Partial<TDMemberProfile> WithAbsences(this Partial<TDMemberProfile> it, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>> partialBuilder)
            => it.AddFieldName("absences", partialBuilder(new Partial<AbsenceRecord>(it)));
        
        public static Partial<TDMemberProfile> WithEmails(this Partial<TDMemberProfile> it)
            => it.AddFieldName("emails");
        
        public static Partial<TDMemberProfile> WithEmails(this Partial<TDMemberProfile> it, Func<Partial<TDProfileEmail>, Partial<TDProfileEmail>> partialBuilder)
            => it.AddFieldName("emails", partialBuilder(new Partial<TDProfileEmail>(it)));
        
        public static Partial<TDMemberProfile> WithLinks(this Partial<TDMemberProfile> it)
            => it.AddFieldName("links");
        
        public static Partial<TDMemberProfile> WithMessengers(this Partial<TDMemberProfile> it)
            => it.AddFieldName("messengers");
        
        public static Partial<TDMemberProfile> WithPhones(this Partial<TDMemberProfile> it)
            => it.AddFieldName("phones");
        
        public static Partial<TDMemberProfile> WithFolder(this Partial<TDMemberProfile> it)
            => it.AddFieldName("folder");
        
        public static Partial<TDMemberProfile> WithFolder(this Partial<TDMemberProfile> it, Func<Partial<DocumentFolderRecord>, Partial<DocumentFolderRecord>> partialBuilder)
            => it.AddFieldName("folder", partialBuilder(new Partial<DocumentFolderRecord>(it)));
        
        public static Partial<TDMemberProfile> WithHolidays(this Partial<TDMemberProfile> it)
            => it.AddFieldName("holidays");
        
        public static Partial<TDMemberProfile> WithHolidays(this Partial<TDMemberProfile> it, Func<Partial<PublicHoliday>, Partial<PublicHoliday>> partialBuilder)
            => it.AddFieldName("holidays", partialBuilder(new Partial<PublicHoliday>(it)));
        
        public static Partial<TDMemberProfile> WithLocations(this Partial<TDMemberProfile> it)
            => it.AddFieldName("locations");
        
        public static Partial<TDMemberProfile> WithLocations(this Partial<TDMemberProfile> it, Func<Partial<TDMemberLocation>, Partial<TDMemberLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDMemberLocation>(it)));
        
        public static Partial<TDMemberProfile> WithManagers(this Partial<TDMemberProfile> it)
            => it.AddFieldName("managers");
        
        public static Partial<TDMemberProfile> WithManagersRecursive(this Partial<TDMemberProfile> it)
            => it.AddFieldName("managers!");
        
        public static Partial<TDMemberProfile> WithManagers(this Partial<TDMemberProfile> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("managers", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<TDMemberProfile> WithMembershipHistory(this Partial<TDMemberProfile> it)
            => it.AddFieldName("membershipHistory");
        
        public static Partial<TDMemberProfile> WithMembershipHistory(this Partial<TDMemberProfile> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("membershipHistory", partialBuilder(new Partial<TDMembership>(it)));
        
        public static Partial<TDMemberProfile> WithMemberships(this Partial<TDMemberProfile> it)
            => it.AddFieldName("memberships");
        
        public static Partial<TDMemberProfile> WithMemberships(this Partial<TDMemberProfile> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("memberships", partialBuilder(new Partial<TDMembership>(it)));
        
        public static Partial<TDMemberProfile> WithIsOnboardingRequired(this Partial<TDMemberProfile> it)
            => it.AddFieldName("onboardingRequired");
        
        public static Partial<TDMemberProfile> WithIsShowBannerOnLandingPage(this Partial<TDMemberProfile> it)
            => it.AddFieldName("showBannerOnLandingPage");
        
        public static Partial<TDMemberProfile> WithIsShowBannerOnProjectPage(this Partial<TDMemberProfile> it)
            => it.AddFieldName("showBannerOnProjectPage");
        
        public static Partial<TDMemberProfile> WithIsShowBannerOnTeamDirectoryHomePage(this Partial<TDMemberProfile> it)
            => it.AddFieldName("showBannerOnTeamDirectoryHomePage");
        
        public static Partial<TDMemberProfile> WithAbout(this Partial<TDMemberProfile> it)
            => it.AddFieldName("about");
        
        public static Partial<TDMemberProfile> WithAvatarCropSquare(this Partial<TDMemberProfile> it)
            => it.AddFieldName("avatarCropSquare");
        
        public static Partial<TDMemberProfile> WithAvatarCropSquare(this Partial<TDMemberProfile> it, Func<Partial<AvatarCropSquare>, Partial<AvatarCropSquare>> partialBuilder)
            => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquare>(it)));
        
        public static Partial<TDMemberProfile> WithBirthday(this Partial<TDMemberProfile> it)
            => it.AddFieldName("birthday");
        
        public static Partial<TDMemberProfile> WithGender(this Partial<TDMemberProfile> it)
            => it.AddFieldName("gender");
        
        public static Partial<TDMemberProfile> WithGender(this Partial<TDMemberProfile> it, Func<Partial<Gender>, Partial<Gender>> partialBuilder)
            => it.AddFieldName("gender", partialBuilder(new Partial<Gender>(it)));
        
        public static Partial<TDMemberProfile> WithCustomFields(this Partial<TDMemberProfile> it)
            => it.AddFieldName("customFields");
        
        public static Partial<TDMemberProfile> WithCustomFields(this Partial<TDMemberProfile> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
            => it.AddFieldName("customFields", partialBuilder(new Partial<CFValue>(it)));
        
    }
    
}