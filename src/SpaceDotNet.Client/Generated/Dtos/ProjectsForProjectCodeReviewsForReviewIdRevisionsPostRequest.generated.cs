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
    public class ProjectsForProjectCodeReviewsForReviewIdRevisionsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectCodeReviewsForReviewIdRevisionsPostRequest() { }
        
        public ProjectsForProjectCodeReviewsForReviewIdRevisionsPostRequest(List<RevisionInReview> revisions)
        {
            Revisions = revisions;
        }
        
        private PropertyValue<List<RevisionInReview>> _revisions = new PropertyValue<List<RevisionInReview>>(nameof(ProjectsForProjectCodeReviewsForReviewIdRevisionsPostRequest), nameof(Revisions));
        
        [Required]
        [JsonPropertyName("revisions")]
        public List<RevisionInReview> Revisions
        {
            get { return _revisions.GetValue(); }
            set { _revisions.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _revisions.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
