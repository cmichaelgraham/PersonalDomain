using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Tools.TypescriptGenerator.Configuration;
using TypeLite;

namespace Tools.TypescriptGenerator.Generators
{
    public class DomainTypescriptGenerator : TypescriptGeneratorBase
    {
        protected override Func<Type, Boolean> ProjectedTypeSelector
        {
            get { return (type) => !type.IsAbstract && !type.IsInterface && !type.IsGenericType; }
        }

        public override void GenerateTypescript(Assembly source, Options options)
        {
            var typeScriptFluent = new TypeScriptFluent().WithConvertor<DateTime>(t => "string");

            foreach (var projectedType in source.GetTypes().Where(ProjectedTypeSelector))
            {
                typeScriptFluent.For(projectedType);
            }

            WriteOutput(Path.Combine(options.OutputPath, options.DomainDefinitionOutputFileName), typeScriptFluent.Generate(TsGeneratorOutput.Properties));
            WriteOutput(Path.Combine(options.OutputPath, options.DomainEnumsOutputFileName), typeScriptFluent.Generate(TsGeneratorOutput.Enums));
        }
    }
}
