
namespace PIKPO_KURSACH.FormsForUserPanel
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.count_books = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_login.Location = new System.Drawing.Point(11, 107);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(70, 15);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Ваш логин:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(11, 126);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 15);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Ваш пароль:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(88, 107);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(34, 15);
            this.login.TabIndex = 2;
            this.login.Text = "login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(88, 126);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // count_books
            // 
            this.count_books.AutoSize = true;
            this.count_books.Location = new System.Drawing.Point(11, 145);
            this.count_books.Name = "count_books";
            this.count_books.Size = new System.Drawing.Size(167, 15);
            this.count_books.TabIndex = 4;
            this.count_books.Text = "Количество купленных книг:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(175, 146);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 15);
            this.count.TabIndex = 5;
            this.count.Text = "0";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(171, 197);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.count);
            this.Controls.Add(this.count_books);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        public System.Windows.Forms.Label login;
        public System.Windows.Forms.Label password;
        private System.Windows.Forms.Label count_books;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}