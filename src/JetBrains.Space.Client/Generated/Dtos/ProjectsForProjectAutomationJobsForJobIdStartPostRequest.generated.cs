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

public class ProjectsForProjectAutomationJobsForJobIdStartPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectAutomationJobsForJobIdStartPostRequest() { }
    
    public ProjectsForProjectAutomationJobsForJobIdStartPostRequest(Branch branch, List<JobParameter>? parameters = null, List<CheckoutRevisionDTO>? checkoutRevisions = null)
    {
        Branch = branch;
        Parameters = parameters;
        CheckoutRevisions = checkoutRevisions;
    }
    
    private PropertyValue<Branch> _branch = new PropertyValue<Branch>(nameof(ProjectsForProjectAutomationJobsForJobIdStartPostRequest), nameof(Branch), "branch");
    
    [Required]
    [JsonPropertyName("branch")]
    public Branch Branch
    {
        get => _branch.GetValue(InlineErrors);
        set => _branch.SetValue(value);
    }

    private PropertyValue<List<JobParameter>?> _parameters = new PropertyValue<List<JobParameter>?>(nameof(ProjectsForProjectAutomationJobsForJobIdStartPostRequest), nameof(Parameters), "parameters");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("parameters")]
    public List<JobParameter>? Parameters
    {
        get => _parameters.GetValue(InlineErrors);
        set => _parameters.SetValue(value);
    }

    private PropertyValue<List<CheckoutRevisionDTO>?> _checkoutRevisions = new PropertyValue<List<CheckoutRevisionDTO>?>(nameof(ProjectsForProjectAutomationJobsForJobIdStartPostRequest), nameof(CheckoutRevisions), "checkoutRevisions");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("checkoutRevisions")]
    public List<CheckoutRevisionDTO>? CheckoutRevisions
    {
        get => _checkoutRevisions.GetValue(InlineErrors);
        set => _checkoutRevisions.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _branch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parameters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checkoutRevisions.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

