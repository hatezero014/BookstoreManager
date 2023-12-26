namespace BookstoreManager
{
    partial class ThemTheLoaiSach
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
            this.txbMaLS = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTenLS = new MaterialSkin.Controls.MaterialTextBox();
            this.btnXoaLS = new MaterialSkin.Controls.MaterialButton();
            this.btnActionLS = new MaterialSkin.Controls.MaterialButton();
            this.dtgvListLS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyChonLS = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLS)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMaLS
            // 
            this.txbMaLS.AnimateReadOnly = false;
            this.txbMaLS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaLS.Depth = 0;
            this.txbMaLS.Enabled = false;
            this.txbMaLS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaLS.Hint = "Mã thể loại";
            this.txbMaLS.LeadingIcon = null;
            this.txbMaLS.Location = new System.Drawing.Point(58, 164);
            this.txbMaLS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaLS.MaxLength = 50;
            this.txbMaLS.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaLS.Multiline = false;
            this.txbMaLS.Name = "txbMaLS";
            this.txbMaLS.Size = new System.Drawing.Size(477, 50);
            this.txbMaLS.TabIndex = 1;
            this.txbMaLS.Text = "";
            this.txbMaLS.TrailingIcon = null;
            // 
            // txbTenLS
            // 
            this.txbTenLS.AnimateReadOnly = false;
            this.txbTenLS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenLS.Depth = 0;
            this.txbTenLS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenLS.Hint = "Tên thể loại";
            this.txbTenLS.LeadingIcon = null;
            this.txbTenLS.Location = new System.Drawing.Point(58, 273);
            this.txbTenLS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenLS.MaxLength = 50;
            this.txbTenLS.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenLS.Multiline = false;
            this.txbTenLS.Name = "txbTenLS";
            this.txbTenLS.Size = new System.Drawing.Size(477, 50);
            this.txbTenLS.TabIndex = 2;
            this.txbTenLS.Text = "";
            this.txbTenLS.TrailingIcon = null;
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.AutoSize = false;
            this.btnXoaLS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaLS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaLS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaLS.Depth = 0;
            this.btnXoaLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLS.HighEmphasis = true;
            this.btnXoaLS.Icon = null;
            this.btnXoaLS.Location = new System.Drawing.Point(130, 397);
            this.btnXoaLS.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnXoaLS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaLS.Size = new System.Drawing.Size(105, 56);
            this.btnXoaLS.TabIndex = 25;
            this.btnXoaLS.Text = "Xoá";
            this.btnXoaLS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaLS.UseAccentColor = false;
            this.btnXoaLS.UseVisualStyleBackColor = true;
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // btnActionLS
            // 
            this.btnActionLS.AutoSize = false;
            this.btnActionLS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActionLS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActionLS.Depth = 0;
            this.btnActionLS.HighEmphasis = true;
            this.btnActionLS.Icon = null;
            this.btnActionLS.Location = new System.Drawing.Point(400, 397);
            this.btnActionLS.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnActionLS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActionLS.Name = "btnActionLS";
            this.btnActionLS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActionLS.Size = new System.Drawing.Size(135, 56);
            this.btnActionLS.TabIndex = 29;
            this.btnActionLS.Text = "Cập nhật";
            this.btnActionLS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActionLS.UseAccentColor = false;
            this.btnActionLS.UseVisualStyleBackColor = true;
            this.btnActionLS.TextChanged += new System.EventHandler(this.btnActionLS_TextChanged);
            this.btnActionLS.Click += new System.EventHandler(this.btnActionLS_Click);
            // 
            // dtgvListLS
            // 
            this.dtgvListLS.AllowUserToDeleteRows = false;
            this.dtgvListLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvListLS.Location = new System.Drawing.Point(610, 164);
            this.dtgvListLS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListLS.MultiSelect = false;
            this.dtgvListLS.Name = "dtgvListLS";
            this.dtgvListLS.ReadOnly = true;
            this.dtgvListLS.RowHeadersWidth = 51;
            this.dtgvListLS.RowTemplate.Height = 24;
            this.dtgvListLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListLS.Size = new System.Drawing.Size(681, 578);
            this.dtgvListLS.TabIndex = 3;
            this.dtgvListLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListLS_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thể loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên thể loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 275;
            // 
            // btnHuyChonLS
            // 
            this.btnHuyChonLS.AutoSize = false;
            this.btnHuyChonLS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChonLS.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuyChonLS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyChonLS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChonLS.Depth = 0;
            this.btnHuyChonLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChonLS.HighEmphasis = true;
            this.btnHuyChonLS.Icon = null;
            this.btnHuyChonLS.Location = new System.Drawing.Point(258, 397);
            this.btnHuyChonLS.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHuyChonLS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChonLS.Name = "btnHuyChonLS";
            this.btnHuyChonLS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChonLS.Size = new System.Drawing.Size(120, 56);
            this.btnHuyChonLS.TabIndex = 31;
            this.btnHuyChonLS.Text = "Hủy chọn";
            this.btnHuyChonLS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChonLS.UseAccentColor = false;
            this.btnHuyChonLS.UseVisualStyleBackColor = false;
            this.btnHuyChonLS.Click += new System.EventHandler(this.btnHuyChonLS_Click);
            // 
            // ThemTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 802);
            this.Controls.Add(this.btnHuyChonLS);
            this.Controls.Add(this.dtgvListLS);
            this.Controls.Add(this.btnActionLS);
            this.Controls.Add(this.txbMaLS);
            this.Controls.Add(this.txbTenLS);
            this.Controls.Add(this.btnXoaLS);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemTheLoaiSach";
            this.Padding = new System.Windows.Forms.Padding(4, 112, 4, 5);
            this.Text = "Thể loại sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txbMaLS;
        private MaterialSkin.Controls.MaterialTextBox txbTenLS;
        private MaterialSkin.Controls.MaterialButton btnXoaLS;
        private MaterialSkin.Controls.MaterialButton btnActionLS;
        private System.Windows.Forms.DataGridView dtgvListLS;
        private MaterialSkin.Controls.MaterialButton btnHuyChonLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}