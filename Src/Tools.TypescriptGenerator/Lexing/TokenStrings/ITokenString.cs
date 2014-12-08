namespace Tools.TypescriptGenerator.Lexing
{
    public interface ITokenString<TSource> where TSource : class
    {
        ITokenizer<TSource> Tokenizer { get; }
    }
}
