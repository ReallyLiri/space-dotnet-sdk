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
    public sealed class MeetingRecordDto
         : IPropagatePropertyAccessPath
    {
        public MeetingRecordDto() { }
        
        public MeetingRecordDto(string id, bool archived, SpaceTime starts, SpaceTime finishes, bool allDay, List<TDLocationDto> rooms, List<ParticipantDto> participants, ATimeZoneDto? timezone = null, ArticleRecordDto? article = null)
        {
            Id = id;
            Archived = archived;
            Starts = starts;
            Finishes = finishes;
            Timezone = timezone;
            AllDay = allDay;
            Rooms = rooms;
            Participants = participants;
            Article = article;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(MeetingRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(MeetingRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _starts = new PropertyValue<SpaceTime>(nameof(MeetingRecordDto), nameof(Starts));
        
        [Required]
        [JsonPropertyName("starts")]
        public SpaceTime Starts
        {
            get { return _starts.GetValue(); }
            set { _starts.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _finishes = new PropertyValue<SpaceTime>(nameof(MeetingRecordDto), nameof(Finishes));
        
        [Required]
        [JsonPropertyName("finishes")]
        public SpaceTime Finishes
        {
            get { return _finishes.GetValue(); }
            set { _finishes.SetValue(value); }
        }
    
        private PropertyValue<ATimeZoneDto?> _timezone = new PropertyValue<ATimeZoneDto?>(nameof(MeetingRecordDto), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZoneDto? Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(MeetingRecordDto), nameof(AllDay));
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool AllDay
        {
            get { return _allDay.GetValue(); }
            set { _allDay.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationDto>> _rooms = new PropertyValue<List<TDLocationDto>>(nameof(MeetingRecordDto), nameof(Rooms));
        
        [Required]
        [JsonPropertyName("rooms")]
        public List<TDLocationDto> Rooms
        {
            get { return _rooms.GetValue(); }
            set { _rooms.SetValue(value); }
        }
    
        private PropertyValue<List<ParticipantDto>> _participants = new PropertyValue<List<ParticipantDto>>(nameof(MeetingRecordDto), nameof(Participants));
        
        [Required]
        [JsonPropertyName("participants")]
        public List<ParticipantDto> Participants
        {
            get { return _participants.GetValue(); }
            set { _participants.SetValue(value); }
        }
    
        private PropertyValue<ArticleRecordDto?> _article = new PropertyValue<ArticleRecordDto?>(nameof(MeetingRecordDto), nameof(Article));
        
        [JsonPropertyName("article")]
        public ArticleRecordDto? Article
        {
            get { return _article.GetValue(); }
            set { _article.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _starts.SetAccessPath(path, validateHasBeenSet);
            _finishes.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
            _rooms.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _article.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
