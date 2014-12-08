using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Application.Seedwork.Operations;
using Application.Seedwork.Operations.Command;
using Application.Seedwork.Operations.Request;
using Application.Seedwork.Operations.Response;

namespace Tools.TypescriptGenerator.Lexing
{
    public class AssemblyTokenizer : Tokenizer<Assembly>, IAssemblyTokenizer
    {
        private Int32 _position = -1;
        private Object[] _tokens { get; set; }

        public override Object Current
        {
            get
            {
                try { return Tokens[_position]; }
                catch (IndexOutOfRangeException) { throw new InvalidOperationException(); }
            }
        }

        public Object[] Tokens
        {
            get { return _tokens ?? (_tokens = Tokenize()); }
        }

        public AssemblyTokenizer(Assembly source) : base(source)
        {
        }

        public override Boolean MoveNext()
        {
            _position++;
            return (_position < Tokens.Length);
        }

        public override void Reset()
        {
            _position = -1;
        }

        public override Object[] Tokenize()
        {
            var tokens = new List<Object> { };

            var exportedTypes = Source.ExportedTypes.Where(et => !et.IsAbstract && !et.IsInterface);

            var operations = exportedTypes.Where(et => et.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IOperation<,>)));
            var requestObjects = exportedTypes.Where(et => et.GetInterfaces().Any(i => i == typeof(IRequest)));
            var responseObjects = exportedTypes.Where(et => et.GetInterfaces().Any(i => i == typeof(IResponse)));


            return tokens.ToArray();
        }
    }
}
