using System;
using System.Collections;

namespace Tools.TypescriptGenerator.Lexing
{
    public abstract class Tokenizer<TSource> : IEnumerator, ITokenizer<TSource> where TSource : class
    {
        public TSource Source { get; private set; }

        public abstract Object Current { get; }

        protected Tokenizer(TSource source)
        {
            Source = source;
        }

        public abstract Boolean MoveNext();
        public abstract void Reset();
        public abstract Object[] Tokenize();
    }
}

