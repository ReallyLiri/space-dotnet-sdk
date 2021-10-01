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

namespace JetBrains.Space.Client;

public class TeamDirectoryProfilesForProfilePatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfilePatchRequest() { }
    
    public TeamDirectoryProfilesForProfilePatchRequest(string? username = null, string? firstName = null, string? lastName = null, List<string>? emails = null, List<string>? phones = null, DateTime? birthday = null, string? about = null, List<string>? messengers = null, List<string>? links = null, bool? notAMember = null, DateTime? joined = null, DateTime? left = null, DateTime? leftAt = null, bool? speaksEnglish = null, string? pictureAttachmentId = null, AvatarCropSquare? avatarCropSquare = null, List<CustomFieldInputValue>? customFieldValues = null)
    {
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Emails = emails;
        Phones = phones;
        Birthday = birthday;
        About = about;
        Messengers = messengers;
        Links = links;
        IsNotAMember = notAMember;
        Joined = joined;
        Left = left;
        LeftAt = leftAt;
        IsSpeaksEnglish = speaksEnglish;
        PictureAttachmentId = pictureAttachmentId;
        AvatarCropSquare = avatarCropSquare;
        CustomFieldValues = customFieldValues;
    }
    
    private PropertyValue<string?> _username = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Username));
    
    [JsonPropertyName("username")]
    public string? Username
    {
        get => _username.GetValue();
        set => _username.SetValue(value);
    }

    private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(FirstName));
    
    [JsonPropertyName("firstName")]
    public string? FirstName
    {
        get => _firstName.GetValue();
        set => _firstName.SetValue(value);
    }

    private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(LastName));
    
    [JsonPropertyName("lastName")]
    public string? LastName
    {
        get => _lastName.GetValue();
        set => _lastName.SetValue(value);
    }

    private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Emails));
    
    [JsonPropertyName("emails")]
    public List<string>? Emails
    {
        get => _emails.GetValue();
        set => _emails.SetValue(value);
    }

    private PropertyValue<List<string>?> _phones = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Phones));
    
    [JsonPropertyName("phones")]
    public List<string>? Phones
    {
        get => _phones.GetValue();
        set => _phones.SetValue(value);
    }

    private PropertyValue<DateTime?> _birthday = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Birthday));
    
    [JsonPropertyName("birthday")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Birthday
    {
        get => _birthday.GetValue();
        set => _birthday.SetValue(value);
    }

    private PropertyValue<string?> _about = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(About));
    
    [JsonPropertyName("about")]
    public string? About
    {
        get => _about.GetValue();
        set => _about.SetValue(value);
    }

    private PropertyValue<List<string>?> _messengers = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Messengers));
    
    [JsonPropertyName("messengers")]
    public List<string>? Messengers
    {
        get => _messengers.GetValue();
        set => _messengers.SetValue(value);
    }

    private PropertyValue<List<string>?> _links = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Links));
    
    [JsonPropertyName("links")]
    public List<string>? Links
    {
        get => _links.GetValue();
        set => _links.SetValue(value);
    }

    private PropertyValue<bool?> _notAMember = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(IsNotAMember));
    
    [JsonPropertyName("notAMember")]
    public bool? IsNotAMember
    {
        get => _notAMember.GetValue();
        set => _notAMember.SetValue(value);
    }

    private PropertyValue<DateTime?> _joined = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Joined));
    
    [JsonPropertyName("joined")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Joined
    {
        get => _joined.GetValue();
        set => _joined.SetValue(value);
    }

    private PropertyValue<DateTime?> _left = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Left));
    
    [JsonPropertyName("left")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Left
    {
        get => _left.GetValue();
        set => _left.SetValue(value);
    }

    private PropertyValue<DateTime?> _leftAt = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(LeftAt));
    
    [JsonPropertyName("leftAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LeftAt
    {
        get => _leftAt.GetValue();
        set => _leftAt.SetValue(value);
    }

    private PropertyValue<bool?> _speaksEnglish = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(IsSpeaksEnglish));
    
    [JsonPropertyName("speaksEnglish")]
    public bool? IsSpeaksEnglish
    {
        get => _speaksEnglish.GetValue();
        set => _speaksEnglish.SetValue(value);
    }

    private PropertyValue<string?> _pictureAttachmentId = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(PictureAttachmentId));
    
    [JsonPropertyName("pictureAttachmentId")]
    public string? PictureAttachmentId
    {
        get => _pictureAttachmentId.GetValue();
        set => _pictureAttachmentId.SetValue(value);
    }

    private PropertyValue<AvatarCropSquare?> _avatarCropSquare = new PropertyValue<AvatarCropSquare?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(AvatarCropSquare));
    
    [JsonPropertyName("avatarCropSquare")]
    public AvatarCropSquare? AvatarCropSquare
    {
        get => _avatarCropSquare.GetValue();
        set => _avatarCropSquare.SetValue(value);
    }

    private PropertyValue<List<CustomFieldInputValue>?> _customFieldValues = new PropertyValue<List<CustomFieldInputValue>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(CustomFieldValues));
    
    [JsonPropertyName("customFieldValues")]
    public List<CustomFieldInputValue>? CustomFieldValues
    {
        get => _customFieldValues.GetValue();
        set => _customFieldValues.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _username.SetAccessPath(path, validateHasBeenSet);
        _firstName.SetAccessPath(path, validateHasBeenSet);
        _lastName.SetAccessPath(path, validateHasBeenSet);
        _emails.SetAccessPath(path, validateHasBeenSet);
        _phones.SetAccessPath(path, validateHasBeenSet);
        _birthday.SetAccessPath(path, validateHasBeenSet);
        _about.SetAccessPath(path, validateHasBeenSet);
        _messengers.SetAccessPath(path, validateHasBeenSet);
        _links.SetAccessPath(path, validateHasBeenSet);
        _notAMember.SetAccessPath(path, validateHasBeenSet);
        _joined.SetAccessPath(path, validateHasBeenSet);
        _left.SetAccessPath(path, validateHasBeenSet);
        _leftAt.SetAccessPath(path, validateHasBeenSet);
        _speaksEnglish.SetAccessPath(path, validateHasBeenSet);
        _pictureAttachmentId.SetAccessPath(path, validateHasBeenSet);
        _avatarCropSquare.SetAccessPath(path, validateHasBeenSet);
        _customFieldValues.SetAccessPath(path, validateHasBeenSet);
    }

}

