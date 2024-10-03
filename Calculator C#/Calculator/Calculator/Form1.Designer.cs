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
            txtTotal = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnPlus = new Button();
            btnDiv = new Button();
            btnMin = new Button();
            btnMul = new Button();
            btnEql = new Button();
            button1 = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 30F);
            txtTotal.Location = new Point(12, 43);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(494, 74);
            txtTotal.TabIndex = 0;
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 30F);
            btn7.Location = new Point(12, 149);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 78);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 30F);
            btn8.Location = new Point(112, 149);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 78);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 30F);
            btn9.Location = new Point(212, 149);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 78);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 30F);
            btn4.Location = new Point(12, 233);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 78);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 30F);
            btn5.Location = new Point(112, 233);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 78);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 30F);
            btn6.Location = new Point(212, 233);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 78);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 30F);
            btn1.Location = new Point(12, 317);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 78);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 30F);
            btn2.Location = new Point(112, 317);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 78);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 30F);
            btn3.Location = new Point(212, 317);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 78);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 30F);
            btn0.Location = new Point(12, 401);
            btn0.Name = "btn0";
            btn0.Size = new Size(194, 78);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 30F);
            btndot.Location = new Point(212, 401);
            btndot.Name = "btndot";
            btndot.Size = new Size(94, 78);
            btndot.TabIndex = 11;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 30F);
            btnPlus.Location = new Point(312, 401);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 78);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 30F);
            btnDiv.Location = new Point(312, 149);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 78);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 30F);
            btnMin.Location = new Point(312, 317);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(94, 78);
            btnMin.TabIndex = 14;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 30F);
            btnMul.Location = new Point(312, 233);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(94, 78);
            btnMul.TabIndex = 15;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 30F);
            btnEql.Location = new Point(412, 317);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(94, 162);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(412, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 78);
            button1.TabIndex = 18;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 30F);
            btnClear.Location = new Point(412, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 78);
            btnClear.TabIndex = 17;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 501);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnEql);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnDiv);
            Controls.Add(btnPlus);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btndot;
        private Button btnPlus;
        private Button btnDiv;
        private Button btnMin;
        private Button btnMul;
        private Button btnEql;
        private Button button1;
        private Button btnClear;
    }
}
