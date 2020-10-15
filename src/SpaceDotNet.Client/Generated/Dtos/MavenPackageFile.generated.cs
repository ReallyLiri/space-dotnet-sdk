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

namespace SpaceDotNet.Client
{
    public sealed class MavenPackageFile
         : IPropagatePropertyAccessPath
    {
        public MavenPackageFile() { }
        
        public MavenPackageFile(string name, long created, long length, List<MavenChecksum> checksums)
        {
            Name = name;
            Created = created;
            Length = length;
            Checksums = checksums;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(MavenPackageFile), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<long> _created = new PropertyValue<long>(nameof(MavenPackageFile), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public long Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<long> _length = new PropertyValue<long>(nameof(MavenPackageFile), nameof(Length));
        
        [Required]
        [JsonPropertyName("length")]
        public long Length
        {
            get { return _length.GetValue(); }
            set { _length.SetValue(value); }
        }
    
        private PropertyValue<List<MavenChecksum>> _checksums = new PropertyValue<List<MavenChecksum>>(nameof(MavenPackageFile), nameof(Checksums));
        
        [Required]
        [JsonPropertyName("checksums")]
        public List<MavenChecksum> Checksums
        {
            get { return _checksums.GetValue(); }
            set { _checksums.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _length.SetAccessPath(path, validateHasBeenSet);
            _checksums.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
