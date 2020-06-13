using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Compiler.token
{
    public enum TokenType
    {
        [RegularExpression("(/\\*.*?\\*/)")]
        COMMENT,

        [RegularExpression("^ ")]
        WHITE_SPACE,

        [RegularExpression("^\\,")]
        COMMA,

        [RegularExpression("^\\(")]
        LPAR,

        [RegularExpression("^\\)")]
        RPAR,

        [RegularExpression("^\\[")]
        LBRA,

        [RegularExpression("^\\]")]
        RBAR,

        [RegularExpression("^\\{")]
        LCUR,

        [RegularExpression("^\\}")]
        RCUR,

        [RegularExpression("^\\+")]
        PLUS,

        [RegularExpression("^\\-")]
        MINUS,

        [RegularExpression("^\\*")]
        MULTIPLY,

        [RegularExpression("^\\/")]
        DIVIDE,

        [RegularExpression("^\\%")]
        MODULO,
    }
}
