
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
            this.supplier_directory = new System.Windows.Forms.Button();
            this.book_catalog = new System.Windows.Forms.Button();
            this.admission = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supplier_directory
            // 
            this.supplier_directory.Location = new System.Drawing.Point(80, 85);
            this.supplier_directory.Name = "supplier_directory";
            this.supplier_directory.Size = new System.Drawing.Size(209, 23);
            this.supplier_directory.TabIndex = 0;
            this.supplier_directory.Text = "Справочник поставщиков";
            this.supplier_directory.UseVisualStyleBackColor = true;
            this.supplier_directory.Click += new System.EventHandler(this.supplier_directory_Click);
            // 
            // book_catalog
            // 
            this.book_catalog.Location = new System.Drawing.Point(80, 120);
            this.book_catalog.Name = "book_catalog";
            this.book_catalog.Size = new System.Drawing.Size(209, 23);
            this.book_catalog.TabIndex = 1;
            this.book_catalog.Text = "Каталог";
            this.book_catalog.UseVisualStyleBackColor = true;
            this.book_catalog.Click += new System.EventHandler(this.book_catalog_Click);
            // 
            // admission
            // 
            this.admission.Location = new System.Drawing.Point(320, 85);
            this.admission.Name = "admission";
            this.admission.Size = new System.Drawing.Size(209, 23);
            this.admission.TabIndex = 2;
            this.admission.Text = "Поступление";
            this.admission.UseVisualStyleBackColor = true;
            this.admission.Click += new System.EventHandler(this.admission_Click);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(320, 120);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(209, 23);
            this.sale.TabIndex = 3;
            this.sale.Text = "Продажа";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(200, 160);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(209, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 303);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.admission);
            this.Controls.Add(this.book_catalog);
            this.Controls.Add(this.supplier_directory);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button supplier_directory;
        private System.Windows.Forms.Button book_catalog;
        private System.Windows.Forms.Button admission;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button search;
    }
}