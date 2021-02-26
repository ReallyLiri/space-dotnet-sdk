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
    public partial class CustomFieldClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public CustomFieldClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ExtendedTypeClient ExtendedTypes => new ExtendedTypeClient(_connection);
        
        public partial class ExtendedTypeClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ExtendedTypeClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all types that support custom fields.
            /// </summary>
            public async Task<List<ExtendedType>> GetAllExtendedTypesAsync(ExtendedTypeScopeType scope = ExtendedTypeScopeType.Org, Func<Partial<ExtendedType>, Partial<ExtendedType>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("scope", scope.ToEnumString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<ExtendedType>()) : Partial<ExtendedType>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<ExtendedType>>("GET", $"api/http/custom-fields/extended-types{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public AllValueClient AllValues => new AllValueClient(_connection);
        
        public partial class AllValueClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AllValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public async Task<Batch<CustomFieldsRecord>> GetAllValuesAsync(string typeKey, ExtendedTypeScope scope, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<Batch<CustomFieldsRecord>>, Partial<Batch<CustomFieldsRecord>>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                if (skip != null) queryParameters.Append("$skip", skip);
                if (top != null) queryParameters.Append("$top", top?.ToString());
                if (extendedEntityIds != null) queryParameters.Append("extendedEntityIds", extendedEntityIds.Select(it => it));
                queryParameters.Append("scope", scope.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<CustomFieldsRecord>>()) : Partial<Batch<CustomFieldsRecord>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Batch<CustomFieldsRecord>>("GET", $"api/http/custom-fields/{typeKey}/all-values{queryParameters.ToQueryString()}", cancellationToken);
            }
            
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public IAsyncEnumerable<CustomFieldsRecord> GetAllValuesAsyncEnumerable(string typeKey, ExtendedTypeScope scope, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<CustomFieldsRecord>, Partial<CustomFieldsRecord>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllValuesAsync(typeKey: typeKey, scope: scope, top: top, extendedEntityIds: extendedEntityIds, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<CustomFieldsRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<CustomFieldsRecord>.Default())), skip, cancellationToken);
        
        }
    
        public EnumValueClient EnumValues => new EnumValueClient(_connection);
        
        public partial class EnumValueClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EnumValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Add new option to custom field of `Select from options` type. Options can only be added via this API call if custom field has the `New options can be added on the fly` flag set. Returns saved records.
            /// </summary>
            public async Task<List<EnumValueData>> CreateEnumValueAsync(string typeKey, string customFieldId, List<EnumValueData> valuesToAdd, ExtendedTypeScope scope, Func<Partial<EnumValueData>, Partial<EnumValueData>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<EnumValueData>()) : Partial<EnumValueData>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest, List<EnumValueData>>("POST", $"api/http/custom-fields/{typeKey}/enum-values/{customFieldId}{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest
                    { 
                        ValuesToAdd = valuesToAdd,
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Get a page of options for custom field of `Select from options` type with `New options can be added on the fly` flag set.
            /// </summary>
            public async Task<Batch<EnumValueData>> GetAllEnumValuesAsync(string typeKey, string customFieldId, ExtendedTypeScope scope, EnumValueOrdering ordering = EnumValueOrdering.NAMEASC, string? skip = null, int? top = 100, string? query = null, bool? countRecords = null, string? addedByProfileId = null, Func<Partial<Batch<EnumValueData>>, Partial<Batch<EnumValueData>>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                if (skip != null) queryParameters.Append("$skip", skip);
                if (top != null) queryParameters.Append("$top", top?.ToString());
                if (query != null) queryParameters.Append("query", query);
                queryParameters.Append("ordering", ordering.ToEnumString());
                if (countRecords != null) queryParameters.Append("countRecords", countRecords?.ToString("l"));
                if (addedByProfileId != null) queryParameters.Append("addedByProfileId", addedByProfileId);
                queryParameters.Append("scope", scope.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<EnumValueData>>()) : Partial<Batch<EnumValueData>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Batch<EnumValueData>>("GET", $"api/http/custom-fields/{typeKey}/enum-values/{customFieldId}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
            
            /// <summary>
            /// Get a page of options for custom field of `Select from options` type with `New options can be added on the fly` flag set.
            /// </summary>
            public IAsyncEnumerable<EnumValueData> GetAllEnumValuesAsyncEnumerable(string typeKey, string customFieldId, ExtendedTypeScope scope, EnumValueOrdering ordering = EnumValueOrdering.NAMEASC, string? skip = null, int? top = 100, string? query = null, bool? countRecords = null, string? addedByProfileId = null, Func<Partial<EnumValueData>, Partial<EnumValueData>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllEnumValuesAsync(typeKey: typeKey, customFieldId: customFieldId, ordering: ordering, scope: scope, top: top, query: query, countRecords: countRecords, addedByProfileId: addedByProfileId, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<EnumValueData>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EnumValueData>.Default())), skip, cancellationToken);
        
        }
    
        public FieldClient Fields => new FieldClient(_connection);
        
        public partial class FieldClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public FieldClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create custom field for a type.
            /// </summary>
            public async Task<CustomField> CreateFieldAsync(string typeKey, string name, CFType type, bool required, bool @private, CFInputValue defaultValue, ExtendedTypeScope scope, string? description = null, CFConstraint? constraint = null, AccessType? access = null, CFEnumValuesModification? openEnumValuesModification = null, Func<Partial<CustomField>, Partial<CustomField>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<CustomField>()) : Partial<CustomField>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CustomFieldsForTypeKeyFieldsPostRequest, CustomField>("POST", $"api/http/custom-fields/{typeKey}/fields{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyFieldsPostRequest
                    { 
                        Name = name,
                        Description = description,
                        Type = type,
                        Constraint = constraint,
                        IsRequired = required,
                        IsPrivate = @private,
                        Access = access,
                        DefaultValue = defaultValue,
                        OpenEnumValuesModification = openEnumValuesModification,
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Re-order custom fields. Pass IDs of the custom fields in the order you wish the custom fields to be.
            /// </summary>
            public async Task ReorderAsync(string typeKey, List<string> customFieldOrder, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/reorder{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyFieldsReorderPostRequest
                    { 
                        CustomFieldOrder = customFieldOrder,
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Archive a custom field for a type.
            /// </summary>
            public async Task ArchiveAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/archive{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyFieldsForIdArchivePostRequest
                    { 
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Restore custom field for a type.
            /// </summary>
            public async Task RestoreAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/restore{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyFieldsForIdRestorePostRequest
                    { 
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Get custom fields for a type.
            /// </summary>
            public async Task<List<CustomField>> GetAllFieldsAsync(string typeKey, ExtendedTypeScope scope, bool withArchived = false, Func<Partial<CustomField>, Partial<CustomField>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("withArchived", withArchived.ToString("l"));
                queryParameters.Append("scope", scope.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<CustomField>()) : Partial<CustomField>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<CustomField>>("GET", $"api/http/custom-fields/{typeKey}/fields{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Update custom field for a type. Optional parameters will be ignored when not specified, and updated otherwise.
            /// </summary>
            public async Task UpdateFieldAsync(string typeKey, string id, ExtendedTypeScope scope, string? name = null, string? description = null, CFConstraint? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFInputValue? defaultValue = null, List<EnumValueData>? enumValues = null, CFEnumValuesModification? openEnumValuesModification = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/fields/{id}{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyFieldsForIdPatchRequest
                    { 
                        Name = name,
                        Description = description,
                        Constraint = constraint,
                        IsRequired = required,
                        IsPrivate = @private,
                        Access = access,
                        DefaultValue = defaultValue,
                        EnumValues = enumValues,
                        OpenEnumValuesModification = openEnumValuesModification,
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Remove custom field for a type.
            /// </summary>
            public async Task DeleteFieldAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("scope", scope.ToString());
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/custom-fields/{typeKey}/fields/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public ValueClient Values => new ValueClient(_connection);
        
        public partial class ValueClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get custom field value for a type and entity id.
            /// </summary>
            public async Task<CustomFieldsRecord> GetValueAsync(string typeKey, string entityId, ExtendedTypeScope scope, Func<Partial<CustomFieldsRecord>, Partial<CustomFieldsRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("scope", scope.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<CustomFieldsRecord>()) : Partial<CustomFieldsRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CustomFieldsRecord>("GET", $"api/http/custom-fields/{typeKey}/{entityId}/values{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Update custom field value(s) for a type and entity id.
            /// </summary>
            public async Task UpdateValueAsync(string entityId, string typeKey, List<CustomFieldInputValue> values, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/{entityId}/values{queryParameters.ToQueryString()}", 
                    new CustomFieldsForTypeKeyForEntityIdValuesPatchRequest
                    { 
                        Values = values,
                        Scope = scope,
                    }, cancellationToken);
            }
            
        
        }
    
    }
    
}
