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
    public class PublicHolidaysHolidaysForIdRequest
         : IPropagatePropertyAccessPath
    {
        public PublicHolidaysHolidaysForIdRequest() { }
        
        public PublicHolidaysHolidaysForIdRequest(string? calendar = null, string? name = null, SpaceDate? date = null, bool? workingDay = null)
        {
            Calendar = calendar;
            Name = name;
            Date = date;
            WorkingDay = workingDay;
        }
        
        private PropertyValue<string?> _calendar = new PropertyValue<string?>(nameof(PublicHolidaysHolidaysForIdRequest), nameof(Calendar));
        
        [JsonPropertyName("calendar")]
        public string? Calendar
        {
            get { return _calendar.GetValue(); }
            set { _calendar.SetValue(value); }
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(PublicHolidaysHolidaysForIdRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _date = new PropertyValue<SpaceDate?>(nameof(PublicHolidaysHolidaysForIdRequest), nameof(Date));
        
        [JsonPropertyName("date")]
        public SpaceDate? Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<bool?> _workingDay = new PropertyValue<bool?>(nameof(PublicHolidaysHolidaysForIdRequest), nameof(WorkingDay));
        
        [JsonPropertyName("workingDay")]
        public bool? WorkingDay
        {
            get { return _workingDay.GetValue(); }
            set { _workingDay.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _calendar.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _date.SetAccessPath(path, validateHasBeenSet);
            _workingDay.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
