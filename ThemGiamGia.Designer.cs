namespace BookstoreManager
{
    partial class ThemGiamGia
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
            this.btnThemNCC = new MaterialSkin.Controls.MaterialButton();
            this.btnHuyChonNCC = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaNCC = new MaterialSkin.Controls.MaterialButton();
            this.dtgvListNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbTenSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.AutoSize = false;
            this.btnThemNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemNCC.Depth = 0;
            this.btnThemNCC.HighEmphasis = true;
            this.btnThemNCC.Icon = null;
            this.btnThemNCC.Location = new System.Drawing.Point(332, 450);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNCC.Size = new System.Drawing.Size(103, 36);
            this.btnThemNCC.TabIndex = 15;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNCC.UseAccentColor = false;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            // 
            // btnHuyChonNCC
            // 
            this.btnHuyChonNCC.AutoSize = false;
            this.btnHuyChonNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChonNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyChonNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChonNCC.Depth = 0;
            this.btnHuyChonNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChonNCC.HighEmphasis = true;
            this.btnHuyChonNCC.Icon = null;
            this.btnHuyChonNCC.Location = new System.Drawing.Point(122, 450);
            this.btnHuyChonNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChonNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChonNCC.Name = "btnHuyChonNCC";
            this.btnHuyChonNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChonNCC.Size = new System.Drawing.Size(103, 36);
            this.btnHuyChonNCC.TabIndex = 13;
            this.btnHuyChonNCC.Text = "Huỷ chọn";
            this.btnHuyChonNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChonNCC.UseAccentColor = false;
            this.btnHuyChonNCC.UseVisualStyleBackColor = true;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.AutoSize = false;
            this.btnXoaNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaNCC.Depth = 0;
            this.btnXoaNCC.Enabled = false;
            this.btnXoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.HighEmphasis = true;
            this.btnXoaNCC.Icon = null;
            this.btnXoaNCC.Location = new System.Drawing.Point(239, 450);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaNCC.Size = new System.Drawing.Size(78, 36);
            this.btnXoaNCC.TabIndex = 14;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaNCC.UseAccentColor = false;
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            // 
            // dtgvListNCC
            // 
            this.dtgvListNCC.AllowUserToDeleteRows = false;
            this.dtgvListNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvListNCC.Location = new System.Drawing.Point(477, 100);
            this.dtgvListNCC.Name = "dtgvListNCC";
            this.dtgvListNCC.ReadOnly = true;
            this.dtgvListNCC.RowHeadersWidth = 51;
            this.dtgvListNCC.RowTemplate.Height = 24;
            this.dtgvListNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListNCC.Size = new System.Drawing.Size(558, 386);
            this.dtgvListNCC.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // txbTenSach
            // 
            this.txbTenSach.AnimateReadOnly = false;
            this.txbTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenSach.Depth = 0;
            this.txbTenSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenSach.Hint = "Tên sách";
            this.txbTenSach.LeadingIcon = null;
            this.txbTenSach.Location = new System.Drawing.Point(59, 168);
            this.txbTenSach.MaxLength = 100;
            this.txbTenSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenSach.Multiline = false;
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(229, 50);
            this.txbTenSach.TabIndex = 17;
            this.txbTenSach.Text = "";
            this.txbTenSach.TrailingIcon = null;
            // 
            // txbMaSach
            // 
            this.txbMaSach.AnimateReadOnly = false;
            this.txbMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaSach.Depth = 0;
            this.txbMaSach.Enabled = false;
            this.txbMaSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaSach.Hint = "Mã sách";
            this.txbMaSach.LeadingIcon = null;
            this.txbMaSach.Location = new System.Drawing.Point(59, 100);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(229, 50);
            this.txbMaSach.TabIndex = 18;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
            // 
            // ThemGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 572);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.txbMaSach);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnHuyChonNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.dtgvListNCC);
            this.Name = "ThemGiamGia";
            this.Text = "Giảm giá sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnThemNCC;
        private MaterialSkin.Controls.MaterialButton btnHuyChonNCC;
        private MaterialSkin.Controls.MaterialButton btnXoaNCC;
        private System.Windows.Forms.DataGridView dtgvListNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialTextBox txbTenSach;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
    }
}