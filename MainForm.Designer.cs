namespace ATM
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
            panelMain = new Panel();
            lblDate = new Label();
            txtAmt = new TextBox();
            btnExit = new Button();
            btnConfirm = new Button();
            btnReceipt = new Button();
            btnWithdraw = new Button();
            btnBalance = new Button();
            lblOutput = new Label();
            lblHeading = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.AppWorkspace;
            panelMain.Controls.Add(lblDate);
            panelMain.Controls.Add(txtAmt);
            panelMain.Controls.Add(btnExit);
            panelMain.Controls.Add(btnConfirm);
            panelMain.Controls.Add(btnReceipt);
            panelMain.Controls.Add(btnWithdraw);
            panelMain.Controls.Add(btnBalance);
            panelMain.Controls.Add(lblOutput);
            panelMain.Controls.Add(lblHeading);
            panelMain.Location = new Point(0, 1);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(938, 895);
            panelMain.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(444, 144);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.MinimumSize = new Size(420, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(420, 60);
            lblDate.TabIndex = 8;
            lblDate.Text = "23-05-2026 2:35 PM";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAmt
            // 
            txtAmt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmt.Location = new Point(288, 380);
            txtAmt.Margin = new Padding(4);
            txtAmt.MaximumSize = new Size(359, 50);
            txtAmt.MinimumSize = new Size(239, 50);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(359, 50);
            txtAmt.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(487, 731);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(242, 86);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(197, 731);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(242, 86);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(197, 620);
            btnReceipt.Margin = new Padding(4);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(533, 86);
            btnReceipt.TabIndex = 4;
            btnReceipt.Text = "Withdraw with Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(487, 499);
            btnWithdraw.Margin = new Padding(4);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(242, 86);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "WITHDRAW";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnBalance
            // 
            btnBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalance.Location = new Point(197, 499);
            btnBalance.Margin = new Padding(4);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(242, 86);
            btnBalance.TabIndex = 2;
            btnBalance.Text = "BALANCE";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.Black;
            lblOutput.Location = new Point(12, 240);
            lblOutput.Margin = new Padding(4, 0, 4, 0);
            lblOutput.MinimumSize = new Size(912, 120);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(912, 120);
            lblOutput.TabIndex = 1;
            lblOutput.Text = "Enter Amt (or) Withdraw Success";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Blue;
            lblHeading.Location = new Point(7, 7);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.MinimumSize = new Size(912, 120);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(912, 120);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "WELCOME Mr. Smith";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 893);
            Controls.Add(panelMain);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnExit;
        private Button btnConfirm;
        private Button btnReceipt;
        private Button btnWithdraw;
        private Button btnBalance;
        private Label lblOutput;
        private Label lblHeading;
        private TextBox txtAmt;
        private Label lblDate;
    }
}