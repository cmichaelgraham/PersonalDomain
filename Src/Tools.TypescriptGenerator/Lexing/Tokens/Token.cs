namespace Tools.TypescriptGenerator.Lexing
{
    public abstract class Token<TLexeme> : IToken<TLexeme> where TLexeme : class
    {
        public TLexeme Lexeme { get; set; }

        protected Token(TLexeme lexeme)
        {
            Lexeme = lexeme;
        } 
    }
}
