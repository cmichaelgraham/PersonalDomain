using System;
using CommandLine;

namespace Tools.TypescriptGenerator.Configuration
{
    public class Options
    {
        [Option("domain-enums", Required = false, DefaultValue = "domain-enums.ts", HelpText = "Domain Enumerations Typescript File Name")]
        public String DomainEnumsOutputFileName { get; set; }

        [Option("domain-definition", Required = false, DefaultValue = "domain.d.ts", HelpText = "Domain Typescript Definition File Name")]
        public String DomainDefinitionOutputFileName { get; set; }

        [Option("domain-service", Required = false, DefaultValue = "service.ts", HelpText = "Domain Operations Typescript File Name")]
        public String DomainServiceOutputFileName { get; set; }

        [Option('h', "help", HelpText = "Prints this help", Required = false, DefaultValue = false)]
        public Boolean Help { get; set; }

        [Option("is-debug", Required = true, HelpText = "Debug Flag")]
        public Boolean IsDebug { get; set; }

        [Option("output-path", Required = true, HelpText = "Directory for Output Files")]
        public String OutputPath { get; set; }

        [Option("solution-directory", Required = true, HelpText = "Root Path to Solution")]
        public String SolutionDirectory { get; set; }

        [Option("source-file-name", Required = true, HelpText = "File Name of the Source DLL")]
        public String SourceFileName { get; set; }
    }
}
