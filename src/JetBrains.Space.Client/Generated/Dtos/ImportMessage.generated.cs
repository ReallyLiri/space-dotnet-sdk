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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class ImportMessage
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "ImportMessage";
    
    public static ImportMessageCreate Create(ChatMessageIdentifierExternalId messageId, ChatMessage message, PrincipalIn author, long createdAtUtc, long? editedAtUtc = null, List<AttachmentIn>? attachments = null)
        => new ImportMessageCreate(messageId: messageId, message: message, author: author, createdAtUtc: createdAtUtc, editedAtUtc: editedAtUtc, attachments: attachments);
    
    public static ImportMessageDelete Delete(ChatMessageIdentifierExternalId messageId)
        => new ImportMessageDelete(messageId: messageId);
    
    public static ImportMessageUpdate Update(ChatMessageIdentifierExternalId messageId, ChatMessage message, PrincipalIn author, long? editedAtUtc = null, List<AttachmentIn>? attachments = null)
        => new ImportMessageUpdate(messageId: messageId, message: message, author: author, editedAtUtc: editedAtUtc, attachments: attachments);
    
    public ImportMessage() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
