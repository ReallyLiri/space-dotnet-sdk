// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.5338677+00:00
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
    public partial class PublicHolidayClient
    {
        private readonly Connection _connection;
        
        public PublicHolidayClient(Connection connection)
        {
            _connection = connection;
        }
        
        public CalendarClient Calendars => new CalendarClient(_connection);
        
        public partial class CalendarClient
        {
            private readonly Connection _connection;
            
            public CalendarClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PublicHolidayCalendarRecordDto> CreateCalendar(CreateCalendarRequestDto data)
                => await _connection.RequestResourceAsync<CreateCalendarRequestDto, PublicHolidayCalendarRecordDto>("POST", $"api/http/public-holidays/calendars?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(PublicHolidayCalendarRecordDto)), data);            
            
            public async Task<string> Import(ImportRequestDto data)
                => await _connection.RequestResourceAsync<ImportRequestDto, string>("POST", $"api/http/public-holidays/calendars/import?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(string)), data);            
            
            public async Task<Batch<PublicHolidayCalendarRecordDto>> GetAllCalendars(string? skip = null, int? top = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayCalendarRecordDto>>("GET", $"api/http/public-holidays/calendars?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(Batch<PublicHolidayCalendarRecordDto>)));            
            
            public async Task<PublicHolidayCalendarRecordDto> UpdateCalendar(string id, CreateCalendarRequestDto data)
                => await _connection.RequestResourceAsync<CreateCalendarRequestDto, PublicHolidayCalendarRecordDto>("PATCH", $"api/http/public-holidays/calendars/{id}?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(PublicHolidayCalendarRecordDto)), data);            
            
            public async Task DeleteCalendar(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/calendars/{id}");            
            
        }
        
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PublicHolidayDto> CreateHoliday(CreateHolidayRequestDto data)
                => await _connection.RequestResourceAsync<CreateHolidayRequestDto, PublicHolidayDto>("POST", $"api/http/public-holidays/holidays?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(PublicHolidayDto)), data);            
            
            public async Task<Batch<PublicHolidayDto>> GetAllHolidays(string? skip = null, int? top = null, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&calendar={calendar?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(Batch<PublicHolidayDto>)));            
            
            public async Task<PublicHolidayDto> UpdateHoliday(string id, UpdateHolidayRequestDto data)
                => await _connection.RequestResourceAsync<UpdateHolidayRequestDto, PublicHolidayDto>("PATCH", $"api/http/public-holidays/holidays/{id}?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(PublicHolidayDto)), data);            
            
            public async Task DeleteHoliday(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/holidays/{id}");            
            
            public RelatedHolidayClient RelatedHolidays => new RelatedHolidayClient(_connection);
            
            public partial class RelatedHolidayClient
            {
                private readonly Connection _connection;
                
                public RelatedHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<Batch<PublicHolidayDto>> GetAllRelatedHolidays(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null)
                    => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays/related-holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(Batch<PublicHolidayDto>)));                
                
            }
            
        }
        
    }
    
}
