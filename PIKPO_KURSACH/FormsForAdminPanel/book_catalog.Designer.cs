
namespace PIKPO_KURSACH.FormsFromAdminPanel
{
    partial class book_catalog
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
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(12, 43);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowTemplate.Height = 25;
            this.dgvViewer.Size = new System.Drawing.Size(704, 398);
            this.dgvViewer.TabIndex = 0;
            this.dgvViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewer_CellContentClick);
            this.dgvViewer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewer_CellValueChanged);
            this.dgvViewer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvViewer_EditingControlShowing);
            this.dgvViewer.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvViewer_UserAddedRow);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_exit.Location = new System.Drawing.Point(641, 448);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_search.Location = new System.Drawing.Point(12, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(127, 23);
            this.textBox_search.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_search.Location = new System.Drawing.Point(143, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // book_catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 483);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgvViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "book_catalog";
            this.Text = "Book Catalog";
            this.Load += new System.EventHandler(this.book_catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}