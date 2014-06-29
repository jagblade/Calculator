namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.btnDecimalSeparator = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDigits = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDigit1
            // 
            this.btnDigit1.Location = new System.Drawing.Point(13, 115);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(45, 25);
            this.btnDigit1.TabIndex = 0;
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = true;
            // 
            // btnDigit2
            // 
            this.btnDigit2.Location = new System.Drawing.Point(68, 115);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(45, 25);
            this.btnDigit2.TabIndex = 1;
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = true;
            // 
            // btnDigit3
            // 
            this.btnDigit3.Location = new System.Drawing.Point(119, 115);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(45, 25);
            this.btnDigit3.TabIndex = 2;
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = true;
            // 
            // btnDigit4
            // 
            this.btnDigit4.Location = new System.Drawing.Point(13, 82);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(45, 25);
            this.btnDigit4.TabIndex = 3;
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = true;
            // 
            // btnDigit5
            // 
            this.btnDigit5.Location = new System.Drawing.Point(68, 82);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(45, 25);
            this.btnDigit5.TabIndex = 4;
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = true;
            // 
            // btnDigit6
            // 
            this.btnDigit6.Location = new System.Drawing.Point(119, 82);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(45, 25);
            this.btnDigit6.TabIndex = 5;
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = true;
            // 
            // btnDigit7
            // 
            this.btnDigit7.Location = new System.Drawing.Point(13, 51);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(45, 25);
            this.btnDigit7.TabIndex = 6;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            // 
            // btnDigit8
            // 
            this.btnDigit8.Location = new System.Drawing.Point(68, 51);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(45, 25);
            this.btnDigit8.TabIndex = 7;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            // 
            // btnDigit9
            // 
            this.btnDigit9.Location = new System.Drawing.Point(119, 51);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(45, 25);
            this.btnDigit9.TabIndex = 8;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            // 
            // btnDigit0
            // 
            this.btnDigit0.Location = new System.Drawing.Point(13, 144);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(100, 25);
            this.btnDigit0.TabIndex = 9;
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = true;
            // 
            // btnDecimalSeparator
            // 
            this.btnDecimalSeparator.Location = new System.Drawing.Point(119, 144);
            this.btnDecimalSeparator.Name = "btnDecimalSeparator";
            this.btnDecimalSeparator.Size = new System.Drawing.Size(45, 25);
            this.btnDecimalSeparator.TabIndex = 10;
            this.btnDecimalSeparator.Text = ",";
            this.btnDecimalSeparator.UseVisualStyleBackColor = true;
            this.btnDecimalSeparator.Click += new System.EventHandler(this.InputDecimalSeparator);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(171, 144);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 25);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(171, 115);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 25);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(170, 82);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(45, 25);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(170, 51);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 25);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(223, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(28, 54);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDigits
            // 
            this.txtDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigits.Location = new System.Drawing.Point(13, 13);
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.ReadOnly = true;
            this.txtDigits.Size = new System.Drawing.Size(237, 32);
            this.txtDigits.TabIndex = 16;
            this.txtDigits.Text = "0";
            this.txtDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 25);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearCurrent
            // 
            this.btnClearCurrent.Location = new System.Drawing.Point(221, 84);
            this.btnClearCurrent.Name = "btnClearCurrent";
            this.btnClearCurrent.Size = new System.Drawing.Size(30, 25);
            this.btnClearCurrent.TabIndex = 18;
            this.btnClearCurrent.Text = "CE";
            this.btnClearCurrent.UseVisualStyleBackColor = true;
            this.btnClearCurrent.Click += new System.EventHandler(this.btnClearCurrent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 179);
            this.Controls.Add(this.btnClearCurrent);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDigits);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDecimalSeparator);
            this.Controls.Add(this.btnDigit0);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnDigit6);
            this.Controls.Add(this.btnDigit5);
            this.Controls.Add(this.btnDigit4);
            this.Controls.Add(this.btnDigit3);
            this.Controls.Add(this.btnDigit2);
            this.Controls.Add(this.btnDigit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDigit1;
        private System.Windows.Forms.Button btnDigit2;
        private System.Windows.Forms.Button btnDigit3;
        private System.Windows.Forms.Button btnDigit4;
        private System.Windows.Forms.Button btnDigit5;
        private System.Windows.Forms.Button btnDigit6;
        private System.Windows.Forms.Button btnDigit7;
        private System.Windows.Forms.Button btnDigit8;
        private System.Windows.Forms.Button btnDigit9;
        private System.Windows.Forms.Button btnDigit0;
        private System.Windows.Forms.Button btnDecimalSeparator;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearCurrent;
    }
}

