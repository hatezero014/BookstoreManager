namespace BookstoreManager
{
    partial class ThemNhaCungCap
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
            this.txbMaNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTenNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgvListNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSDT = new MaterialSkin.Controls.MaterialTextBox();
            this.txbDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThemNCC = new MaterialSkin.Controls.MaterialButton();
            this.btnHuyChonNCC = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaNCC = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMaNCC
            // 
            this.txbMaNCC.AnimateReadOnly = false;
            this.txbMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNCC.Depth = 0;
            this.txbMaNCC.Enabled = false;
            this.txbMaNCC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaNCC.Hint = "Mã NCC";
            this.txbMaNCC.LeadingIcon = null;
            this.txbMaNCC.Location = new System.Drawing.Point(39, 108);
            this.txbMaNCC.MaxLength = 10;
            this.txbMaNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNCC.Multiline = false;
            this.txbMaNCC.Name = "txbMaNCC";
            this.txbMaNCC.Size = new System.Drawing.Size(143, 50);
            this.txbMaNCC.TabIndex = 1;
            this.txbMaNCC.Text = "";
            this.txbMaNCC.TrailingIcon = null;
            // 
            // txbTenNCC
            // 
            this.txbTenNCC.AnimateReadOnly = false;
            this.txbTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNCC.Depth = 0;
            this.txbTenNCC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenNCC.Hint = "Tên nhà cung cấp";
            this.txbTenNCC.LeadingIcon = null;
            this.txbTenNCC.Location = new System.Drawing.Point(39, 175);
            this.txbTenNCC.MaxLength = 50;
            this.txbTenNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenNCC.Multiline = false;
            this.txbTenNCC.Name = "txbTenNCC";
            this.txbTenNCC.Size = new System.Drawing.Size(394, 50);
            this.txbTenNCC.TabIndex = 3;
            this.txbTenNCC.Text = "";
            this.txbTenNCC.TrailingIcon = null;
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
            this.dtgvListNCC.Location = new System.Drawing.Point(472, 108);
            this.dtgvListNCC.Name = "dtgvListNCC";
            this.dtgvListNCC.ReadOnly = true;
            this.dtgvListNCC.RowHeadersWidth = 51;
            this.dtgvListNCC.RowTemplate.Height = 24;
            this.dtgvListNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListNCC.Size = new System.Drawing.Size(558, 386);
            this.dtgvListNCC.TabIndex = 8;
            this.dtgvListNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNCC_CellClick);
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
            // txbSDT
            // 
            this.txbSDT.AnimateReadOnly = false;
            this.txbSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDT.Depth = 0;
            this.txbSDT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDT.Hint = "Số điện thoại";
            this.txbSDT.LeadingIcon = null;
            this.txbSDT.Location = new System.Drawing.Point(200, 108);
            this.txbSDT.MaxLength = 12;
            this.txbSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDT.Multiline = false;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(233, 50);
            this.txbSDT.TabIndex = 2;
            this.txbSDT.Text = "";
            this.txbSDT.TrailingIcon = null;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AnimateReadOnly = false;
            this.txbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiaChi.Depth = 0;
            this.txbDiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDiaChi.Hint = "Địa chỉ";
            this.txbDiaChi.LeadingIcon = null;
            this.txbDiaChi.Location = new System.Drawing.Point(39, 245);
            this.txbDiaChi.MaxLength = 100;
            this.txbDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDiaChi.Multiline = false;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(394, 50);
            this.txbDiaChi.TabIndex = 4;
            this.txbDiaChi.Text = "";
            this.txbDiaChi.TrailingIcon = null;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.AutoSize = false;
            this.btnThemNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemNCC.Depth = 0;
            this.btnThemNCC.HighEmphasis = true;
            this.btnThemNCC.Icon = null;
            this.btnThemNCC.Location = new System.Drawing.Point(330, 321);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNCC.Size = new System.Drawing.Size(103, 36);
            this.btnThemNCC.TabIndex = 7;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNCC.UseAccentColor = false;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
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
            this.btnHuyChonNCC.Location = new System.Drawing.Point(120, 321);
            this.btnHuyChonNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChonNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChonNCC.Name = "btnHuyChonNCC";
            this.btnHuyChonNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChonNCC.Size = new System.Drawing.Size(103, 36);
            this.btnHuyChonNCC.TabIndex = 5;
            this.btnHuyChonNCC.Text = "Huỷ chọn";
            this.btnHuyChonNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChonNCC.UseAccentColor = false;
            this.btnHuyChonNCC.UseVisualStyleBackColor = true;
            this.btnHuyChonNCC.Click += new System.EventHandler(this.btnHuyChonNCC_Click);
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
            this.btnXoaNCC.Location = new System.Drawing.Point(237, 321);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaNCC.Size = new System.Drawing.Size(78, 36);
            this.btnXoaNCC.TabIndex = 6;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaNCC.UseAccentColor = false;
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // ThemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 530);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnHuyChonNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.dtgvListNCC);
            this.Controls.Add(this.txbMaNCC);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbTenNCC);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "ThemNhaCungCap";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Text = "Nhà cung cấp sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txbMaNCC;
        private MaterialSkin.Controls.MaterialTextBox txbTenNCC;
        private System.Windows.Forms.DataGridView dtgvListNCC;
        private MaterialSkin.Controls.MaterialTextBox txbSDT;
        private MaterialSkin.Controls.MaterialTextBox txbDiaChi;
        private MaterialSkin.Controls.MaterialButton btnThemNCC;
        private MaterialSkin.Controls.MaterialButton btnHuyChonNCC;
        private MaterialSkin.Controls.MaterialButton btnXoaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}