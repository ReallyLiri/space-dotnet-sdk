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
    public partial class CustomFieldClient
    {
        private readonly Connection _connection;
        
        public CustomFieldClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ExtendedTypeClient ExtendedTypes => new ExtendedTypeClient(_connection);
        
        public partial class ExtendedTypeClient
        {
            private readonly Connection _connection;
            
            public ExtendedTypeClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all types that support custom fields.
            /// </summary>
            public async Task<List<ExtendedTypeDto>> GetAllExtendedTypesAsync(Func<Partial<ExtendedTypeDto>, Partial<ExtendedTypeDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<ExtendedTypeDto>>("GET", $"api/http/custom-fields/extended-types?$fields={(partial != null ? partial(new Partial<ExtendedTypeDto>()) : Partial<ExtendedTypeDto>.Default())}");
        
        }
    
        public AllValueClient AllValues => new AllValueClient(_connection);
        
        public partial class AllValueClient
        {
            private readonly Connection _connection;
            
            public AllValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public async Task<Batch<CustomFieldsRecordDto>> GetAllAllValuesAsync(string typeKey, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<Batch<CustomFieldsRecordDto>>, Partial<Batch<CustomFieldsRecordDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<CustomFieldsRecordDto>>("GET", $"api/http/custom-fields/{typeKey}/all-values?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&extendedEntityIds={extendedEntityIds?.JoinToString("extendedEntityIds", it => it.ToString()) ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<CustomFieldsRecordDto>>()) : Partial<Batch<CustomFieldsRecordDto>>.Default())}");
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public IAsyncEnumerable<CustomFieldsRecordDto> GetAllAllValuesAsyncEnumerable(string typeKey, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<CustomFieldsRecordDto>, Partial<CustomFieldsRecordDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllAllValuesAsync(typeKey: typeKey, top: top, extendedEntityIds: extendedEntityIds, skip: batchSkip, partial: builder => Partial<Batch<CustomFieldsRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<CustomFieldsRecordDto>.Default())), skip);
        
        }
    
        public FieldClient Fields => new FieldClient(_connection);
        
        public partial class FieldClient
        {
            private readonly Connection _connection;
            
            public FieldClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create custom field for a type.
            /// </summary>
            public async Task<CustomFieldDto> CreateFieldAsync(string typeKey, string name, string key, CFTypeDto type, bool required, bool @private, CFValueDto defaultValue, string? description = null, CFConstraintDto? constraint = null, AccessType? access = null, Func<Partial<CustomFieldDto>, Partial<CustomFieldDto>>? partial = null)
                => await _connection.RequestResourceAsync<CustomFieldsForTypeKeyFieldsRequest, CustomFieldDto>("POST", $"api/http/custom-fields/{typeKey}/fields?$fields={(partial != null ? partial(new Partial<CustomFieldDto>()) : Partial<CustomFieldDto>.Default())}", new CustomFieldsForTypeKeyFieldsRequest{ Name = name, Description = description, Key = key, Type = type, Constraint = constraint, Required = required, Private = @private, Access = access, DefaultValue = defaultValue });
        
            /// <summary>
            /// Re-order custom fields.
            /// </summary>
            public async Task ReorderAsync(string typeKey, List<string> customFieldOrder)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/reorder", new CustomFieldsForTypeKeyFieldsReorderRequest{ CustomFieldOrder = customFieldOrder });
        
            /// <summary>
            /// Archive a custom field for a type.
            /// </summary>
            public async Task ArchiveAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/archive");
        
            /// <summary>
            /// Restore custom field for a type.
            /// </summary>
            public async Task RestoreAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/restore");
        
            /// <summary>
            /// Get custom fields for a type.
            /// </summary>
            public async Task<List<CustomFieldDto>> GetAllFieldsAsync(string typeKey, bool withArchived = false, Func<Partial<CustomFieldDto>, Partial<CustomFieldDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<CustomFieldDto>>("GET", $"api/http/custom-fields/{typeKey}/fields?withArchived={withArchived.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<CustomFieldDto>()) : Partial<CustomFieldDto>.Default())}");
        
            /// <summary>
            /// Update custom field for a type. Optional parameters will be ignored when not specified, and updated otherwise.
            /// </summary>
            public async Task UpdateFieldAsync(string typeKey, string id, string? name = null, string? description = null, string? key = null, CFConstraintDto? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFValueDto? defaultValue = null, List<EnumValueDataDto>? enumValues = null)
                => await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/fields/{id}", new CustomFieldsForTypeKeyFieldsForIdRequest{ Name = name, Description = description, Key = key, Constraint = constraint, Required = required, Private = @private, Access = access, DefaultValue = defaultValue, EnumValues = enumValues });
        
            /// <summary>
            /// Remove custom field for a type.
            /// </summary>
            public async Task DeleteFieldAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/custom-fields/{typeKey}/fields/{id}");
        
        }
    
        public ValueClient Values => new ValueClient(_connection);
        
        public partial class ValueClient
        {
            private readonly Connection _connection;
            
            public ValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get custom field value for a type and entity id.
            /// </summary>
            public async Task<CustomFieldsRecordDto> GetValueAsync(string typeKey, string entityId, Func<Partial<CustomFieldsRecordDto>, Partial<CustomFieldsRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<CustomFieldsRecordDto>("GET", $"api/http/custom-fields/{typeKey}/{entityId}/values?$fields={(partial != null ? partial(new Partial<CustomFieldsRecordDto>()) : Partial<CustomFieldsRecordDto>.Default())}");
        
            /// <summary>
            /// Update custom field value(s) for a type and entity id.
            /// </summary>
            public async Task UpdateValueAsync(string entityId, string typeKey, List<CustomFieldValueDto> values)
                => await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/{entityId}/values", new CustomFieldsForTypeKeyForEntityIdValuesRequest{ Values = values });
        
        }
    
    }
    
}
