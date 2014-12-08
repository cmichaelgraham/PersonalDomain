using System;

namespace Tools.TypescriptGenerator.Lexing
{
    public interface ITokenizer<TSource> where TSource : class
    {
        TSource Source { get; }
        Object[] Tokenize();
    }
}
