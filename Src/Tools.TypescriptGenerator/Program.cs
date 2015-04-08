using System;
using System.IO;
using System.Reflection;
using CommandLine.Text;
using Tools.TypescriptGenerator.Configuration;
using Tools.TypescriptGenerator.Generators;

namespace Tools.TypescriptGenerator
{
    class Program
    {
        public static Options Configuration = new Options();
        public static DomainTypescriptGenerator domainGenerator = new DomainTypescriptGenerator();

        public static void Main(String[] args)
        {
            CommandLine.Parser.Default.ParseArguments(args, Configuration);

            if (Configuration.Help)
            {
                Console.WriteLine(HelpText.AutoBuild(Configuration));
                return;
            }

            Configuration.OutputPath = @"C:\Projects\PersonalDomain\Src\PersonalDomain.UI.Web\app\blog";
            Configuration.SolutionDirectory = @"C:\Projects\PersonalDomain\Src\PersonalDomain.Application\obj";
            Configuration.SourceFileName = "PersonalDomain.Application.dll";
            Configuration.IsDebug = true;

            var sourceAssemblyPath = Path.Combine(Configuration.SolutionDirectory, Configuration.IsDebug ? "Debug" : "Release", Configuration.SourceFileName);
            var sourceAssembly = Assembly.LoadFile(sourceAssemblyPath);

            domainGenerator.GenerateTypescript(sourceAssembly, Configuration);
        }
    }
}
