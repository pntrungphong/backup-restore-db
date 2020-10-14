namespace Backup_Restore
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenDN = new System.Windows.Forms.Label();
            this.btnCN = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Backup_Restore.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1263, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(545, 163);
            this.txtserver.Name = "txtserver";
            this.txtserver.ReadOnly = true;
            this.txtserver.Size = new System.Drawing.Size(406, 40);
            this.txtserver.TabIndex = 61;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(545, 240);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.ReadOnly = true;
            this.txtlogin.Size = new System.Drawing.Size(406, 40);
            this.txtlogin.TabIndex = 62;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(545, 316);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(406, 40);
            this.txtpass.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(311, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 38);
            this.label3.TabIndex = 59;
            this.label3.Text = "Password";
            // 
            // tenDN
            // 
            this.tenDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tenDN.Location = new System.Drawing.Point(311, 240);
            this.tenDN.Name = "tenDN";
            this.tenDN.Size = new System.Drawing.Size(180, 38);
            this.tenDN.TabIndex = 58;
            this.tenDN.Text = "LoginName";
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCN.Location = new System.Drawing.Point(311, 163);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(180, 38);
            this.btnCN.TabIndex = 57;
            this.btnCN.Text = "ServerName ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(716, 459);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(201, 63);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(382, 459);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 63);
            this.btnLogin.TabIndex = 56;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 684);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenDN);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tenDN;
        private System.Windows.Forms.Label btnCN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLogin;
    }
}

