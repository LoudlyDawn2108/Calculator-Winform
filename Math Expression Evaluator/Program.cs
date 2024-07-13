namespace Math_Expression_Evaluator
{

    enum TokenType
    {
        NUMBER,
        OPERATOR,
        UNKOWN,
        END
    };

    class Token
    {
        public TokenType type;
        public string value;

        public Token(TokenType type, string value)
        {
            this.type = type;
            this.value = value;
        }
    }
    public class Program
    {
        string processNegate(string input)
        {


        }
        List<Token> tokenizer(string expression)
        {
            List<Token> tokens = new List<Token>();
            for (int i = 0; i < expression.Length; i++)
            {
                
            }
            tokens.Add(new Token(TokenType.END, ""));
            return tokens;
        }

        
        static void Main(string[] args)
        {
            string input = "-(5 + 3) - -2";
            Console.WriteLine("Hello, World!");
        }
    }
}
