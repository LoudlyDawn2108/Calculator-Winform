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
            textInput.Text += sender.ToString()?.Last();
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            labelResult.Text = "";
            textInput.Text = textInput.Text.Remove(textInput.Text.Length - 1);
        }

        private void buttonAC_Click(object sender, EventArgs e) {
            labelResult.Text = "";
            textInput.Text = "";
        }
    }
}
