using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Compiler.token
{
    public class Tokenizer
    {
        private List<Token> tokens;

        private int index;

        public Tokenizer(string input)
        {
            tokens = new List<Token>();
            Tokenize(input);
        }

        private void Tokenize(string input)
        {
            index = 0;
            Token token = Extract(input);

            while (token != null)
            {
                tokens.Add(token);
                token = Extract(input);
            }
        }

        private Token Extract(string input)
        {
            foreach(TokenType type in Enum.GetValues(typeof(TokenType))) 
            {
                var matcher = Regex.Match(input.Substring(index), type.GetAttribute<RegularExpressionAttribute>().Pattern);

                if (matcher.Success)
                {
                    index += matcher.Length;
                    return new Token(type, matcher.Value);
                }
            }

            return null;
        }

        public List<Token> FilteredTokens()
        {
            List<Token> result = new List<Token>();

            foreach(Token token in tokens)
            {
                if (!(token.Type.Equals(TokenType.WHITE_SPACE) || token.Type.Equals(TokenType.COMMENT)))
                {
                    result.Add(token);
                }
            }

            return result;
        }
    }
}
