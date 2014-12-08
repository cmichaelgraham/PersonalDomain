using System.Reflection;

namespace Tools.TypescriptGenerator.Lexing
{
    public class FunctionToken : Token<MethodInfo>, IFunctionToken
    {
        public FunctionToken(MethodInfo lexeme) : base(lexeme)
        {
        }
    }
}
