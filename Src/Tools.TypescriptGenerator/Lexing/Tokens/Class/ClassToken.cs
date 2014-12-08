using System;

namespace Tools.TypescriptGenerator.Lexing
{
    public class ClassToken : Token<Type>, IClassToken
    {
        public ClassToken(Type lexeme) : base(lexeme)
        {
        }
    }
}
