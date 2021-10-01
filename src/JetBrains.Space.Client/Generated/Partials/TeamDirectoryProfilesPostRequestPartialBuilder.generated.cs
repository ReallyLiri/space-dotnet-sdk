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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TeamDirectoryProfilesPostRequestPartialBuilder;

public static class TeamDirectoryProfilesPostRequestPartialExtensions
{
    public static Partial<TeamDirectoryProfilesPostRequest> WithUsername(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("username");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithFirstName(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("firstName");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithLastName(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("lastName");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithEmails(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("emails");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithPhones(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("phones");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithBirthday(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("birthday");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithAbout(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("about");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithMessengers(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("messengers");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithLinks(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("links");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithIsNotAMember(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("notAMember");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithJoined(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("joined");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithLeft(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("left");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithLeftAt(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("leftAt");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithIsSpeaksEnglish(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("speaksEnglish");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithPictureAttachmentId(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("pictureAttachmentId");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("avatarCropSquare");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesPostRequest> it, Func<Partial<AvatarCropSquare>, Partial<AvatarCropSquare>> partialBuilder)
        => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquare>(it)));
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("customFieldValues");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesPostRequest> it, Func<Partial<CustomFieldInputValue>, Partial<CustomFieldInputValue>> partialBuilder)
        => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldInputValue>(it)));
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithLocation(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("location");
    
    public static Partial<TeamDirectoryProfilesPostRequest> WithIsExternal(this Partial<TeamDirectoryProfilesPostRequest> it)
        => it.AddFieldName("external");
    
}

