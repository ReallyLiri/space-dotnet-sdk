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

public sealed class FileDocumentBodyUpload
     : FileDocumentBody, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "FileDocumentBody.Upload";
    
    public FileDocumentBodyUpload() { }
    
    public FileDocumentBodyUpload(string versionId, bool uploading, string? mediaType = null)
    {
        VersionId = versionId;
        MediaType = mediaType;
        IsUploading = uploading;
    }
    
    private PropertyValue<string> _versionId = new PropertyValue<string>(nameof(FileDocumentBodyUpload), nameof(VersionId));
    
    [Required]
    [JsonPropertyName("versionId")]
    public string VersionId
    {
        get => _versionId.GetValue();
        set => _versionId.SetValue(value);
    }

    private PropertyValue<string?> _mediaType = new PropertyValue<string?>(nameof(FileDocumentBodyUpload), nameof(MediaType));
    
    [JsonPropertyName("mediaType")]
    public string? MediaType
    {
        get => _mediaType.GetValue();
        set => _mediaType.SetValue(value);
    }

    private PropertyValue<bool> _uploading = new PropertyValue<bool>(nameof(FileDocumentBodyUpload), nameof(IsUploading));
    
    [Required]
    [JsonPropertyName("uploading")]
    public bool IsUploading
    {
        get => _uploading.GetValue();
        set => _uploading.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _versionId.SetAccessPath(path, validateHasBeenSet);
        _mediaType.SetAccessPath(path, validateHasBeenSet);
        _uploading.SetAccessPath(path, validateHasBeenSet);
    }

}

