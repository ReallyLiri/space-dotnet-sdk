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

public sealed class ProjectMenuActionContext
     : MenuActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ProjectMenuActionContext";
    
    public ProjectMenuActionContext() { }
    
    public ProjectMenuActionContext(string menuId, PRProject project)
    {
        MenuId = menuId;
        Project = project;
    }
    
    private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(ProjectMenuActionContext), nameof(MenuId));
    
    [Required]
    [JsonPropertyName("menuId")]
    public string MenuId
    {
        get => _menuId.GetValue();
        set => _menuId.SetValue(value);
    }

    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(ProjectMenuActionContext), nameof(Project));
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _menuId.SetAccessPath(path, validateHasBeenSet);
        _project.SetAccessPath(path, validateHasBeenSet);
    }

}

