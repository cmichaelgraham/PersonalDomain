using System.Reflection;

namespace Tools.TypescriptGenerator.Lexing
{
    public class AssemblyTokenString : TokenString<Assembly>, IAssemblyTokenString
    {
        public override ITokenizer<Assembly> Tokenizer 
        {
            get { return new AssemblyTokenizer(_source); }
        }

        public AssemblyTokenString(Assembly assembly) : base(assembly)
        {
        }
    }
}
