namespace FlowersProject
{
    partial class Log_in
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
            this.linkLabel_reg = new System.Windows.Forms.LinkLabel();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.Location = new System.Drawing.Point(139, 203);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(308, 30);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linkLabel_reg
            // 
            this.linkLabel_reg.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel_reg.AutoSize = true;
            this.linkLabel_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_reg.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_reg.Location = new System.Drawing.Point(201, 247);
            this.linkLabel_reg.Name = "linkLabel_reg";
            this.linkLabel_reg.Size = new System.Drawing.Size(187, 20);
            this.linkLabel_reg.TabIndex = 1;
            this.linkLabel_reg.TabStop = true;
            this.linkLabel_reg.Text = "Зарегистрироваться";
            this.linkLabel_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_reg_LinkClicked);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(45, 104);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(88, 29);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Логин:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(31, 154);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(102, 29);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(139, 104);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(308, 30);
            this.textBox_login.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(139, 154);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(308, 30);
            this.textBox_password.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(139, 12);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(431, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Авторизация";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlowersProject.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_eye
            // 
            this.btn_eye.Image = global::FlowersProject.Properties.Resources.eye;
            this.btn_eye.Location = new System.Drawing.Point(453, 154);
            this.btn_eye.Name = "btn_eye";
            this.btn_eye.Size = new System.Drawing.Size(30, 30);
            this.btn_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_eye.TabIndex = 9;
            this.btn_eye.TabStop = false;
            this.btn_eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseDown);
            this.btn_eye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_eye_MouseUp);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 298);
            this.Controls.Add(this.btn_eye);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.linkLabel_reg);
            this.Controls.Add(this.btn_login);
            this.MaximumSize = new System.Drawing.Size(595, 345);
            this.MinimumSize = new System.Drawing.Size(595, 345);
            this.Name = "Log_in";
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkLabel_reg;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox btn_eye;
    }
}