
namespace PIKPO_KURSACH
{
    partial class LoginForm
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(120, 79);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(153, 23);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(120, 108);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(153, 23);
            this.textBox_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(147, 137);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 27);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Вход";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(12, 217);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 4;
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(147, 167);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(95, 27);
            this.registration.TabIndex = 5;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(76, 86);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(41, 15);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(68, 116);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(49, 15);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Пароль";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 241);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Authorization form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        public System.Windows.Forms.TextBox textBox_login;
        public System.Windows.Forms.TextBox textBox_password;
    }
}

