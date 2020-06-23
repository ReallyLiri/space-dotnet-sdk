using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SpaceDotNet.Common.Types;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelGenerator
    {
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelGenerator(CodeGenerationContext codeGenerationContext)
        {
            _codeGenerationContext = codeGenerationContext;
        }
        
        public void GenerateFiles(IDocumentWriter documentWriter)
        {
            // API clients/endpoints
            var resourcesGenerator = new CSharpApiModelResourceGenerator(_codeGenerationContext);
            foreach (var apiResource in _codeGenerationContext.GetResources())
            {
                WriteToDocument(documentWriter, 
                    apiResource.ToCSharpIdentifierSingular() + "Client.generated.cs",
                    resourcesGenerator.GenerateResourceDefinition(apiResource));
            }
            
            // URL parameters
            var urlParametersGenerator = new CSharpApiModelUrlParameterGenerator(_codeGenerationContext);
            foreach (var apiUrlParameter in _codeGenerationContext.GetUrlParameters())
            {
                WriteToDocument(documentWriter, 
                    "UrlParams/" + apiUrlParameter.ToCSharpClassName() + ".generated.cs",
                    urlParametersGenerator.GenerateUrlParameterDefinition(apiUrlParameter));
            }
            
            // Enums
            var enumGenerator = new CSharpApiModelEnumGenerator();
            foreach (var apiEnum in _codeGenerationContext.GetEnums())
            {
                WriteToDocument(documentWriter, 
                    "Enums/" + apiEnum.ToCSharpClassName() + ".generated.cs",
                    enumGenerator.GenerateEnumDefinition(apiEnum));
            }
            
            // Dtos
            var dtoGenerator = new CSharpApiModelDtoGenerator(_codeGenerationContext);
            foreach (var apiDto in _codeGenerationContext.GetDtos())
            {
                WriteToDocument(documentWriter, 
                    "Dtos/" + apiDto.ToCSharpClassName() + ".generated.cs",
                    dtoGenerator.GenerateDtoDefinition(apiDto));
            }
            
            // Partial extensions
            var partialExtensionsGenerator = new CSharpPartialExtensionsGenerator(_codeGenerationContext);
            foreach (var apiDto in _codeGenerationContext.GetDtos())
            {
                WriteToDocument(documentWriter, 
                    "Partials/" + apiDto.ToCSharpClassName() + ".generated.cs",
                    partialExtensionsGenerator.GeneratePartialClassFor(apiDto),
                    apiDto.ToCSharpClassName() + "Extensions");
            }
        }

        private static void WriteToDocument(
            IDocumentWriter documentWriter, 
            string relativePath, 
            string contents, 
            string? namespaceSuffix = null)
        {
            var document = new CSharpDocument(namespaceSuffix);
            document.AppendLine(contents);
            documentWriter.WriteDocument(
                relativePath,
                document.ToString());
        }
    }
}