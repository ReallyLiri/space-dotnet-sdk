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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public interface ApplicationPayload
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static ListCommandsPayload ListCommandsPayload(string? accessToken = null, string? verificationToken = null, string? userId = null)
            => new ListCommandsPayload(accessToken: accessToken, verificationToken: verificationToken, userId: userId);
        
        public static ListMenuExtensionsPayload ListMenuExtensionsPayload(string? accessToken = null, string? verificationToken = null, string? userId = null)
            => new ListMenuExtensionsPayload(accessToken: accessToken, verificationToken: verificationToken, userId: userId);
        
        public static MenuActionPayload MenuActionPayload(string extensionName, MenuActionContext context, string userId, string? accessToken = null, string? verificationToken = null)
            => new MenuActionPayload(extensionName: extensionName, context: context, userId: userId, accessToken: accessToken, verificationToken: verificationToken);
        
        public static MessageActionPayload MessageActionPayload(string actionId, string actionValue, MessageContext message, string userId, string? accessToken = null, string? verificationToken = null)
            => new MessageActionPayload(actionId: actionId, actionValue: actionValue, message: message, userId: userId, accessToken: accessToken, verificationToken: verificationToken);
        
        public static MessagePayload MessagePayload(MessageContext message, string userId, string? accessToken = null, string? verificationToken = null)
            => new MessagePayload(message: message, userId: userId, accessToken: accessToken, verificationToken: verificationToken);
        
    }
    
}