using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    [JsonConverter(typeof(ApiUrlParameterOptionConverter))]
    public abstract class ApiUrlParameterOption
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [JsonPropertyName("optionName")]
        public string OptionName { get; set; } = default!;
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; } = default;
        
        public class Var : ApiUrlParameterOption
        {
            [JsonPropertyName("parameter")]
            public ApiField Parameter { get; set; } = default!;
            
            [JsonPropertyName("prefixRequired")]
            public bool PrefixRequired { get; set; } = default!;
        }
        
        public class Const : ApiUrlParameterOption
        {
            [JsonPropertyName("value")]
            public string Value { get; set; } = default!;
        }
    }
}