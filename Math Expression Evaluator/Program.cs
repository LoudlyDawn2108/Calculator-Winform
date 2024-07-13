using System.Text;

namespace Math_Expression_Evaluator {

    enum TokenType {
        NUMBER,
        OPERATOR,
        UNKOWN,
        END
    };

    struct Operator {
        public int precedence;
        public bool rightAssociative;
    }

    class Token {
        public TokenType type;
        public string symbol;
        public Operator op;

        public Token(TokenType type, string symbol) {
            this.type = type;
            this.symbol = symbol;
        }

        public Token(TokenType type, string symbol, Operator op) {
            this.type = type;
            this.symbol = symbol;
            this.op = op;
        }
    }
    public class Program {
        string processNegate(string input) {
            var output = new StringBuilder();
            for (int i = 0; i < input.Length; i++) {
                if (input[i] == '-' && (i == 0 || input[i - 1] == '(')) {
                    output.Append("n");
                } else {
                    output.Append(input[i]);
                }
            }
            return output.ToString();

        }
        List<Token> tokenizer(string expression) {
            List<Token> tokens = new List<Token>();
            for (int i = 0; i < expression.Length; i++) {

            }
            tokens.Add(new Token(TokenType.END, ""));
            return tokens;
        }


        static void Main(string[] args) {
            string input = "-(5 + 3) - -2";
            Console.WriteLine("Hello, World!");
        }
    }
}
