using System;

namespace Tools.TypescriptGenerator.Lexing
{
    public class AssemblyToken : Token<String>, IAssemblyToken
    {
        public AssemblyToken(String lexeme) : base(lexeme)
        {
        }
    }
}
