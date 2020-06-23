using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Common.Types;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelDtoGenerator
    {
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelDtoGenerator(CodeGenerationContext codeGenerationContext)
        {
            _codeGenerationContext = codeGenerationContext;
        }
        
        public string GenerateDtoDefinition(ApiDto apiDto)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var typeNameForDto = apiDto.ToCSharpClassName();
            
            if (apiDto.Deprecation != null)
            {
                builder.AppendLine(apiDto.Deprecation.ToCSharpDeprecation());
            }
                
            if (apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null && apiDto.Inheritors.Count > 0)
            {
                // When extending another DTO, make sure to apply a converter
                builder.AppendLine($"{indent}[JsonConverter(typeof(ClassNameDtoTypeConverter))]");
            }
        
            var modifierForDto = apiDto.HierarchyRole == HierarchyRole.INTERFACE
                ? "interface"
                : apiDto.HierarchyRole == HierarchyRole.ABSTRACT
                    ? "abstract class"
                    : apiDto.HierarchyRole == HierarchyRole.SEALED || apiDto.HierarchyRole == HierarchyRole.FINAL
                        ? "sealed class"
                        : "class";
        
            var dtoHierarchy = new List<string>();
            var dtoHierarchyFieldNames = new List<string>();
            if (apiDto.Extends != null && _codeGenerationContext.TryGetDto(apiDto.Extends.Id, out var apiDtoExtends))
            {
                dtoHierarchy.Add(apiDtoExtends!.ToCSharpClassName());
                dtoHierarchyFieldNames.AddRange(apiDtoExtends!.Fields.Select(it => it.Field.Name));
            }
            if (apiDto.Implements != null)
            {
                foreach (var dtoImplements in apiDto.Implements)
                {
                    if (_codeGenerationContext.TryGetDto(dtoImplements.Id, out var apiDtoImplements))
                    {
                        dtoHierarchy.Add(apiDtoImplements!.ToCSharpClassName());
                    }
                }
            }
            if (dtoHierarchy.Count > 0 || apiDto.Inheritors.Count > 0)
            {
                dtoHierarchy.Add(nameof(IClassNameConvertible));
            }
            
            dtoHierarchy.Add(nameof(IPropagatePropertyAccessPath));
            
            builder.AppendLine($"{indent}public {modifierForDto} {typeNameForDto}");
            indent.Increment();
            builder.AppendLine($"{indent} : " + string.Join(", ", dtoHierarchy));
            indent.Decrement();
            
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            // When in a hierarchy with IClassNameConvertible, make sure we can capture the class name.
            if (dtoHierarchy.Contains(nameof(IClassNameConvertible)) && apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null)
            {
                builder.AppendLine($"{indent}[JsonPropertyName(\"className\")]");
                builder.AppendLine($"{indent}public string? ClassName {{ get; set; }}"); // TODO C# 9 make this init only
                builder.AppendLine($"{indent}");
            }
                
            // For implements, add all referenced types' fields
            var apiDtoFields = new List<ApiDtoField>();
            if (apiDto.Implements != null)
            {
                foreach (var dtoReference in apiDto.Implements)
                {
                    if (_codeGenerationContext.TryGetDto(dtoReference.Id, out var apiDtoImplements))
                    {
                        apiDtoFields.AddRange(apiDtoImplements!.Fields);
                    }
                }
            }
        
            // Add own fields
            apiDtoFields.AddRange(apiDto.Fields);
            
            // Filter out:
            //  * properties to skip
            //  * properties that are already present in parent types
            apiDtoFields = apiDtoFields.Where(it =>
            {
                var propertyName = it.Field.ToCSharpPropertyName();
                return !_codeGenerationContext.PropertiesToSkip.Contains($"{typeNameForDto}.{propertyName}")
                       && !dtoHierarchyFieldNames.Contains(it.Field.Name);
            }).ToList();
            
            // Generate properties for fields
            foreach (var apiDtoField in apiDtoFields)
            {
                builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(typeNameForDto, apiDtoField.Field)));
            }
            
            // Implement IPropagatePropertyAccessPath?
            if (dtoHierarchy.Contains(nameof(IPropagatePropertyAccessPath)) && apiDto.HierarchyRole != HierarchyRole.INTERFACE)
            {
                builder.AppendLine(indent.Wrap(GenerateDtoPropagatePropertyAccessPath(apiDto, apiDtoFields)));
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        private string GenerateDtoFieldDefinition(string typeNameForDto, ApiField apiField)
        {
            var indent = new Indent();
            var builder = new StringBuilder();

            var propertyNameForField = apiField.ToCSharpPropertyName();
            var backingFieldNameForField = apiField.ToCSharpBackingFieldName();

            // Backing field
            builder.Append($"{indent}private PropertyValue<");
            builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
            if (apiField.Type.Nullable)
            {
                builder.Append("?");
            }

            builder.Append("> ");
            builder.Append($"{backingFieldNameForField} = new PropertyValue<");
            builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
            if (apiField.Type.Nullable)
            {
                builder.Append("?");
            }

            builder.AppendLine($">(nameof({typeNameForDto}), nameof({propertyNameForField}));");
            builder.AppendLine($"{indent}");

            // Property
            if (!apiField.Type.Optional && !apiField.Type.Nullable)
            {
                builder.AppendLine($"{indent}[Required]");
            }
            builder.AppendLine($"{indent}[JsonPropertyName(\"{apiField.Name}\")]");
            
            builder.Append($"{indent}public ");
            builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
            if (apiField.Type.Nullable)
            {
                builder.Append("?");
            }
            builder.Append(" ");
            builder.AppendLine($"{indent}{propertyNameForField}");
            
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            builder.AppendLine($"{indent}get {{ return {backingFieldNameForField}.GetValue(); }}");
            builder.AppendLine($"{indent}set {{ {backingFieldNameForField}.SetValue(value); }}");

            indent.Decrement();
            builder.AppendLine($"{indent}}}");

            return builder.ToString();
        }

        private string GenerateDtoPropagatePropertyAccessPath(ApiDto apiDto, List<ApiDtoField> apiDtoFields)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
                
            var modifier = apiDto.Extends != null
                ? "override" 
                : apiDto.HierarchyRole != HierarchyRole.SEALED && apiDto.HierarchyRole != HierarchyRole.FINAL
                    ? "virtual"
                    : string.Empty;
                
            builder.AppendLine($"{indent}public {modifier} void {nameof(IPropagatePropertyAccessPath.SetAccessPath)}(string path, bool validateHasBeenSet)");
            builder.AppendLine($"{indent}{{");
            indent.Increment();

            foreach (var apiDtoField in apiDtoFields)
            {
                var propertyName = apiDtoField.Field.ToCSharpPropertyName();
                var backingFieldNameForField = apiDtoField.Field.ToCSharpBackingFieldName();

                builder.AppendLine($"{indent}{backingFieldNameForField}.{nameof(IPropagatePropertyAccessPath.SetAccessPath)}(path + \"->With{propertyName}()\", validateHasBeenSet);");
            }

            indent.Decrement();
            builder.AppendLine($"{indent}}}");

            return builder.ToString();
        }
    }
}