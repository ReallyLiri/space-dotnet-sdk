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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public interface DocumentBody
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static ChecklistDocumentBody Checklist(Checklist checklist, bool canConvertItemsToIssues)
            => new ChecklistDocumentBody(checklist: checklist, canConvertItemsToIssues: canConvertItemsToIssues);
        
        public static InaccessibleDocumentBody Inaccessible(DocumentBodyType docBodyType, string docBodyId)
            => new InaccessibleDocumentBody(docBodyType: docBodyType, docBodyId: docBodyId);
        
        public static TextDocument TextDocument(string id, long resetCounter, DraftDocumentType type, string text, long? version = null, string? model = null, List<AttachmentInfo>? attachments = null)
            => new TextDocument(id: id, resetCounter: resetCounter, type: type, text: text, version: version, model: model, attachments: attachments);
        
    }
    
}
