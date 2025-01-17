namespace Project_Calculator
{
    partial class CalculatorView
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
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            inputTextBox = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnPower = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.BackgroundImageLayout = ImageLayout.Center;
            btn1.Location = new Point(22, 121);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(2, 3, 2, 3);
            btn1.Size = new Size(86, 40);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += numberClick;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.BackgroundImageLayout = ImageLayout.Center;
            btn2.Location = new Point(107, 121);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(2, 3, 2, 3);
            btn2.Size = new Size(86, 40);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += numberClick;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonHighlight;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.Location = new Point(193, 121);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(2, 3, 2, 3);
            btn3.Size = new Size(86, 40);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += numberClick;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonHighlight;
            btn6.BackgroundImageLayout = ImageLayout.Center;
            btn6.Location = new Point(193, 161);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Padding = new Padding(2, 3, 2, 3);
            btn6.Size = new Size(86, 40);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += numberClick;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.BackgroundImageLayout = ImageLayout.Center;
            btn5.Location = new Point(107, 160);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Padding = new Padding(2, 3, 2, 3);
            btn5.Size = new Size(86, 40);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += numberClick;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.BackgroundImageLayout = ImageLayout.Center;
            btn4.Location = new Point(22, 160);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Padding = new Padding(2, 3, 2, 3);
            btn4.Size = new Size(86, 40);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += numberClick;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonHighlight;
            btn9.BackgroundImageLayout = ImageLayout.Center;
            btn9.Location = new Point(193, 200);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Padding = new Padding(2, 3, 2, 3);
            btn9.Size = new Size(86, 40);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += numberClick;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.BackgroundImageLayout = ImageLayout.Center;
            btn8.Location = new Point(107, 200);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Padding = new Padding(2, 3, 2, 3);
            btn8.Size = new Size(86, 40);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += numberClick;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.BackgroundImageLayout = ImageLayout.Center;
            btn7.Location = new Point(22, 200);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Padding = new Padding(2, 3, 2, 3);
            btn7.Size = new Size(86, 40);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += numberClick;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonHighlight;
            btn0.BackgroundImageLayout = ImageLayout.Center;
            btn0.Location = new Point(107, 240);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Padding = new Padding(2, 3, 2, 3);
            btn0.Size = new Size(86, 40);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += numberClick;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = SystemColors.Window;
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            inputTextBox.ForeColor = SystemColors.InfoText;
            inputTextBox.Location = new Point(24, 36);
            inputTextBox.Margin = new Padding(3, 4, 3, 4);
            inputTextBox.MinimumSize = new Size(340, 50);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.RightToLeft = RightToLeft.Yes;
            inputTextBox.ScrollBars = ScrollBars.Horizontal;
            inputTextBox.Size = new Size(340, 61);
            inputTextBox.TabIndex = 15;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlDark;
            btnPlus.Location = new Point(279, 121);
            btnPlus.Margin = new Padding(0);
            btnPlus.Name = "btnPlus";
            btnPlus.Padding = new Padding(2, 3, 2, 3);
            btnPlus.Size = new Size(86, 40);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += operandClick;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlDark;
            btnMinus.Location = new Point(279, 161);
            btnMinus.Margin = new Padding(0);
            btnMinus.Name = "btnMinus";
            btnMinus.Padding = new Padding(2, 3, 2, 3);
            btnMinus.Size = new Size(86, 40);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += operandClick;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ControlDark;
            btnMultiply.Location = new Point(279, 200);
            btnMultiply.Margin = new Padding(0);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Padding = new Padding(2, 3, 2, 3);
            btnMultiply.Size = new Size(86, 40);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operandClick;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ControlDark;
            btnDivide.Location = new Point(279, 240);
            btnDivide.Margin = new Padding(0);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(86, 40);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += operandClick;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ScrollBar;
            btnEquals.Location = new Point(193, 240);
            btnEquals.Margin = new Padding(0);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(86, 40);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += equalClick;
            // 
            // btnPower
            // 
            btnPower.BackColor = SystemColors.ControlDark;
            btnPower.Location = new Point(22, 240);
            btnPower.Margin = new Padding(0);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(86, 40);
            btnPower.TabIndex = 16;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += operandClick;
            // 
            // CalculatorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 361);
            Controls.Add(btnPower);
            Controls.Add(btnEquals);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(inputTextBox);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "CalculatorView";
            Text = "Kalkulačka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private TextBox inputTextBox;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnPower;
        private Button btn6;
    }
}
