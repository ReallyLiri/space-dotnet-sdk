// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class ProjectsForProjectAutomationJobsForJobIdStartRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectAutomationJobsForJobIdStartRequest() { }
        
        public ProjectsForProjectAutomationJobsForJobIdStartRequest(string branch = "master")
        {
            Branch = branch;
        }
        
        private PropertyValue<string> _branch = new PropertyValue<string>(nameof(ProjectsForProjectAutomationJobsForJobIdStartRequest), nameof(Branch));
        
        [JsonPropertyName("branch")]
        public string Branch
        {
            get { return _branch.GetValue(); }
            set { _branch.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _branch.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
