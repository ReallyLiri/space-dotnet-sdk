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

namespace SpaceDotNet.Client.AddRevisionsToReviewRequestDtoExtensions
{
    public static class AddRevisionsToReviewRequestDtoPartialExtensions
    {
        public static Partial<AddRevisionsToReviewRequestDto> WithRevisions(this Partial<AddRevisionsToReviewRequestDto> it)    => it.AddFieldName("revisions");
        
        public static Partial<AddRevisionsToReviewRequestDto> WithRevisions(this Partial<AddRevisionsToReviewRequestDto> it, Func<Partial<RevisionInReviewDto>, Partial<RevisionInReviewDto>> partialBuilder)    => it.AddFieldName("revisions", partialBuilder(new Partial<RevisionInReviewDto>()));
        
    }
    
}
