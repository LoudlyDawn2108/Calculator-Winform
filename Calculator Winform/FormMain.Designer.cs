namespace Calculator_Winform
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textInput = new TextBox();
            buttonPlus = new Button();
            buttonEqual = new Button();
            button0 = new Button();
            buttonPoint = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonMinus = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMul = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonDiv = new Button();
            buttonExp = new Button();
            buttonSquare = new Button();
            buttonSqrt = new Button();
            buttonDelete = new Button();
            buttonLB = new Button();
            buttonRB = new Button();
            buttonMod = new Button();
            buttonAC = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.BackColor = Color.FromArgb(32, 32, 32);
            textInput.BorderStyle = BorderStyle.None;
            textInput.Cursor = Cursors.No;
            textInput.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textInput.ForeColor = Color.FromArgb(231, 231, 231);
            textInput.Location = new Point(12, 52);
            textInput.Name = "textInput";
            textInput.RightToLeft = RightToLeft.No;
            textInput.Size = new Size(435, 43);
            textInput.TabIndex = 0;
            textInput.Text = "0";
            textInput.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(50, 50, 50);
            buttonPlus.FlatAppearance.BorderColor = Color.Black;
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.Font = new Font("Segoe UI", 15.75F);
            buttonPlus.ForeColor = Color.FromArgb(231, 231, 231);
            buttonPlus.Location = new Point(341, 522);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(111, 61);
            buttonPlus.TabIndex = 1;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonSymbol_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.FromArgb(48, 229, 255);
            buttonEqual.Font = new Font("Segoe UI", 15.75F);
            buttonEqual.ForeColor = Color.FromArgb(13, 64, 71);
            buttonEqual.Location = new Point(229, 522);
            buttonEqual.Margin = new Padding(2);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(111, 61);
            buttonEqual.TabIndex = 2;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(59, 59, 59);
            button0.Font = new Font("Segoe UI", 15.75F);
            button0.Location = new Point(117, 522);
            button0.Margin = new Padding(2);
            button0.Name = "button0";
            button0.Size = new Size(111, 61);
            button0.TabIndex = 3;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += buttonSymbol_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.BackColor = Color.FromArgb(59, 59, 59);
            buttonPoint.Font = new Font("Segoe UI", 15.75F);
            buttonPoint.Location = new Point(4, 522);
            buttonPoint.Margin = new Padding(2);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(111, 61);
            buttonPoint.TabIndex = 4;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = false;
            buttonPoint.Click += buttonSymbol_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(59, 59, 59);
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(4, 456);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 61);
            button1.TabIndex = 8;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSymbol_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(59, 59, 59);
            button2.Font = new Font("Segoe UI", 15.75F);
            button2.Location = new Point(117, 456);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(111, 61);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSymbol_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(59, 59, 59);
            button3.Font = new Font("Segoe UI", 15.75F);
            button3.Location = new Point(229, 456);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(111, 61);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonSymbol_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(50, 50, 50);
            buttonMinus.FlatAppearance.BorderColor = Color.Black;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.Font = new Font("Segoe UI", 15.75F);
            buttonMinus.ForeColor = Color.FromArgb(231, 231, 231);
            buttonMinus.Location = new Point(341, 456);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(111, 61);
            buttonMinus.TabIndex = 5;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonSymbol_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(59, 59, 59);
            button4.Font = new Font("Segoe UI", 15.75F);
            button4.Location = new Point(4, 390);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(111, 61);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonSymbol_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(59, 59, 59);
            button5.Font = new Font("Segoe UI", 15.75F);
            button5.Location = new Point(117, 390);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(111, 61);
            button5.TabIndex = 11;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonSymbol_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(59, 59, 59);
            button6.Font = new Font("Segoe UI", 15.75F);
            button6.Location = new Point(229, 390);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(111, 61);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonSymbol_Click;
            // 
            // buttonMul
            // 
            buttonMul.BackColor = Color.FromArgb(50, 50, 50);
            buttonMul.FlatAppearance.BorderColor = Color.Black;
            buttonMul.FlatAppearance.BorderSize = 0;
            buttonMul.Font = new Font("Segoe UI", 15.75F);
            buttonMul.ForeColor = Color.FromArgb(231, 231, 231);
            buttonMul.Location = new Point(341, 390);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(111, 61);
            buttonMul.TabIndex = 9;
            buttonMul.Text = "×";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += buttonSymbol_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(59, 59, 59);
            button7.Font = new Font("Segoe UI", 15.75F);
            button7.Location = new Point(4, 325);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(111, 61);
            button7.TabIndex = 16;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonSymbol_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(59, 59, 59);
            button8.Font = new Font("Segoe UI", 15.75F);
            button8.Location = new Point(117, 325);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(111, 61);
            button8.TabIndex = 15;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonSymbol_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(59, 59, 59);
            button9.Font = new Font("Segoe UI", 15.75F);
            button9.Location = new Point(229, 325);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(111, 61);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonSymbol_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.FromArgb(50, 50, 50);
            buttonDiv.FlatAppearance.BorderColor = Color.Black;
            buttonDiv.FlatAppearance.BorderSize = 0;
            buttonDiv.Font = new Font("Segoe UI", 15.75F);
            buttonDiv.ForeColor = Color.FromArgb(231, 231, 231);
            buttonDiv.Location = new Point(341, 325);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(111, 61);
            buttonDiv.TabIndex = 13;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonSymbol_Click;
            // 
            // buttonExp
            // 
            buttonExp.BackColor = Color.FromArgb(50, 50, 50);
            buttonExp.Font = new Font("Segoe UI", 15.75F);
            buttonExp.Location = new Point(4, 260);
            buttonExp.Margin = new Padding(2);
            buttonExp.Name = "buttonExp";
            buttonExp.Size = new Size(111, 61);
            buttonExp.TabIndex = 20;
            buttonExp.Text = "^";
            buttonExp.UseVisualStyleBackColor = false;
            buttonExp.Click += buttonSymbol_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.BackColor = Color.FromArgb(50, 50, 50);
            buttonSquare.Font = new Font("Segoe UI", 15.75F);
            buttonSquare.Location = new Point(117, 260);
            buttonSquare.Margin = new Padding(2);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(111, 61);
            buttonSquare.TabIndex = 19;
            buttonSquare.Text = " x²";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonSymbol_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.BackColor = Color.FromArgb(50, 50, 50);
            buttonSqrt.Font = new Font("Segoe UI", 15.75F);
            buttonSqrt.Location = new Point(229, 260);
            buttonSqrt.Margin = new Padding(2);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(111, 61);
            buttonSqrt.TabIndex = 18;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += buttonSymbol_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(50, 50, 50);
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Font = new Font("Segoe UI", 15.75F);
            buttonDelete.ForeColor = Color.FromArgb(231, 231, 231);
            buttonDelete.Location = new Point(341, 260);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(111, 61);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "DEL";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonLB
            // 
            buttonLB.BackColor = Color.FromArgb(50, 50, 50);
            buttonLB.Font = new Font("Segoe UI", 15.75F);
            buttonLB.Location = new Point(4, 195);
            buttonLB.Margin = new Padding(2);
            buttonLB.Name = "buttonLB";
            buttonLB.Size = new Size(111, 61);
            buttonLB.TabIndex = 24;
            buttonLB.Text = "(";
            buttonLB.UseVisualStyleBackColor = false;
            buttonLB.Click += buttonSymbol_Click;
            // 
            // buttonRB
            // 
            buttonRB.BackColor = Color.FromArgb(50, 50, 50);
            buttonRB.Font = new Font("Segoe UI", 15.75F);
            buttonRB.Location = new Point(117, 195);
            buttonRB.Margin = new Padding(2);
            buttonRB.Name = "buttonRB";
            buttonRB.Size = new Size(111, 61);
            buttonRB.TabIndex = 23;
            buttonRB.Text = ")";
            buttonRB.UseVisualStyleBackColor = false;
            buttonRB.Click += buttonSymbol_Click;
            // 
            // buttonMod
            // 
            buttonMod.BackColor = Color.FromArgb(50, 50, 50);
            buttonMod.Font = new Font("Segoe UI", 15.75F);
            buttonMod.Location = new Point(229, 195);
            buttonMod.Margin = new Padding(2);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(111, 61);
            buttonMod.TabIndex = 22;
            buttonMod.Text = "%";
            buttonMod.UseVisualStyleBackColor = false;
            buttonMod.Click += buttonSymbol_Click;
            // 
            // buttonAC
            // 
            buttonAC.BackColor = Color.FromArgb(50, 50, 50);
            buttonAC.FlatAppearance.BorderColor = Color.Black;
            buttonAC.FlatAppearance.BorderSize = 0;
            buttonAC.Font = new Font("Segoe UI", 15.75F);
            buttonAC.ForeColor = Color.FromArgb(231, 231, 231);
            buttonAC.Location = new Point(341, 195);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(111, 61);
            buttonAC.TabIndex = 21;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = false;
            buttonAC.Click += buttonAC_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(4, 117);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(110, 45);
            labelResult.TabIndex = 25;
            labelResult.Text = "00000";
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(456, 587);
            Controls.Add(labelResult);
            Controls.Add(buttonLB);
            Controls.Add(buttonRB);
            Controls.Add(buttonMod);
            Controls.Add(buttonAC);
            Controls.Add(buttonExp);
            Controls.Add(buttonSquare);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonDelete);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(buttonDiv);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonMul);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPoint);
            Controls.Add(button0);
            Controls.Add(buttonEqual);
            Controls.Add(buttonPlus);
            Controls.Add(textInput);
            ForeColor = Color.FromArgb(231, 231, 231);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Button buttonPlus;
        private Button buttonEqual;
        private Button button0;
        private Button buttonPoint;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonMinus;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMul;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonDiv;
        private Button buttonExp;
        private Button buttonSquare;
        private Button buttonSqrt;
        private Button buttonDelete;
        private Button buttonLB;
        private Button buttonRB;
        private Button buttonMod;
        private Button buttonAC;
        private Label labelResult;
    }
}
