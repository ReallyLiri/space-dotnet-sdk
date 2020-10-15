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
    public sealed class Branch
         : IPropagatePropertyAccessPath
    {
        public Branch() { }
        
        public Branch(string branchName)
        {
            BranchName = branchName;
        }
        
        private PropertyValue<string> _branchName = new PropertyValue<string>(nameof(Branch), nameof(BranchName));
        
        [Required]
        [JsonPropertyName("branchName")]
        public string BranchName
        {
            get { return _branchName.GetValue(); }
            set { _branchName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _branchName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
