
namespace PIKPO_KURSACH
{
    partial class AdminPanel
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
            this.book_catalog = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // book_catalog
            // 
            this.book_catalog.Location = new System.Drawing.Point(12, 82);
            this.book_catalog.Name = "book_catalog";
            this.book_catalog.Size = new System.Drawing.Size(209, 23);
            this.book_catalog.TabIndex = 1;
            this.book_catalog.Text = "Каталог";
            this.book_catalog.UseVisualStyleBackColor = true;
            this.book_catalog.Click += new System.EventHandler(this.book_catalog_Click);
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(13, 112);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(208, 23);
            this.user_button.TabIndex = 2;
            this.user_button.Text = "Все пользователи";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(153, 199);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 234);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.book_catalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button book_catalog;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button exit_button;
    }
}