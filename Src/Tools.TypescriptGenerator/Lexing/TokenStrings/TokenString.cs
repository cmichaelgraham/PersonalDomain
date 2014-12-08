using System.Collections;

namespace Tools.TypescriptGenerator.Lexing
{
    public abstract class TokenString<TSource> : IEnumerable, ITokenString<TSource> where TSource : class
    {
        protected TSource _source { get; set; }

        public abstract ITokenizer<TSource> Tokenizer { get; }

        protected TokenString(TSource source)
        {
            _source = source;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) Tokenizer;
        }
    }
}

