namespace Tools.TypescriptGenerator.Lexing
{
    public interface IToken<TLexeme> where TLexeme : class
    {
        TLexeme Lexeme { get; }
    }
}
