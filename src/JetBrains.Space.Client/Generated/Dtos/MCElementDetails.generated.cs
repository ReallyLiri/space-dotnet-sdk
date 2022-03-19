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

public interface MCElementDetails
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static MCButton MCButton(string text, MCAction action, MessageButtonStyle? style = null, bool? disabled = null)
        => new MCButton(text: text, action: action, style: style, disabled: disabled);
    
    public static MCDivider MCDivider()
        => new MCDivider();
    
    public static MCFields MCFields(List<Pair<MCElement, MCElement>> fields)
        => new MCFields(fields: fields);
    
    public static MCGroup MCGroup(List<MCElement> elements)
        => new MCGroup(elements: elements);
    
    public static MCIcon MCIcon(string name, MessageStyle? style = null)
        => new MCIcon(name: name, style: style);
    
    public static MCImage MCImage(string src)
        => new MCImage(src: src);
    
    public static MCInlineGroup MCInlineGroup(List<MCInlineElement> elements, MCElement? accessory = null, MessageTextSize? textSize = null)
        => new MCInlineGroup(elements: elements, accessory: accessory, textSize: textSize);
    
    public static MCSection MCSection(List<MCElement> elements, MessageStyle? style = null, MCText? header = null, MCText? footer = null)
        => new MCSection(elements: elements, style: style, header: header, footer: footer);
    
    public static MCTag MCTag(string text, MessageStyle? style = null)
        => new MCTag(text: text, style: style);
    
    public static MCText MCText(string content, bool markdown, MCElement? accessory = null, MessageStyle? style = null, MessageTextSize? size = null)
        => new MCText(content: content, markdown: markdown, accessory: accessory, style: style, size: size);
    
}

