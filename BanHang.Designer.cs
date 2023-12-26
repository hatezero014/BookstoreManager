namespace BookstoreManager
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.dtgvCTBH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbMaHD = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDTKH = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThanhToan = new MaterialSkin.Controls.MaterialButton();
            this.lbThanhTien = new MaterialSkin.Controls.MaterialLabel();
            this.btnHuyBo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThemSach = new MaterialSkin.Controls.MaterialButton();
            this.txbThanhTien = new MaterialSkin.Controls.MaterialTextBox();
            this.txbDonGia = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSLKho = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSLBan = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuyChon = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.txbNgayTao = new MaterialSkin.Controls.MaterialTextBox();
            this.btnInHD = new MaterialSkin.Controls.MaterialButton();
            this.cbListSach = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTBH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCTBH
            // 
            this.dtgvCTBH.AllowUserToDeleteRows = false;
            this.dtgvCTBH.AllowUserToOrderColumns = true;
            this.dtgvCTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvCTBH.Location = new System.Drawing.Point(50, 245);
            this.dtgvCTBH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvCTBH.Name = "dtgvCTBH";
            this.dtgvCTBH.ReadOnly = true;
            this.dtgvCTBH.RowHeadersWidth = 51;
            this.dtgvCTBH.RowTemplate.Height = 24;
            this.dtgvCTBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCTBH.Size = new System.Drawing.Size(1298, 936);
            this.dtgvCTBH.TabIndex = 0;
            this.dtgvCTBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTBH_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // txbMaHD
            // 
            this.txbMaHD.AnimateReadOnly = false;
            this.txbMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaHD.Depth = 0;
            this.txbMaHD.Enabled = false;
            this.txbMaHD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaHD.Hint = "Mã hoá đơn";
            this.txbMaHD.LeadingIcon = null;
            this.txbMaHD.Location = new System.Drawing.Point(50, 138);
            this.txbMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaHD.MaxLength = 50;
            this.txbMaHD.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaHD.Multiline = false;
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(208, 50);
            this.txbMaHD.TabIndex = 1;
            this.txbMaHD.Text = "";
            this.txbMaHD.TrailingIcon = null;
            // 
            // txbSDTKH
            // 
            this.txbSDTKH.AnimateReadOnly = false;
            this.txbSDTKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDTKH.Depth = 0;
            this.txbSDTKH.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDTKH.Hint = "SĐT khách hàng";
            this.txbSDTKH.LeadingIcon = null;
            this.txbSDTKH.Location = new System.Drawing.Point(754, 138);
            this.txbSDTKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSDTKH.MaxLength = 50;
            this.txbSDTKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDTKH.Multiline = false;
            this.txbSDTKH.Name = "txbSDTKH";
            this.txbSDTKH.Size = new System.Drawing.Size(216, 50);
            this.txbSDTKH.TabIndex = 2;
            this.txbSDTKH.Text = "";
            this.txbSDTKH.TrailingIcon = null;
            this.txbSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDTKH_KeyPress);
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
            this.txbMaNV.Location = new System.Drawing.Point(514, 138);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(216, 50);
            this.txbMaNV.TabIndex = 2;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(1401, 984);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Thành tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = false;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThanhToan.Depth = 0;
            this.btnThanhToan.HighEmphasis = true;
            this.btnThanhToan.Icon = null;
            this.btnThanhToan.Location = new System.Drawing.Point(1407, 1050);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Size = new System.Drawing.Size(513, 56);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThanhToan.UseAccentColor = false;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Depth = 0;
            this.lbThanhTien.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbThanhTien.Location = new System.Drawing.Point(1818, 986);
            this.lbThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThanhTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(10, 19);
            this.lbThanhTien.TabIndex = 11;
            this.lbThanhTien.Text = "0";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AutoSize = false;
            this.btnHuyBo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyBo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyBo.Depth = 0;
            this.btnHuyBo.HighEmphasis = true;
            this.btnHuyBo.Icon = null;
            this.btnHuyBo.Location = new System.Drawing.Point(1407, 1125);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHuyBo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyBo.Size = new System.Drawing.Size(513, 56);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyBo.UseAccentColor = false;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(1408, 267);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(299, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Nhập thông tin sách để thêm vào hoá đơn";
            // 
            // btnThemSach
            // 
            this.btnThemSach.AutoSize = false;
            this.btnThemSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemSach.Depth = 0;
            this.btnThemSach.HighEmphasis = true;
            this.btnThemSach.Icon = null;
            this.btnThemSach.Location = new System.Drawing.Point(1764, 761);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnThemSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemSach.Size = new System.Drawing.Size(156, 56);
            this.btnThemSach.TabIndex = 38;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemSach.UseAccentColor = false;
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click_1);
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.AnimateReadOnly = false;
            this.txbThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbThanhTien.Depth = 0;
            this.txbThanhTien.Enabled = false;
            this.txbThanhTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbThanhTien.Hint = "Thành tiền";
            this.txbThanhTien.LeadingIcon = null;
            this.txbThanhTien.Location = new System.Drawing.Point(1407, 642);
            this.txbThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbThanhTien.MaxLength = 50;
            this.txbThanhTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txbThanhTien.Multiline = false;
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.Size = new System.Drawing.Size(513, 50);
            this.txbThanhTien.TabIndex = 35;
            this.txbThanhTien.Text = "";
            this.txbThanhTien.TrailingIcon = null;
            // 
            // txbDonGia
            // 
            this.txbDonGia.AnimateReadOnly = false;
            this.txbDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDonGia.Depth = 0;
            this.txbDonGia.Enabled = false;
            this.txbDonGia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDonGia.Hint = "Đơn giá";
            this.txbDonGia.LeadingIcon = null;
            this.txbDonGia.Location = new System.Drawing.Point(1407, 538);
            this.txbDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDonGia.MaxLength = 50;
            this.txbDonGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDonGia.Multiline = false;
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(260, 50);
            this.txbDonGia.TabIndex = 34;
            this.txbDonGia.Text = "";
            this.txbDonGia.TrailingIcon = null;
            this.txbDonGia.TextChanged += new System.EventHandler(this.txbDonGia_TextChanged_1);
            this.txbDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGia_KeyPress);
            // 
            // txbSLKho
            // 
            this.txbSLKho.AnimateReadOnly = false;
            this.txbSLKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLKho.Depth = 0;
            this.txbSLKho.Enabled = false;
            this.txbSLKho.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSLKho.Hint = "Kho";
            this.txbSLKho.LeadingIcon = null;
            this.txbSLKho.Location = new System.Drawing.Point(1692, 334);
            this.txbSLKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSLKho.MaxLength = 50;
            this.txbSLKho.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSLKho.Multiline = false;
            this.txbSLKho.Name = "txbSLKho";
            this.txbSLKho.Size = new System.Drawing.Size(228, 50);
            this.txbSLKho.TabIndex = 36;
            this.txbSLKho.Text = "";
            this.txbSLKho.TrailingIcon = null;
            // 
            // txbSLBan
            // 
            this.txbSLBan.AnimateReadOnly = false;
            this.txbSLBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLBan.Depth = 0;
            this.txbSLBan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSLBan.Hint = "Số lượng";
            this.txbSLBan.LeadingIcon = null;
            this.txbSLBan.Location = new System.Drawing.Point(1692, 538);
            this.txbSLBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSLBan.MaxLength = 50;
            this.txbSLBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSLBan.Multiline = false;
            this.txbSLBan.Name = "txbSLBan";
            this.txbSLBan.Size = new System.Drawing.Size(228, 50);
            this.txbSLBan.TabIndex = 37;
            this.txbSLBan.Text = "";
            this.txbSLBan.TrailingIcon = null;
            this.txbSLBan.TextChanged += new System.EventHandler(this.txbSLBan_TextChanged);
            this.txbSLBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSLNhap_KeyPress);
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
            this.txbMaSach.Location = new System.Drawing.Point(1407, 334);
            this.txbMaSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(260, 50);
            this.txbMaSach.TabIndex = 32;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
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
            this.btnHuyChon.Location = new System.Drawing.Point(1582, 761);
            this.btnHuyChon.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHuyChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChon.Size = new System.Drawing.Size(156, 56);
            this.btnHuyChon.TabIndex = 31;
            this.btnHuyChon.Text = "Huỷ chọn";
            this.btnHuyChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChon.UseAccentColor = false;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click_1);
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
            this.btnXoa.Location = new System.Drawing.Point(1407, 761);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(152, 56);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txbNgayTao
            // 
            this.txbNgayTao.AnimateReadOnly = false;
            this.txbNgayTao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgayTao.Depth = 0;
            this.txbNgayTao.Enabled = false;
            this.txbNgayTao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgayTao.Hint = "Ngày";
            this.txbNgayTao.LeadingIcon = null;
            this.txbNgayTao.Location = new System.Drawing.Point(282, 138);
            this.txbNgayTao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNgayTao.MaxLength = 50;
            this.txbNgayTao.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgayTao.Multiline = false;
            this.txbNgayTao.Name = "txbNgayTao";
            this.txbNgayTao.Size = new System.Drawing.Size(210, 50);
            this.txbNgayTao.TabIndex = 40;
            this.txbNgayTao.Text = "";
            this.txbNgayTao.TrailingIcon = null;
            // 
            // btnInHD
            // 
            this.btnInHD.AutoSize = false;
            this.btnInHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInHD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInHD.Depth = 0;
            this.btnInHD.HighEmphasis = true;
            this.btnInHD.Icon = ((System.Drawing.Image)(resources.GetObject("btnInHD.Icon")));
            this.btnInHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInHD.Location = new System.Drawing.Point(1690, 148);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnInHD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInHD.Size = new System.Drawing.Size(230, 67);
            this.btnInHD.TabIndex = 51;
            this.btnInHD.Text = "In hoá đơn";
            this.btnInHD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInHD.UseAccentColor = false;
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // cbListSach
            // 
            this.cbListSach.AutoResize = false;
            this.cbListSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbListSach.Depth = 0;
            this.cbListSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbListSach.DropDownHeight = 174;
            this.cbListSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListSach.DropDownWidth = 121;
            this.cbListSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbListSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbListSach.FormattingEnabled = true;
            this.cbListSach.Hint = "Tên sách";
            this.cbListSach.IntegralHeight = false;
            this.cbListSach.ItemHeight = 43;
            this.cbListSach.Location = new System.Drawing.Point(1407, 437);
            this.cbListSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbListSach.MaxDropDownItems = 4;
            this.cbListSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbListSach.Name = "cbListSach";
            this.cbListSach.Size = new System.Drawing.Size(511, 49);
            this.cbListSach.StartIndex = 0;
            this.cbListSach.TabIndex = 52;
            this.cbListSach.SelectedIndexChanged += new System.EventHandler(this.cbListSach_SelectedIndexChanged);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1239);
            this.Controls.Add(this.cbListSach);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.txbNgayTao);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txbThanhTien);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.txbSLKho);
            this.Controls.Add(this.txbSLBan);
            this.Controls.Add(this.txbMaSach);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbSDTKH);
            this.Controls.Add(this.txbMaHD);
            this.Controls.Add(this.dtgvCTBH);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BanHang";
            this.Padding = new System.Windows.Forms.Padding(4, 100, 4, 5);
            this.Text = "Tạo hoá đơn bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCTBH;
        private MaterialSkin.Controls.MaterialTextBox txbMaHD;
        private MaterialSkin.Controls.MaterialTextBox txbSDTKH;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnThanhToan;
        private MaterialSkin.Controls.MaterialLabel lbThanhTien;
        private MaterialSkin.Controls.MaterialButton btnHuyBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnThemSach;
        private MaterialSkin.Controls.MaterialTextBox txbThanhTien;
        private MaterialSkin.Controls.MaterialTextBox txbDonGia;
        private MaterialSkin.Controls.MaterialTextBox txbSLKho;
        private MaterialSkin.Controls.MaterialTextBox txbSLBan;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
        private MaterialSkin.Controls.MaterialButton btnHuyChon;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialTextBox txbNgayTao;
        private MaterialSkin.Controls.MaterialButton btnInHD;
        private MaterialSkin.Controls.MaterialComboBox cbListSach;
    }
}