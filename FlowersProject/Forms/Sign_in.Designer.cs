namespace FlowersProject
{
    partial class Sign_in
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
            this.label_Name = new System.Windows.Forms.Button();
            this.textBox_passwordReg = new System.Windows.Forms.TextBox();
            this.textBox_loginReg = new System.Windows.Forms.TextBox();
            this.label_passReg = new System.Windows.Forms.Label();
            this.label_loginReg = new System.Windows.Forms.Label();
            this.linkLabel_ToLog = new System.Windows.Forms.LinkLabel();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_eye = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.Enabled = false;
            this.label_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(140, 26);
            this.label_Name.Name = "label_Name";
            this.label_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Name.Size = new System.Drawing.Size(431, 56);
            this.label_Name.TabIndex = 17;
            this.label_Name.Text = "Регистрация";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Name.UseVisualStyleBackColor = true;
            // 
            // textBox_passwordReg
            // 
            this.textBox_passwordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passwordReg.Location = new System.Drawing.Point(140, 168);
            this.textBox_passwordReg.Multiline = true;
            this.textBox_passwordReg.Name = "textBox_passwordReg";
            this.textBox_passwordReg.Size = new System.Drawing.Size(308, 30);
            this.textBox_passwordReg.TabIndex = 16;
            // 
            // textBox_loginReg
            // 
            this.textBox_loginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_loginReg.Location = new System.Drawing.Point(140, 118);
            this.textBox_loginReg.Multiline = true;
            this.textBox_loginReg.Name = "textBox_loginReg";
            this.textBox_loginReg.Size = new System.Drawing.Size(308, 30);
            this.textBox_loginReg.TabIndex = 15;
            // 
            // label_passReg
            // 
            this.label_passReg.AutoSize = true;
            this.label_passReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_passReg.Location = new System.Drawing.Point(32, 168);
            this.label_passReg.Name = "label_passReg";
            this.label_passReg.Size = new System.Drawing.Size(81, 24);
            this.label_passReg.TabIndex = 13;
            this.label_passReg.Text = "Пароль:";
            // 
            // label_loginReg
            // 
            this.label_loginReg.AutoSize = true;
            this.label_loginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_loginReg.Location = new System.Drawing.Point(46, 118);
            this.label_loginReg.Name = "label_loginReg";
            this.label_loginReg.Size = new System.Drawing.Size(69, 24);
            this.label_loginReg.TabIndex = 12;
            this.label_loginReg.Text = "Логин:";
            // 
            // linkLabel_ToLog
            // 
            this.linkLabel_ToLog.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel_ToLog.AutoSize = true;
            this.linkLabel_ToLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_ToLog.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_ToLog.Location = new System.Drawing.Point(187, 261);
            this.linkLabel_ToLog.Name = "linkLabel_ToLog";
            this.linkLabel_ToLog.Size = new System.Drawing.Size(168, 17);
            this.linkLabel_ToLog.TabIndex = 11;
            this.linkLabel_ToLog.TabStop = true;
            this.linkLabel_ToLog.Text = "У вас уже есть аккаунт?";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SignIn.Location = new System.Drawing.Point(140, 217);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(308, 30);
            this.btn_SignIn.TabIndex = 10;
            this.btn_SignIn.Text = "Войти";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_eye
            // 
            this.btn_eye.Image = global::FlowersProject.Properties.Resources.eye;
            this.btn_eye.Location = new System.Drawing.Point(454, 168);
            this.btn_eye.Name = "btn_eye";
            this.btn_eye.Size = new System.Drawing.Size(30, 30);
            this.btn_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_eye.TabIndex = 18;
            this.btn_eye.TabStop = false;
            this.btn_eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseDown);
            // 
            // icon
            // 
            this.icon.Image = global::FlowersProject.Properties.Resources.reg_icon;
            this.icon.Location = new System.Drawing.Point(8, 26);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(126, 56);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 14;
            this.icon.TabStop = false;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 306);
            this.Controls.Add(this.btn_eye);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_passwordReg);
            this.Controls.Add(this.textBox_loginReg);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label_passReg);
            this.Controls.Add(this.label_loginReg);
            this.Controls.Add(this.linkLabel_ToLog);
            this.Controls.Add(this.btn_SignIn);
            this.MaximumSize = new System.Drawing.Size(595, 345);
            this.MinimumSize = new System.Drawing.Size(595, 345);
            this.Name = "Sign_in";
            this.Text = "sign_in";
            this.Load += new System.EventHandler(this.Sign_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_eye;
        private System.Windows.Forms.Button label_Name;
        private System.Windows.Forms.TextBox textBox_passwordReg;
        private System.Windows.Forms.TextBox textBox_loginReg;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label label_passReg;
        private System.Windows.Forms.Label label_loginReg;
        private System.Windows.Forms.LinkLabel linkLabel_ToLog;
        private System.Windows.Forms.Button btn_SignIn;
    }
}