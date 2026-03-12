namespace qlsv
{
    partial class form_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tt_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(155, 139);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(77, 34);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_username.Location = new System.Drawing.Point(124, 60);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(211, 20);
            this.tbx_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(34, 67);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 13);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Tên đăng nhập:";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(34, 103);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(55, 13);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật khẩu:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(124, 96);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(211, 20);
            this.tbx_password.TabIndex = 1;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            // 
            // tt_login
            // 
            this.tt_login.AutoSize = true;
            this.tt_login.BackColor = System.Drawing.SystemColors.Control;
            this.tt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tt_login.Location = new System.Drawing.Point(142, 18);
            this.tt_login.Name = "tt_login";
            this.tt_login.Size = new System.Drawing.Size(103, 24);
            this.tt_login.TabIndex = 3;
            this.tt_login.Text = "Đăng nhập";
            this.tt_login.Click += new System.EventHandler(this.label3_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 185);
            this.Controls.Add(this.tt_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.btn_login);
            this.Name = "form_login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label tt_login;
        private System.Windows.Forms.Button btn_login;
    }
}

