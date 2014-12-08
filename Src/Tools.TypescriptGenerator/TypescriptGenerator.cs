using System;
using System.Collections;
using System.Reflection;
using System.Security.Policy;
using Tools.TypescriptGenerator.Lexing;

namespace Tools.TypescriptGenerator
{
    class TypescriptGenerator
    {
        static void Main(String[] args)
        {
            //@"C:\Projects\PersonalDomain\Build\TypescriptGeneration\Application.WebApi.dll"
            //@"C:\Projects\PersonalDomain\Build\TypescriptGeneration\PersonalDomain.Application.WebApi.dll"

            //var assamblyName = AssemblyName.GetAssemblyName(@"C:\Projects\PersonalDomain\Build\TypescriptGeneration\PersonalDomain.Application.WebApi.dll");
            //var applicationDomain = AppDomain.CreateDomain("ApplicationDomain");
            //var applicationAssembly = applicationDomain.Load(assamblyName);

            ProxyDomain pd = new ProxyDomain();
            Assembly domainAssembly = pd.GetAssembly(@"C:\Projects\PersonalDomain\Build\TypescriptGeneration\PersonalDomain.Application.dll");
            var domainTokenString = new AssemblyTokenString(domainAssembly);

            foreach (var token in domainTokenString)
            {
                
            }

            Assembly applicationAssembly = pd.GetAssembly(@"C:\Projects\PersonalDomain\Build\TypescriptGeneration\PersonalDomain.Application.WebApi.dll");
            var applicationTokenString = new AssemblyTokenString(applicationAssembly);
        }
    }

    class ProxyDomain : MarshalByRefObject
    {
        public Assembly GetAssembly(string assemblyPath)
        {
            try
            {
                return Assembly.LoadFrom(assemblyPath);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.ToString());
            }
        }
    }
}
