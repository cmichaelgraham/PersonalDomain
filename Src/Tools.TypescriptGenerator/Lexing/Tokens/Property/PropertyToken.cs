using System.Reflection;

namespace Tools.TypescriptGenerator.Lexing
{
    public class PropertyToken : Token<PropertyInfo>, IPropertyToken
    {
        public PropertyToken(PropertyInfo lexeme) : base(lexeme)
        {
        }
    }
}
