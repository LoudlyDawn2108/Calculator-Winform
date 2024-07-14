namespace Calculator_Winform {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void buttonSymbol_Click(object sender, EventArgs e) {
            labelResult.Text = "";
            if (textInput.Text.Equals("0")) {
                textInput.Text = "";
            }
            char lastChar = sender.ToString()!.Last();
            if (lastChar.Equals('²')) {
                textInput.Text += "^2";
            } else {
                textInput.Text += lastChar;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            labelResult.Text = "";
            textInput.Text = textInput.Text.Remove(textInput.Text.Length - 1);
        }

        private void buttonAC_Click(object sender, EventArgs e) {
            labelResult.Text = "";
            textInput.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e) {
            try {
                labelResult.Text = Math_Expression_Evaluator.Program.Evaluate(textInput.Text).ToString();
            } catch {
                labelResult.Text = "Invalid Syntax";
            }
        }
    }
}
