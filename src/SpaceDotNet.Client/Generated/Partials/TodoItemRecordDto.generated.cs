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

namespace SpaceDotNet.Client.TodoItemRecordDtoExtensions
{
    public static class TodoItemRecordDtoPartialExtensions
    {
        public static Partial<TodoItemRecordDto> WithId(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("id");
        
        public static Partial<TodoItemRecordDto> WithArchived(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("archived");
        
        public static Partial<TodoItemRecordDto> WithCreated(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("created");
        
        public static Partial<TodoItemRecordDto> WithUpdated(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("updated");
        
        public static Partial<TodoItemRecordDto> WithContent(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("content");
        
        public static Partial<TodoItemRecordDto> WithContent(this Partial<TodoItemRecordDto> it, Func<Partial<TodoItemContentDto>, Partial<TodoItemContentDto>> partialBuilder)    => it.AddFieldName("content", partialBuilder(new Partial<TodoItemContentDto>()));
        
        public static Partial<TodoItemRecordDto> WithStatus(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("_status");
        
        public static Partial<TodoItemRecordDto> WithDueDate(this Partial<TodoItemRecordDto> it)    => it.AddFieldName("dueDate");
        
    }
    
}
