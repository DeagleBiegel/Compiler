﻿using System;
using System.Collections.Generic;
using System.Text;
using Compiler.AST.nodes;

namespace Compiler.AST.visitors
{
    class TypeChecker : IASTVisitor
    {
        public object Visit(plus plus)
        {
            throw new NotImplementedException();
        }
    }
}
