using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.AST
{
    public abstract class ASTNode
    {
        public abstract object Accept(IASTVisitor visitor);
    }
}
