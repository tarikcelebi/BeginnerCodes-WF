namespace sifreUygulaması
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
            components = new System.ComponentModel.Container();
            txtParola = new TextBox();
            txtSifreDuzeyi = new Label();
            lblInfo = new Label();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // txtParola
            // 
            txtParola.Location = new Point(118, 102);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(358, 23);
            txtParola.TabIndex = 0;
            txtParola.TextChanged += txtParola_TextChanged;
            txtParola.MouseEnter += txtParola_MouseEnter;
            // 
            // txtSifreDuzeyi
            // 
            txtSifreDuzeyi.AutoSize = true;
            txtSifreDuzeyi.Location = new Point(118, 147);
            txtSifreDuzeyi.Name = "txtSifreDuzeyi";
            txtSifreDuzeyi.Size = new Size(0, 15);
            txtSifreDuzeyi.TabIndex = 1;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(124, 77);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 450);
            Controls.Add(lblInfo);
            Controls.Add(txtSifreDuzeyi);
            Controls.Add(txtParola);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParola;
        private Label txtSifreDuzeyi;
        private Label lblInfo;
        private NotifyIcon notifyIcon1;
    }
}