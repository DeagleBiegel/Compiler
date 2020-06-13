using Compiler.token;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.parser
{
    class Parser
    {
        private TokenStream ts;

        public Parser(Tokenizer tokenizer)
        {
            ts = new TokenStream(tokenizer.FilteredTokens());
        }
    }
}
