using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.AST.nodes
{
    public class plus : ASTNode
    {
        public override object Accept(IASTVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
