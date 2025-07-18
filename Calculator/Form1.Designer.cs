namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chbAlwaysOnTop = new CheckBox();
            btnFloatNum = new Button();
            btnNum0 = new Button();
            btnMomayes = new Button();
            btnEqual = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnSum = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnMinus = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnMultiply = new Button();
            button20 = new Button();
            btnLeftOver = new Button();
            btnXto2 = new Button();
            brnCachDel = new Button();
            button24 = new Button();
            btnDivide = new Button();
            btnCach = new Button();
            btnDel = new Button();
            txtDisplay = new RichTextBox();
            txtHistory = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // chbAlwaysOnTop
            // 
            chbAlwaysOnTop.AutoSize = true;
            chbAlwaysOnTop.Font = new Font("Poor Richard", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbAlwaysOnTop.ForeColor = SystemColors.ButtonHighlight;
            chbAlwaysOnTop.Location = new Point(163, 48);
            chbAlwaysOnTop.Margin = new Padding(2);
            chbAlwaysOnTop.Name = "chbAlwaysOnTop";
            chbAlwaysOnTop.Size = new Size(119, 22);
            chbAlwaysOnTop.TabIndex = 3;
            chbAlwaysOnTop.Text = "always on top";
            chbAlwaysOnTop.UseVisualStyleBackColor = true;
            chbAlwaysOnTop.CheckedChanged += chbAlwaysOnTop_CheckedChanged;
            // 
            // btnFloatNum
            // 
            btnFloatNum.BackColor = SystemColors.MenuText;
            btnFloatNum.FlatStyle = FlatStyle.Popup;
            btnFloatNum.Font = new Font("Segoe UI", 13.8F);
            btnFloatNum.ForeColor = SystemColors.Info;
            btnFloatNum.Location = new Point(3, 584);
            btnFloatNum.Name = "btnFloatNum";
            btnFloatNum.Size = new Size(89, 66);
            btnFloatNum.TabIndex = 4;
            btnFloatNum.Text = "+/-";
            btnFloatNum.UseVisualStyleBackColor = false;
            btnFloatNum.Click += btnFloatNum_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = SystemColors.MenuText;
            btnNum0.FlatStyle = FlatStyle.Popup;
            btnNum0.Font = new Font("Segoe UI", 13.8F);
            btnNum0.ForeColor = SystemColors.Info;
            btnNum0.Location = new Point(97, 584);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(89, 66);
            btnNum0.TabIndex = 4;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            btnNum0.MouseEnter += btnNum1_MouseEnter;
            btnNum0.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnMomayes
            // 
            btnMomayes.BackColor = SystemColors.MenuText;
            btnMomayes.FlatStyle = FlatStyle.Popup;
            btnMomayes.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMomayes.ForeColor = SystemColors.Info;
            btnMomayes.Location = new Point(192, 584);
            btnMomayes.Name = "btnMomayes";
            btnMomayes.Size = new Size(89, 66);
            btnMomayes.TabIndex = 4;
            btnMomayes.Text = ".";
            btnMomayes.UseVisualStyleBackColor = false;
            btnMomayes.Click += btnMomayes_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.HotTrack;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.Info;
            btnEqual.Location = new Point(288, 584);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(89, 66);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = SystemColors.MenuText;
            btnNum1.FlatStyle = FlatStyle.Popup;
            btnNum1.Font = new Font("Segoe UI", 13.8F);
            btnNum1.ForeColor = SystemColors.Info;
            btnNum1.Location = new Point(3, 514);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(89, 66);
            btnNum1.TabIndex = 4;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            btnNum1.MouseEnter += btnNum1_MouseEnter;
            btnNum1.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = SystemColors.MenuText;
            btnNum2.FlatStyle = FlatStyle.Popup;
            btnNum2.Font = new Font("Segoe UI", 13.8F);
            btnNum2.ForeColor = SystemColors.Info;
            btnNum2.Location = new Point(97, 514);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(89, 66);
            btnNum2.TabIndex = 4;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum1_Click;
            btnNum2.MouseEnter += btnNum1_MouseEnter;
            btnNum2.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = SystemColors.MenuText;
            btnNum3.FlatStyle = FlatStyle.Popup;
            btnNum3.Font = new Font("Segoe UI", 13.8F);
            btnNum3.ForeColor = SystemColors.Info;
            btnNum3.Location = new Point(192, 513);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(89, 66);
            btnNum3.TabIndex = 4;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum1_Click;
            btnNum3.MouseEnter += btnNum1_MouseEnter;
            btnNum3.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.FromArgb(64, 64, 64);
            btnSum.FlatStyle = FlatStyle.Flat;
            btnSum.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSum.ForeColor = SystemColors.Info;
            btnSum.Location = new Point(288, 513);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(89, 66);
            btnSum.TabIndex = 4;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = SystemColors.MenuText;
            btnNum4.FlatStyle = FlatStyle.Popup;
            btnNum4.Font = new Font("Segoe UI", 13.8F);
            btnNum4.ForeColor = SystemColors.Info;
            btnNum4.Location = new Point(3, 442);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(89, 66);
            btnNum4.TabIndex = 4;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum1_Click;
            btnNum4.MouseEnter += btnNum1_MouseEnter;
            btnNum4.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = SystemColors.MenuText;
            btnNum5.FlatStyle = FlatStyle.Popup;
            btnNum5.Font = new Font("Segoe UI", 13.8F);
            btnNum5.ForeColor = SystemColors.Info;
            btnNum5.Location = new Point(97, 442);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(89, 66);
            btnNum5.TabIndex = 4;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum1_Click;
            btnNum5.MouseEnter += btnNum1_MouseEnter;
            btnNum5.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = SystemColors.MenuText;
            btnNum6.FlatStyle = FlatStyle.Popup;
            btnNum6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNum6.ForeColor = SystemColors.Info;
            btnNum6.Location = new Point(192, 442);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(89, 66);
            btnNum6.TabIndex = 4;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum1_Click;
            btnNum6.MouseEnter += btnNum1_MouseEnter;
            btnNum6.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(64, 64, 64);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = SystemColors.Info;
            btnMinus.Location = new Point(288, 442);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(89, 66);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnSum_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = SystemColors.MenuText;
            btnNum7.FlatStyle = FlatStyle.Popup;
            btnNum7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNum7.ForeColor = SystemColors.Info;
            btnNum7.Location = new Point(3, 370);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(89, 66);
            btnNum7.TabIndex = 4;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum1_Click;
            btnNum7.MouseEnter += btnNum1_MouseEnter;
            btnNum7.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = SystemColors.MenuText;
            btnNum8.FlatStyle = FlatStyle.Popup;
            btnNum8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNum8.ForeColor = SystemColors.Info;
            btnNum8.Location = new Point(97, 370);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(89, 66);
            btnNum8.TabIndex = 4;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum1_Click;
            btnNum8.MouseEnter += btnNum1_MouseEnter;
            btnNum8.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = SystemColors.MenuText;
            btnNum9.FlatStyle = FlatStyle.Popup;
            btnNum9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNum9.ForeColor = SystemColors.Info;
            btnNum9.Location = new Point(193, 370);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(89, 66);
            btnNum9.TabIndex = 4;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum1_Click;
            btnNum9.MouseEnter += btnNum1_MouseEnter;
            btnNum9.MouseLeave += btnNum1_MouseLeave;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(64, 64, 64);
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = SystemColors.Info;
            btnMultiply.Location = new Point(288, 370);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(89, 66);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnSum_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(64, 64, 64);
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.ForeColor = SystemColors.Info;
            button20.Location = new Point(3, 299);
            button20.Name = "button20";
            button20.Size = new Size(89, 66);
            button20.TabIndex = 4;
            button20.Text = "1/x";
            button20.UseVisualStyleBackColor = false;
            // 
            // btnLeftOver
            // 
            btnLeftOver.BackColor = Color.FromArgb(64, 64, 64);
            btnLeftOver.FlatStyle = FlatStyle.Flat;
            btnLeftOver.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeftOver.ForeColor = SystemColors.Info;
            btnLeftOver.Location = new Point(3, 228);
            btnLeftOver.Name = "btnLeftOver";
            btnLeftOver.Size = new Size(89, 66);
            btnLeftOver.TabIndex = 4;
            btnLeftOver.Text = "%";
            btnLeftOver.UseVisualStyleBackColor = false;
            btnLeftOver.Click += btnSum_Click;
            // 
            // btnXto2
            // 
            btnXto2.BackColor = Color.FromArgb(64, 64, 64);
            btnXto2.FlatStyle = FlatStyle.Flat;
            btnXto2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXto2.ForeColor = SystemColors.Info;
            btnXto2.Location = new Point(97, 299);
            btnXto2.Name = "btnXto2";
            btnXto2.Size = new Size(89, 66);
            btnXto2.TabIndex = 4;
            btnXto2.Text = "x2";
            btnXto2.UseVisualStyleBackColor = false;
            btnXto2.Click += btnSum_Click;
            // 
            // brnCachDel
            // 
            brnCachDel.BackColor = Color.FromArgb(64, 64, 64);
            brnCachDel.FlatStyle = FlatStyle.Flat;
            brnCachDel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brnCachDel.ForeColor = SystemColors.Info;
            brnCachDel.Location = new Point(97, 228);
            brnCachDel.Name = "brnCachDel";
            brnCachDel.Size = new Size(89, 66);
            brnCachDel.TabIndex = 4;
            brnCachDel.Text = "CE";
            brnCachDel.UseVisualStyleBackColor = false;
            brnCachDel.Click += brnCachDel_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(64, 64, 64);
            button24.FlatStyle = FlatStyle.Flat;
            button24.Location = new Point(193, 298);
            button24.Name = "button24";
            button24.Size = new Size(89, 66);
            button24.TabIndex = 4;
            button24.Text = "button4";
            button24.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(64, 64, 64);
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.Info;
            btnDivide.Location = new Point(288, 299);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(89, 66);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnSum_Click;
            // 
            // btnCach
            // 
            btnCach.BackColor = Color.FromArgb(64, 64, 64);
            btnCach.FlatStyle = FlatStyle.Flat;
            btnCach.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCach.ForeColor = SystemColors.Info;
            btnCach.Location = new Point(193, 227);
            btnCach.Name = "btnCach";
            btnCach.Size = new Size(89, 66);
            btnCach.TabIndex = 4;
            btnCach.Text = "C";
            btnCach.UseVisualStyleBackColor = false;
            btnCach.Click += btnCach_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(64, 64, 64);
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.Info;
            btnDel.Location = new Point(288, 228);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(89, 66);
            btnDel.TabIndex = 4;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.WindowFrame;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Info;
            txtDisplay.Location = new Point(2, 137);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(375, 85);
            txtDisplay.TabIndex = 5;
            txtDisplay.Text = "";
            // 
            // txtHistory
            // 
            txtHistory.BackColor = SystemColors.WindowFrame;
            txtHistory.ForeColor = SystemColors.Info;
            txtHistory.Location = new Point(4, 104);
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(374, 27);
            txtHistory.TabIndex = 6;
            txtHistory.TextChanged += y;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(136, 41);
            label2.TabIndex = 8;
            label2.Text = "Standard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(382, 654);
            Controls.Add(label2);
            Controls.Add(txtHistory);
            Controls.Add(txtDisplay);
            Controls.Add(btnDel);
            Controls.Add(btnCach);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnNum9);
            Controls.Add(button24);
            Controls.Add(btnMinus);
            Controls.Add(btnNum6);
            Controls.Add(brnCachDel);
            Controls.Add(btnSum);
            Controls.Add(btnNum8);
            Controls.Add(btnXto2);
            Controls.Add(btnNum3);
            Controls.Add(btnNum5);
            Controls.Add(btnLeftOver);
            Controls.Add(btnEqual);
            Controls.Add(btnNum7);
            Controls.Add(button20);
            Controls.Add(btnNum2);
            Controls.Add(btnNum4);
            Controls.Add(btnMomayes);
            Controls.Add(btnNum1);
            Controls.Add(btnNum0);
            Controls.Add(btnFloatNum);
            Controls.Add(chbAlwaysOnTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClose;
        private CheckBox chbAlwaysOnTop;
        private Button btnFloatNum;
        private Button btnNum0;
        private Button btnMomayes;
        private Button btnEqual;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnSum;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnMinus;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnMultiply;
        private Button button20;
        private Button btnLeftOver;
        private Button btnXto2;
        private Button brnCachDel;
        private Button button24;
        private Button btnDivide;
        private Button btnCach;
        private Button btnDel;
        private RichTextBox txtDisplay;
        private TextBox txtHistory;
        private Label label2;
    }
}
