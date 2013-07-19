namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    partial class SecurIdDialogBox
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
            this.doLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mandant = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.securId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.savePic)).BeginInit();
            this.SuspendLayout();
            // 
            // doLogin
            // 
            this.doLogin.Location = new System.Drawing.Point(12, 289);
            this.doLogin.Name = "doLogin";
            this.doLogin.Size = new System.Drawing.Size(260, 23);
            this.doLogin.TabIndex = 0;
            this.doLogin.Text = "Login";
            this.doLogin.UseVisualStyleBackColor = true;
            this.doLogin.Click += new System.EventHandler(this.DoLoginClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mandant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benutzername:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passwort:";
            // 
            // mandant
            // 
            this.mandant.Location = new System.Drawing.Point(12, 146);
            this.mandant.Name = "mandant";
            this.mandant.Size = new System.Drawing.Size(260, 20);
            this.mandant.TabIndex = 4;
            this.mandant.Text = "tkcpos\r\n";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(12, 185);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(260, 20);
            this.userName.TabIndex = 5;
            this.userName.Text = "tksyr";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 224);
            this.password.Name = "password";
            this.password.PasswordChar = 'X';
            this.password.Size = new System.Drawing.Size(260, 20);
            this.password.TabIndex = 6;
            // 
            // securId
            // 
            this.securId.Location = new System.Drawing.Point(12, 263);
            this.securId.Name = "securId";
            this.securId.PasswordChar = 'X';
            this.securId.Size = new System.Drawing.Size(260, 20);
            this.securId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SecurId:";
            // 
            // savePic
            // 
            this.savePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.savePic.Location = new System.Drawing.Point(0, 0);
            this.savePic.Name = "savePic";
            this.savePic.Size = new System.Drawing.Size(284, 127);
            this.savePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.savePic.TabIndex = 9;
            this.savePic.TabStop = false;
            // 
            // SecurIdDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.savePic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.securId);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.mandant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doLogin);
            this.Name = "SecurIdDialogBox";
            this.Text = "SecurId Login";
            ((System.ComponentModel.ISupportInitialize)(this.savePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button doLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox mandant;
        public System.Windows.Forms.TextBox userName;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox securId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox savePic;
    }
}