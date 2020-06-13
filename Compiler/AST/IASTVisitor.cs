using Compiler.AST.nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.AST
{
    public interface IASTVisitor
    {
        public object Visit(plus plus);
    }
}
