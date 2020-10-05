// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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
    public partial class HrmClient
    {
        private readonly Connection _connection;
        
        public HrmClient(Connection connection)
        {
            _connection = connection;
        }
        
        public BusinessEntityClient BusinessEntities => new BusinessEntityClient(_connection);
        
        public partial class BusinessEntityClient
        {
            private readonly Connection _connection;
            
            public BusinessEntityClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BusinessEntity> CreateANewBusinessEntityAsync(string name, string locationId, int? vacationAllowance = null, int? vacationApplicationDeadline = null, Func<Partial<BusinessEntity>, Partial<BusinessEntity>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<HrmBusinessEntitiesPostRequest, BusinessEntity>("POST", $"api/http/hrm/business-entities?$fields={(partial != null ? partial(new Partial<BusinessEntity>()) : Partial<BusinessEntity>.Default())}", 
                    new HrmBusinessEntitiesPostRequest { 
                        Name = name,
                        LocationId = locationId,
                        VacationAllowance = vacationAllowance,
                        VacationApplicationDeadline = vacationApplicationDeadline,
                    }
            , cancellationToken);
        
            public async Task<List<BusinessEntity>> ListExistingBusinessEntitiesAsync(Func<Partial<BusinessEntity>, Partial<BusinessEntity>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<BusinessEntity>>("GET", $"api/http/hrm/business-entities?$fields={(partial != null ? partial(new Partial<BusinessEntity>()) : Partial<BusinessEntity>.Default())}", cancellationToken);
        
            public async Task<BusinessEntity> GetExistingBusinessEntityByItsIdAsync(string id, Func<Partial<BusinessEntity>, Partial<BusinessEntity>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<BusinessEntity>("GET", $"api/http/hrm/business-entities/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntity>()) : Partial<BusinessEntity>.Default())}", cancellationToken);
        
            public async Task<BusinessEntity> UpdateExistingBusinessEntityAsync(string id, string name, string locationId, int? vacationAllowance = null, int? vacationApplicationDeadline = null, Func<Partial<BusinessEntity>, Partial<BusinessEntity>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<HrmBusinessEntitiesForIdPatchRequest, BusinessEntity>("PATCH", $"api/http/hrm/business-entities/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntity>()) : Partial<BusinessEntity>.Default())}", 
                    new HrmBusinessEntitiesForIdPatchRequest { 
                        Name = name,
                        LocationId = locationId,
                        VacationAllowance = vacationAllowance,
                        VacationApplicationDeadline = vacationApplicationDeadline,
                    }
            , cancellationToken);
        
            public async Task RemoveExistingBusinessEntityAsync(string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/hrm/business-entities/{id}", cancellationToken);
        
            public RelationClient Relations => new RelationClient(_connection);
            
            public partial class RelationClient
            {
                private readonly Connection _connection;
                
                public RelationClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<BusinessEntityRelation> CreateANewRelationBetweenMemberAndBusinessEntityAsync(ProfileIdentifier memberId, string entityId, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelation>, Partial<BusinessEntityRelation>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<HrmBusinessEntitiesRelationsForMemberIdPostRequest, BusinessEntityRelation>("POST", $"api/http/hrm/business-entities/relations/{memberId}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelation>()) : Partial<BusinessEntityRelation>.Default())}", 
                        new HrmBusinessEntitiesRelationsForMemberIdPostRequest { 
                            EntityId = entityId,
                            Since = since,
                            Till = till,
                        }
                , cancellationToken);
            
                public async Task<Batch<BusinessEntityRelation>> ListAllBusinessEntityRelationsAsync(List<ProfileIdentifier>? profile = null, List<string>? businessEntityId = null, string? skip = null, int? top = 100, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<Batch<BusinessEntityRelation>>, Partial<Batch<BusinessEntityRelation>>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<Batch<BusinessEntityRelation>>("GET", $"api/http/hrm/business-entities/relations?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&profile={(profile ?? new List<ProfileIdentifier>()).JoinToString("profile", it => it.ToString())}&businessEntityId={(businessEntityId ?? new List<string>()).JoinToString("businessEntityId", it => it.ToString())}&since={since?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<BusinessEntityRelation>>()) : Partial<Batch<BusinessEntityRelation>>.Default())}", cancellationToken);
                
                public IAsyncEnumerable<BusinessEntityRelation> ListAllBusinessEntityRelationsAsyncEnumerable(List<ProfileIdentifier>? profile = null, List<string>? businessEntityId = null, string? skip = null, int? top = 100, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelation>, Partial<BusinessEntityRelation>>? partial = null, CancellationToken cancellationToken = default)
                    => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => ListAllBusinessEntityRelationsAsync(profile: profile, businessEntityId: businessEntityId, top: top, since: since, till: till, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<BusinessEntityRelation>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<BusinessEntityRelation>.Default())), skip, cancellationToken);
            
                public async Task<List<BusinessEntityRelation>> ListMemberBusinessEntityRelationsAsync(ProfileIdentifier memberId, Func<Partial<BusinessEntityRelation>, Partial<BusinessEntityRelation>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<List<BusinessEntityRelation>>("GET", $"api/http/hrm/business-entities/relations/{memberId}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelation>()) : Partial<BusinessEntityRelation>.Default())}", cancellationToken);
            
                public async Task<BusinessEntityRelation> UpdateMemberBusinessEntityRelationAsync(string id, ProfileIdentifier memberId, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelation>, Partial<BusinessEntityRelation>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest, BusinessEntityRelation>("PATCH", $"api/http/hrm/business-entities/relations/{memberId}/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelation>()) : Partial<BusinessEntityRelation>.Default())}", 
                        new HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest { 
                            Since = since,
                            Till = till,
                        }
                , cancellationToken);
            
                public async Task DeleteMemberBusinessEntityRelationAsync(string id, ProfileIdentifier memberId, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/hrm/business-entities/relations/{memberId}/{id}", cancellationToken);
            
            }
        
        }
    
    }
    
}
