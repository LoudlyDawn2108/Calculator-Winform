using System.Diagnostics;
using System.Text;

namespace Math_Expression_Evaluator {

    
    public class Program {
        static List<Token> Tokenize(string expression) {
            List<Token> tokens = new List<Token>();

            for (int i = 0; i < expression.Length; i++) {
                char c = expression[i];
                if (c == ' ') {
                    continue;
                }

                tokens.Add(c switch {
                    '+' => new Token { Type = TokenType.Operator, Symbol = "+" },
                    '-' => new Token { Type = TokenType.Operator, Symbol = "-" },
                    '*' => new Token { Type = TokenType.Operator, Symbol = "*" },
                    '×' => new Token { Type = TokenType.Operator, Symbol = "*" },
                    '%' => new Token { Type = TokenType.Operator, Symbol = "%" },
                    '/' => new Token { Type = TokenType.Operator, Symbol = "/" },
                    '÷' => new Token { Type = TokenType.Operator, Symbol = "/" },
                    '^' => new Token { Type = TokenType.Operator, Symbol = "^" },
                    '√' => new Token { Type = TokenType.Operator, Symbol = "√" },
                    '(' => new Token { Type = TokenType.Operator, Symbol = "(" },
                    ')' => new Token { Type = TokenType.Operator, Symbol = ")" },
                    _ when Char.IsDigit(c) => ProcessNumber(expression, ref i),
                    _ => throw new ArgumentException($"Unexpected character: {c}")
                });
            }

            if (tokens[0].Symbol == "-") {
                tokens[0].Symbol = "n";
            }

            for (int i = 1; i < tokens.Count - 1; i++) {
                if (tokens[i].Symbol == "-" && (i == 0 || "+-%*/^√(".Contains(tokens[i - 1].Symbol!) || tokens[i + 1].Symbol == "(")) {
                    tokens[i].Symbol = "n";
                }
            }

            return tokens;
        }

        static Token ProcessNumber(string expression, ref int idx) {
            StringBuilder sb = new StringBuilder();
            bool point = false;
            while (idx < expression.Length && (Char.IsDigit(expression[idx]) || expression[idx] == '.')) {
                if (expression[idx] == '.' && point == false) {
                    point = true;
                } else if (expression[idx] == '.' && point == true) {
                    throw new ArithmeticException("Invalid syntax");
                }
                sb.Append(expression[idx]);
                idx++;
            }
            idx--; // Adjust idx since for-loop will increment it
            return new Token { Type = TokenType.Number, Symbol = sb.ToString() };
        }

        static List<Token> ConvertToPostfix(List<Token> infix) {
            var output = new List<Token>();
            var hold = new Stack<Token>();

            foreach (Token tok in infix) {
                if (tok.Type.Equals(TokenType.Number)) {
                    output.Add(tok);
                } else if (tok.Type.Equals(TokenType.Operator)) {
                    if (tok.Symbol == "(") {
                        hold.Push(tok);
                    } else if (tok.Symbol == ")") {
                        while (hold.Peek().Symbol != "(") {
                            output.Add(hold.Pop());
                        }
                        hold.Pop();
                    } else {
                        while (hold.Count > 0 && (tok.GetPrecedence() <= hold.Peek().GetPrecedence())) {
                            output.Add(hold.Pop());
                        }
                        hold.Push(tok);
                    }
                }
            }

            while (hold.Count > 0) {
                output.Add(hold.Pop());
            }


            return output;
        }

        static double Process(double a, double b, string symbol) {
            return (symbol switch {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                "%" => a % b,
                "^" => Math.Pow(a, b),
                _ => 0,
            });
        }

        public static double Evaluate(string input) {
            List<Token> tokens = ConvertToPostfix(Tokenize(input));
            var stack = new Stack<double>();

            foreach (Token tok in tokens) {
                if (tok.Type == TokenType.Number) {
                    stack.Push(Convert.ToDouble(tok.Symbol));
                } else {
                    if (tok.Symbol == "n") {
                        double top = stack.Pop();
                        stack.Push(-top);
                    } else if (tok.Symbol == "√") {
                        double top = stack.Pop();
                        stack.Push(Math.Sqrt(top));
                    } else {
                        double b = stack.Pop();
                        double a = stack.Pop();
                        stack.Push(Process(a, b, tok.Symbol!));
                    }
                }
            }

            return stack.Peek();
        }
        static void Main(string[] args) {
            string input = "1.5 * √9";
            double result = Evaluate(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
