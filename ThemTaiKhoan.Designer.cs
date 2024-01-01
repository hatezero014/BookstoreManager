namespace BookstoreManager
{
    partial class ThemTaiKhoan
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
            this.dtgvListTK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTaiKhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuyChon = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.txbMatKhau = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDatLaiMK = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListTK
            // 
            this.dtgvListTK.AllowUserToDeleteRows = false;
            this.dtgvListTK.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtgvListTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvListTK.Location = new System.Drawing.Point(421, 109);
            this.dtgvListTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvListTK.MultiSelect = false;
            this.dtgvListTK.Name = "dtgvListTK";
            this.dtgvListTK.ReadOnly = true;
            this.dtgvListTK.RowHeadersWidth = 51;
            this.dtgvListTK.RowTemplate.Height = 24;
            this.dtgvListTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListTK.Size = new System.Drawing.Size(464, 378);
            this.dtgvListTK.TabIndex = 42;
            this.dtgvListTK.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTK_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tài khoản";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 321;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // txbMaNV
            // 
            this.txbMaNV.AnimateReadOnly = false;
            this.txbMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNV.Depth = 0;
            this.txbMaNV.Enabled = false;
            this.txbMaNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaNV.Hint = "Mã nhân viên";
            this.txbMaNV.LeadingIcon = null;
            this.txbMaNV.Location = new System.Drawing.Point(46, 109);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(311, 50);
            this.txbMaNV.TabIndex = 1;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.AnimateReadOnly = false;
            this.txbTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTaiKhoan.Depth = 0;
            this.txbTaiKhoan.Enabled = false;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTaiKhoan.Hint = "Tài khoản";
            this.txbTaiKhoan.LeadingIcon = null;
            this.txbTaiKhoan.Location = new System.Drawing.Point(46, 180);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTaiKhoan.MaxLength = 50;
            this.txbTaiKhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTaiKhoan.Multiline = false;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(311, 50);
            this.txbTaiKhoan.TabIndex = 2;
            this.txbTaiKhoan.Text = "";
            this.txbTaiKhoan.TrailingIcon = null;
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.AutoSize = false;
            this.btnHuyChon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyChon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChon.Depth = 0;
            this.btnHuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChon.HighEmphasis = true;
            this.btnHuyChon.Icon = null;
            this.btnHuyChon.Location = new System.Drawing.Point(160, 329);
            this.btnHuyChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChon.Size = new System.Drawing.Size(93, 41);
            this.btnHuyChon.TabIndex = 5;
            this.btnHuyChon.Text = "Huỷ chọn";
            this.btnHuyChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChon.UseAccentColor = false;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(276, 329);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(81, 41);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.AnimateReadOnly = false;
            this.txbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMatKhau.Depth = 0;
            this.txbMatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMatKhau.Hint = "Mật khẩu";
            this.txbMatKhau.LeadingIcon = null;
            this.txbMatKhau.Location = new System.Drawing.Point(46, 250);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMatKhau.MaxLength = 50;
            this.txbMatKhau.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(311, 50);
            this.txbMatKhau.TabIndex = 3;
            this.txbMatKhau.Text = "";
            this.txbMatKhau.TrailingIcon = null;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.AutoSize = false;
            this.btnDatLaiMK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDatLaiMK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDatLaiMK.Depth = 0;
            this.btnDatLaiMK.HighEmphasis = true;
            this.btnDatLaiMK.Icon = null;
            this.btnDatLaiMK.Location = new System.Drawing.Point(46, 329);
            this.btnDatLaiMK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDatLaiMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDatLaiMK.Size = new System.Drawing.Size(93, 41);
            this.btnDatLaiMK.TabIndex = 4;
            this.btnDatLaiMK.Text = "Đặt lại";
            this.btnDatLaiMK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDatLaiMK.UseAccentColor = false;
            this.btnDatLaiMK.UseVisualStyleBackColor = true;
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 529);
            this.Controls.Add(this.btnDatLaiMK);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.dtgvListTK);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnXoa);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "ThemTaiKhoan";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lí tài khoản nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialTextBox txbTaiKhoan;
        private MaterialSkin.Controls.MaterialButton btnHuyChon;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialTextBox txbMatKhau;
        private MaterialSkin.Controls.MaterialButton btnDatLaiMK;
    }
}