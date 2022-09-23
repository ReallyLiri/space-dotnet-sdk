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

public sealed class UnfurlDetailsCodeReview
     : InlineUnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsCodeReview";
    
    public UnfurlDetailsCodeReview() { }
    
    public UnfurlDetailsCodeReview(CodeReviewRecord review, bool withBranchPair, bool? withIcon = null, string? defaultBranchInRepo = null, bool? hideIfCannotResolve = null, CodeReviewState? reviewState = null, bool? isMerged = null)
    {
        Review = review;
        IsWithIcon = withIcon;
        IsWithBranchPair = withBranchPair;
        DefaultBranchInRepo = defaultBranchInRepo;
        IsHideIfCannotResolve = hideIfCannotResolve;
        ReviewState = reviewState;
        IsMerged = isMerged;
    }
    
    private PropertyValue<CodeReviewRecord> _review = new PropertyValue<CodeReviewRecord>(nameof(UnfurlDetailsCodeReview), nameof(Review), "review");
    
    [Required]
    [JsonPropertyName("review")]
    public CodeReviewRecord Review
    {
        get => _review.GetValue(InlineErrors);
        set => _review.SetValue(value);
    }

    private PropertyValue<bool?> _withIcon = new PropertyValue<bool?>(nameof(UnfurlDetailsCodeReview), nameof(IsWithIcon), "withIcon");
    
    [JsonPropertyName("withIcon")]
    public bool? IsWithIcon
    {
        get => _withIcon.GetValue(InlineErrors);
        set => _withIcon.SetValue(value);
    }

    private PropertyValue<bool> _withBranchPair = new PropertyValue<bool>(nameof(UnfurlDetailsCodeReview), nameof(IsWithBranchPair), "withBranchPair");
    
    [Required]
    [JsonPropertyName("withBranchPair")]
    public bool IsWithBranchPair
    {
        get => _withBranchPair.GetValue(InlineErrors);
        set => _withBranchPair.SetValue(value);
    }

    private PropertyValue<string?> _defaultBranchInRepo = new PropertyValue<string?>(nameof(UnfurlDetailsCodeReview), nameof(DefaultBranchInRepo), "defaultBranchInRepo");
    
    [JsonPropertyName("defaultBranchInRepo")]
    public string? DefaultBranchInRepo
    {
        get => _defaultBranchInRepo.GetValue(InlineErrors);
        set => _defaultBranchInRepo.SetValue(value);
    }

    private PropertyValue<bool?> _hideIfCannotResolve = new PropertyValue<bool?>(nameof(UnfurlDetailsCodeReview), nameof(IsHideIfCannotResolve), "hideIfCannotResolve");
    
    [JsonPropertyName("hideIfCannotResolve")]
    public bool? IsHideIfCannotResolve
    {
        get => _hideIfCannotResolve.GetValue(InlineErrors);
        set => _hideIfCannotResolve.SetValue(value);
    }

    private PropertyValue<CodeReviewState?> _reviewState = new PropertyValue<CodeReviewState?>(nameof(UnfurlDetailsCodeReview), nameof(ReviewState), "reviewState");
    
    [JsonPropertyName("reviewState")]
    public CodeReviewState? ReviewState
    {
        get => _reviewState.GetValue(InlineErrors);
        set => _reviewState.SetValue(value);
    }

    private PropertyValue<bool?> _isMerged = new PropertyValue<bool?>(nameof(UnfurlDetailsCodeReview), nameof(IsMerged), "isMerged");
    
    [JsonPropertyName("isMerged")]
    public bool? IsMerged
    {
        get => _isMerged.GetValue(InlineErrors);
        set => _isMerged.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _review.SetAccessPath(parentChainPath, validateHasBeenSet);
        _withIcon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _withBranchPair.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultBranchInRepo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hideIfCannotResolve.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewState.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isMerged.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

