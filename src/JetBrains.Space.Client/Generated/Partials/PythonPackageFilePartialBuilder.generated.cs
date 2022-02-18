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

namespace JetBrains.Space.Client.PythonPackageFilePartialBuilder;

public static class PythonPackageFilePartialExtensions
{
    public static Partial<PythonPackageFile> WithName(this Partial<PythonPackageFile> it)
        => it.AddFieldName("name");
    
    public static Partial<PythonPackageFile> WithCreated(this Partial<PythonPackageFile> it)
        => it.AddFieldName("created");
    
    public static Partial<PythonPackageFile> WithLength(this Partial<PythonPackageFile> it)
        => it.AddFieldName("length");
    
    public static Partial<PythonPackageFile> WithChecksums(this Partial<PythonPackageFile> it)
        => it.AddFieldName("checksums");
    
    public static Partial<PythonPackageFile> WithChecksums(this Partial<PythonPackageFile> it, Func<Partial<PythonChecksum>, Partial<PythonChecksum>> partialBuilder)
        => it.AddFieldName("checksums", partialBuilder(new Partial<PythonChecksum>(it)));
    
}
