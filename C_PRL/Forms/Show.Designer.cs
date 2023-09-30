namespace C_PRL.Forms
{
    partial class Show
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
            this.btn_Show = new System.Windows.Forms.Button();
            this.tbt_Search = new System.Windows.Forms.TextBox();
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(12, 12);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(188, 39);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Hiển thị danh sách";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tbt_Search
            // 
            this.tbt_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_Search.Location = new System.Drawing.Point(385, 12);
            this.tbt_Search.Name = "tbt_Search";
            this.tbt_Search.Size = new System.Drawing.Size(540, 27);
            this.tbt_Search.TabIndex = 1;
            this.tbt_Search.Text = "Nhập để tìm kiếm";
            this.tbt_Search.TextChanged += new System.EventHandler(this.tbt_Search_TextChanged);
            // 
            // dtg_Show
            // 
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(12, 78);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(906, 416);
            this.dtg_Show.TabIndex = 2;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 502);
            this.Controls.Add(this.dtg_Show);
            this.Controls.Add(this.tbt_Search);
            this.Controls.Add(this.btn_Show);
            this.Name = "Show";
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Show;
        private TextBox tbt_Search;
        private DataGridView dtg_Show;
    }
}