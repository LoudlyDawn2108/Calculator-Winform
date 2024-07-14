using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Expression_Evaluator {

    class Token {
        public TokenType Type { get; set; }
        public string? Symbol { get; set; }

        public int GetPrecedence() {
            if (Type == TokenType.Operator) {
                return Symbol switch {
                    "+" => 1,
                    "-" => 1,
                    "*" => 2,
                    "/" => 2,
                    "%" => 2,
                    "^" => 3,
                    "√" => 3,
                    "n" => 4,
                    _ => 0,
                };
            }
            return 0;
        }
    };

    enum TokenType {
        Number,
        Operator,
        UNKNOWN,
    }
}
