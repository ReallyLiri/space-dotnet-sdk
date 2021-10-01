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

public sealed class BillingReportDay
     : IPropagatePropertyAccessPath
{
    public BillingReportDay() { }
    
    public BillingReportDay(DateTime date, int activeUsers, int userUsage, double userCost, long storageTotalUsage, long storageFilesUsage, long storageGitUsage, long storagePackagesUsage, double storageCost, long bandwidthTotalUsageDelta, long bandwidthTotalUsage, long bandwidthFilesUsageDelta, long bandwidthFilesUsage, long bandwidthGitUsageDelta, long bandwidthGitUsage, long bandwidthPackagesUsageDelta, long bandwidthPackagesUsage, long bandwidthAutomationExternalTrafficUsageDelta, long bandwidthAutomationExternalTrafficUsage, long bandwidthAutomationInternalUsageDelta, long bandwidthAutomationInternalUsage, double bandwidthCost, long ciUsageDelta, long ciUsage, double ciCost, long appUsage, long chatUsage, double totalCost, long? storageAllocationB = null)
    {
        Date = date;
        ActiveUsers = activeUsers;
        UserUsage = userUsage;
        UserCost = userCost;
        StorageAllocationB = storageAllocationB;
        StorageTotalUsage = storageTotalUsage;
        StorageFilesUsage = storageFilesUsage;
        StorageGitUsage = storageGitUsage;
        StoragePackagesUsage = storagePackagesUsage;
        StorageCost = storageCost;
        BandwidthTotalUsageDelta = bandwidthTotalUsageDelta;
        BandwidthTotalUsage = bandwidthTotalUsage;
        BandwidthFilesUsageDelta = bandwidthFilesUsageDelta;
        BandwidthFilesUsage = bandwidthFilesUsage;
        BandwidthGitUsageDelta = bandwidthGitUsageDelta;
        BandwidthGitUsage = bandwidthGitUsage;
        BandwidthPackagesUsageDelta = bandwidthPackagesUsageDelta;
        BandwidthPackagesUsage = bandwidthPackagesUsage;
        BandwidthAutomationExternalTrafficUsageDelta = bandwidthAutomationExternalTrafficUsageDelta;
        BandwidthAutomationExternalTrafficUsage = bandwidthAutomationExternalTrafficUsage;
        BandwidthAutomationInternalUsageDelta = bandwidthAutomationInternalUsageDelta;
        BandwidthAutomationInternalUsage = bandwidthAutomationInternalUsage;
        BandwidthCost = bandwidthCost;
        CiUsageDelta = ciUsageDelta;
        CiUsage = ciUsage;
        CiCost = ciCost;
        AppUsage = appUsage;
        ChatUsage = chatUsage;
        TotalCost = totalCost;
    }
    
    private PropertyValue<DateTime> _date = new PropertyValue<DateTime>(nameof(BillingReportDay), nameof(Date));
    
    [Required]
    [JsonPropertyName("date")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime Date
    {
        get => _date.GetValue();
        set => _date.SetValue(value);
    }

    private PropertyValue<int> _activeUsers = new PropertyValue<int>(nameof(BillingReportDay), nameof(ActiveUsers));
    
    [Required]
    [JsonPropertyName("activeUsers")]
    public int ActiveUsers
    {
        get => _activeUsers.GetValue();
        set => _activeUsers.SetValue(value);
    }

    private PropertyValue<int> _userUsage = new PropertyValue<int>(nameof(BillingReportDay), nameof(UserUsage));
    
    [Required]
    [JsonPropertyName("userUsage")]
    public int UserUsage
    {
        get => _userUsage.GetValue();
        set => _userUsage.SetValue(value);
    }

    private PropertyValue<double> _userCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(UserCost));
    
    [Required]
    [JsonPropertyName("userCost")]
    public double UserCost
    {
        get => _userCost.GetValue();
        set => _userCost.SetValue(value);
    }

    private PropertyValue<long?> _storageAllocationB = new PropertyValue<long?>(nameof(BillingReportDay), nameof(StorageAllocationB));
    
    [JsonPropertyName("storageAllocationB")]
    public long? StorageAllocationB
    {
        get => _storageAllocationB.GetValue();
        set => _storageAllocationB.SetValue(value);
    }

    private PropertyValue<long> _storageTotalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageTotalUsage));
    
    [Required]
    [JsonPropertyName("storageTotalUsage")]
    public long StorageTotalUsage
    {
        get => _storageTotalUsage.GetValue();
        set => _storageTotalUsage.SetValue(value);
    }

    private PropertyValue<long> _storageFilesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageFilesUsage));
    
    [Required]
    [JsonPropertyName("storageFilesUsage")]
    public long StorageFilesUsage
    {
        get => _storageFilesUsage.GetValue();
        set => _storageFilesUsage.SetValue(value);
    }

    private PropertyValue<long> _storageGitUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageGitUsage));
    
    [Required]
    [JsonPropertyName("storageGitUsage")]
    public long StorageGitUsage
    {
        get => _storageGitUsage.GetValue();
        set => _storageGitUsage.SetValue(value);
    }

    private PropertyValue<long> _storagePackagesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StoragePackagesUsage));
    
    [Required]
    [JsonPropertyName("storagePackagesUsage")]
    public long StoragePackagesUsage
    {
        get => _storagePackagesUsage.GetValue();
        set => _storagePackagesUsage.SetValue(value);
    }

    private PropertyValue<double> _storageCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(StorageCost));
    
    [Required]
    [JsonPropertyName("storageCost")]
    public double StorageCost
    {
        get => _storageCost.GetValue();
        set => _storageCost.SetValue(value);
    }

    private PropertyValue<long> _bandwidthTotalUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthTotalUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthTotalUsageDelta")]
    public long BandwidthTotalUsageDelta
    {
        get => _bandwidthTotalUsageDelta.GetValue();
        set => _bandwidthTotalUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthTotalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthTotalUsage));
    
    [Required]
    [JsonPropertyName("bandwidthTotalUsage")]
    public long BandwidthTotalUsage
    {
        get => _bandwidthTotalUsage.GetValue();
        set => _bandwidthTotalUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthFilesUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthFilesUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthFilesUsageDelta")]
    public long BandwidthFilesUsageDelta
    {
        get => _bandwidthFilesUsageDelta.GetValue();
        set => _bandwidthFilesUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthFilesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthFilesUsage));
    
    [Required]
    [JsonPropertyName("bandwidthFilesUsage")]
    public long BandwidthFilesUsage
    {
        get => _bandwidthFilesUsage.GetValue();
        set => _bandwidthFilesUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthGitUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthGitUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthGitUsageDelta")]
    public long BandwidthGitUsageDelta
    {
        get => _bandwidthGitUsageDelta.GetValue();
        set => _bandwidthGitUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthGitUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthGitUsage));
    
    [Required]
    [JsonPropertyName("bandwidthGitUsage")]
    public long BandwidthGitUsage
    {
        get => _bandwidthGitUsage.GetValue();
        set => _bandwidthGitUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthPackagesUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthPackagesUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthPackagesUsageDelta")]
    public long BandwidthPackagesUsageDelta
    {
        get => _bandwidthPackagesUsageDelta.GetValue();
        set => _bandwidthPackagesUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthPackagesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthPackagesUsage));
    
    [Required]
    [JsonPropertyName("bandwidthPackagesUsage")]
    public long BandwidthPackagesUsage
    {
        get => _bandwidthPackagesUsage.GetValue();
        set => _bandwidthPackagesUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationExternalTrafficUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationExternalTrafficUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthAutomationExternalTrafficUsageDelta")]
    public long BandwidthAutomationExternalTrafficUsageDelta
    {
        get => _bandwidthAutomationExternalTrafficUsageDelta.GetValue();
        set => _bandwidthAutomationExternalTrafficUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationExternalTrafficUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationExternalTrafficUsage));
    
    [Required]
    [JsonPropertyName("bandwidthAutomationExternalTrafficUsage")]
    public long BandwidthAutomationExternalTrafficUsage
    {
        get => _bandwidthAutomationExternalTrafficUsage.GetValue();
        set => _bandwidthAutomationExternalTrafficUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationInternalUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationInternalUsageDelta));
    
    [Required]
    [JsonPropertyName("bandwidthAutomationInternalUsageDelta")]
    public long BandwidthAutomationInternalUsageDelta
    {
        get => _bandwidthAutomationInternalUsageDelta.GetValue();
        set => _bandwidthAutomationInternalUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationInternalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationInternalUsage));
    
    [Required]
    [JsonPropertyName("bandwidthAutomationInternalUsage")]
    public long BandwidthAutomationInternalUsage
    {
        get => _bandwidthAutomationInternalUsage.GetValue();
        set => _bandwidthAutomationInternalUsage.SetValue(value);
    }

    private PropertyValue<double> _bandwidthCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(BandwidthCost));
    
    [Required]
    [JsonPropertyName("bandwidthCost")]
    public double BandwidthCost
    {
        get => _bandwidthCost.GetValue();
        set => _bandwidthCost.SetValue(value);
    }

    private PropertyValue<long> _ciUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(CiUsageDelta));
    
    [Required]
    [JsonPropertyName("ciUsageDelta")]
    public long CiUsageDelta
    {
        get => _ciUsageDelta.GetValue();
        set => _ciUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _ciUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(CiUsage));
    
    [Required]
    [JsonPropertyName("ciUsage")]
    public long CiUsage
    {
        get => _ciUsage.GetValue();
        set => _ciUsage.SetValue(value);
    }

    private PropertyValue<double> _ciCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(CiCost));
    
    [Required]
    [JsonPropertyName("ciCost")]
    public double CiCost
    {
        get => _ciCost.GetValue();
        set => _ciCost.SetValue(value);
    }

    private PropertyValue<long> _appUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(AppUsage));
    
    [Required]
    [JsonPropertyName("appUsage")]
    public long AppUsage
    {
        get => _appUsage.GetValue();
        set => _appUsage.SetValue(value);
    }

    private PropertyValue<long> _chatUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(ChatUsage));
    
    [Required]
    [JsonPropertyName("chatUsage")]
    public long ChatUsage
    {
        get => _chatUsage.GetValue();
        set => _chatUsage.SetValue(value);
    }

    private PropertyValue<double> _totalCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(TotalCost));
    
    [Required]
    [JsonPropertyName("totalCost")]
    public double TotalCost
    {
        get => _totalCost.GetValue();
        set => _totalCost.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _date.SetAccessPath(path, validateHasBeenSet);
        _activeUsers.SetAccessPath(path, validateHasBeenSet);
        _userUsage.SetAccessPath(path, validateHasBeenSet);
        _userCost.SetAccessPath(path, validateHasBeenSet);
        _storageAllocationB.SetAccessPath(path, validateHasBeenSet);
        _storageTotalUsage.SetAccessPath(path, validateHasBeenSet);
        _storageFilesUsage.SetAccessPath(path, validateHasBeenSet);
        _storageGitUsage.SetAccessPath(path, validateHasBeenSet);
        _storagePackagesUsage.SetAccessPath(path, validateHasBeenSet);
        _storageCost.SetAccessPath(path, validateHasBeenSet);
        _bandwidthTotalUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthTotalUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthFilesUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthFilesUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthGitUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthGitUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthPackagesUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthPackagesUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthAutomationExternalTrafficUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthAutomationExternalTrafficUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthAutomationInternalUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _bandwidthAutomationInternalUsage.SetAccessPath(path, validateHasBeenSet);
        _bandwidthCost.SetAccessPath(path, validateHasBeenSet);
        _ciUsageDelta.SetAccessPath(path, validateHasBeenSet);
        _ciUsage.SetAccessPath(path, validateHasBeenSet);
        _ciCost.SetAccessPath(path, validateHasBeenSet);
        _appUsage.SetAccessPath(path, validateHasBeenSet);
        _chatUsage.SetAccessPath(path, validateHasBeenSet);
        _totalCost.SetAccessPath(path, validateHasBeenSet);
    }

}

