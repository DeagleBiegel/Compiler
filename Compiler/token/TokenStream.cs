using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.token
{
    class TokenStream
    {
        private List<Token> tokens;

        private int index;

        public TokenStream(List<Token> tokens)
        {
            this.tokens = tokens;
            index = 0;
        }

        public bool Peek(TokenType type)
        {
            return tokens[index].Equals(type);
        }
    }
}
