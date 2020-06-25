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
    public sealed class UnfurlDetailsMeetingDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsMeeting";
        
        public UnfurlDetailsMeetingDto() { }
        
        public UnfurlDetailsMeetingDto(DTOMeetingDto meeting)
        {
            Meeting = meeting;
        }
        
        private PropertyValue<DTOMeetingDto> _meeting = new PropertyValue<DTOMeetingDto>(nameof(UnfurlDetailsMeetingDto), nameof(Meeting));
        
        [Required]
        [JsonPropertyName("meeting")]
        public DTOMeetingDto Meeting
        {
            get { return _meeting.GetValue(); }
            set { _meeting.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meeting.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
