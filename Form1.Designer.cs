namespace ATM
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
            panelCommon = new Panel();
            panelLogin = new Panel();
            txtPin = new TextBox();
            label2 = new Label();
            lblHeading = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnEnter = new Button();
            btn7 = new Button();
            btnClear = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            txtAccNo = new TextBox();
            label1 = new Label();
            lblError = new Label();
            panelCommon.SuspendLayout();
            panelLogin.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCommon
            // 
            panelCommon.Controls.Add(panelLogin);
            panelCommon.Location = new Point(5, 6);
            panelCommon.Margin = new Padding(4);
            panelCommon.Name = "panelCommon";
            panelCommon.Size = new Size(929, 883);
            panelCommon.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(192, 255, 255);
            panelLogin.Controls.Add(lblError);
            panelLogin.Controls.Add(txtPin);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(lblHeading);
            panelLogin.Controls.Add(tableLayoutPanel1);
            panelLogin.Controls.Add(txtAccNo);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(-4, -8);
            panelLogin.Margin = new Padding(4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(936, 900);
            panelLogin.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPin.Location = new Point(470, 190);
            txtPin.Margin = new Padding(4);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(352, 57);
            txtPin.TabIndex = 7;
            txtPin.UseSystemPasswordChar = true;
            txtPin.Enter += txtPin_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MinimumSize = new Size(360, 0);
            label2.Name = "label2";
            label2.Size = new Size(360, 51);
            label2.TabIndex = 6;
            label2.Text = "Enter PIN Code:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Blue;
            lblHeading.Location = new Point(2, 19);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.MinimumSize = new Size(900, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(900, 57);
            lblHeading.TabIndex = 5;
            lblHeading.Text = "MyBank ATM Machine";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btnEnter, 2, 3);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 3);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Location = new Point(108, 268);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Size = new Size(720, 480);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(244, 364);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(232, 112);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberKey_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(484, 244);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(232, 112);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberKey_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(244, 244);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(232, 112);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberKey_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Lime;
            btnEnter.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(484, 364);
            btnEnter.Margin = new Padding(4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(232, 112);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(4, 244);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(232, 112);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberKey_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(4, 364);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(232, 112);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(484, 124);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(232, 112);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberKey_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(244, 124);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(232, 112);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberKey_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(4, 124);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(232, 112);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberKey_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(484, 4);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(232, 112);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberKey_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(244, 4);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(232, 112);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberKey_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(4, 4);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(232, 112);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberKey_Click;
            // 
            // txtAccNo
            // 
            txtAccNo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccNo.Location = new Point(476, 109);
            txtAccNo.Margin = new Padding(4);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.Size = new Size(352, 57);
            txtAccNo.TabIndex = 1;
            txtAccNo.Enter += txtAccNo_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(360, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 51);
            label1.TabIndex = 0;
            label1.Text = "Enter Account No:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(11, 771);
            lblError.MinimumSize = new Size(900, 100);
            lblError.Name = "lblError";
            lblError.Size = new Size(900, 100);
            lblError.TabIndex = 8;
            lblError.Text = "label3";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 893);
            Controls.Add(panelCommon);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ATM";
            panelCommon.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCommon;
        private Panel panelLogin;
        private TextBox txtPin;
        private Label label2;
        private Label lblHeading;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btnEnter;
        private Button btn7;
        private Button btnClear;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox txtAccNo;
        private Label label1;
        private Label lblError;
    }
}
