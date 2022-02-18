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

public sealed class PythonPackageFile
     : IPropagatePropertyAccessPath
{
    public PythonPackageFile() { }
    
    public PythonPackageFile(string name, long created, long length, List<PythonChecksum> checksums)
    {
        Name = name;
        Created = created;
        Length = length;
        Checksums = checksums;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PythonPackageFile), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<long> _created = new PropertyValue<long>(nameof(PythonPackageFile), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    public long Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long> _length = new PropertyValue<long>(nameof(PythonPackageFile), nameof(Length), "length");
    
    [Required]
    [JsonPropertyName("length")]
    public long Length
    {
        get => _length.GetValue(InlineErrors);
        set => _length.SetValue(value);
    }

    private PropertyValue<List<PythonChecksum>> _checksums = new PropertyValue<List<PythonChecksum>>(nameof(PythonPackageFile), nameof(Checksums), "checksums", new List<PythonChecksum>());
    
    [Required]
    [JsonPropertyName("checksums")]
    public List<PythonChecksum> Checksums
    {
        get => _checksums.GetValue(InlineErrors);
        set => _checksums.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _length.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checksums.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
