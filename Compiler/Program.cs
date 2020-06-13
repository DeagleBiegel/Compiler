using Compiler.parser;
using Compiler.token;
using System;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Tokenizer tokenizer = new Tokenizer("/* test */ ( + ) *");
            Parser parser = new Parser(tokenizer);

            foreach (Token token in tokenizer.FilteredTokens())
            {
                Console.WriteLine("{0} : {1}", token.Type, token.Value);
            }
        }
    }
}
