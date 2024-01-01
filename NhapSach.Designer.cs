namespace BookstoreManager
{
    partial class NhapSach
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
            this.lbTongThanhToan = new MaterialSkin.Controls.MaterialLabel();
            this.btnHuyHoaDon = new MaterialSkin.Controls.MaterialButton();
            this.btnDone = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThemSach = new MaterialSkin.Controls.MaterialButton();
            this.txbThanhTien = new MaterialSkin.Controls.MaterialTextBox();
            this.txbDonGia = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSLNhap = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuyChon = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaSach = new MaterialSkin.Controls.MaterialButton();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaHD = new MaterialSkin.Controls.MaterialTextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCTNS = new System.Windows.Forms.DataGridView();
            this.txbSLKho = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbListSach = new MaterialSkin.Controls.MaterialComboBox();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbNgayTao = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTNS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTongThanhToan
            // 
            this.lbTongThanhToan.AutoSize = true;
            this.lbTongThanhToan.Depth = 0;
            this.lbTongThanhToan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTongThanhToan.Location = new System.Drawing.Point(1211, 620);
            this.lbTongThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTongThanhToan.Name = "lbTongThanhToan";
            this.lbTongThanhToan.Size = new System.Drawing.Size(10, 19);
            this.lbTongThanhToan.TabIndex = 28;
            this.lbTongThanhToan.Text = "0";
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.AutoSize = false;
            this.btnHuyHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyHoaDon.Depth = 0;
            this.btnHuyHoaDon.HighEmphasis = true;
            this.btnHuyHoaDon.Icon = null;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(956, 725);
            this.btnHuyHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyHoaDon.Size = new System.Drawing.Size(342, 44);
            this.btnHuyHoaDon.TabIndex = 12;
            this.btnHuyHoaDon.Text = "Huỷ bỏ";
            this.btnHuyHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyHoaDon.UseAccentColor = false;
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = false;
            this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDone.Depth = 0;
            this.btnDone.HighEmphasis = true;
            this.btnDone.Icon = null;
            this.btnDone.Location = new System.Drawing.Point(956, 669);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDone.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDone.Name = "btnDone";
            this.btnDone.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDone.Size = new System.Drawing.Size(342, 44);
            this.btnDone.TabIndex = 11;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDone.UseAccentColor = false;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(958, 616);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 24);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Thanh toán";
            // 
            // btnThemSach
            // 
            this.btnThemSach.AutoSize = false;
            this.btnThemSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemSach.Depth = 0;
            this.btnThemSach.HighEmphasis = true;
            this.btnThemSach.Icon = null;
            this.btnThemSach.Location = new System.Drawing.Point(956, 496);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemSach.Size = new System.Drawing.Size(104, 40);
            this.btnThemSach.TabIndex = 10;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemSach.UseAccentColor = false;
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.AnimateReadOnly = false;
            this.txbThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbThanhTien.Depth = 0;
            this.txbThanhTien.Enabled = false;
            this.txbThanhTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbThanhTien.Hint = "Tổng";
            this.txbThanhTien.LeadingIcon = null;
            this.txbThanhTien.Location = new System.Drawing.Point(956, 420);
            this.txbThanhTien.MaxLength = 50;
            this.txbThanhTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txbThanhTien.Multiline = false;
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.Size = new System.Drawing.Size(342, 50);
            this.txbThanhTien.TabIndex = 6;
            this.txbThanhTien.Text = "";
            this.txbThanhTien.TrailingIcon = null;
            this.txbThanhTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbDonGia
            // 
            this.txbDonGia.AnimateReadOnly = false;
            this.txbDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDonGia.Depth = 0;
            this.txbDonGia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDonGia.Hint = "Đơn giá nhập";
            this.txbDonGia.LeadingIcon = null;
            this.txbDonGia.Location = new System.Drawing.Point(956, 353);
            this.txbDonGia.MaxLength = 50;
            this.txbDonGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDonGia.Multiline = false;
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(173, 50);
            this.txbDonGia.TabIndex = 4;
            this.txbDonGia.Text = "";
            this.txbDonGia.TrailingIcon = null;
            this.txbDonGia.TextChanged += new System.EventHandler(this.txbDonGia_TextChanged);
            this.txbDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGia_KeyPress);
            // 
            // txbSLNhap
            // 
            this.txbSLNhap.AnimateReadOnly = false;
            this.txbSLNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLNhap.Depth = 0;
            this.txbSLNhap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSLNhap.Hint = "Số lượng nhập";
            this.txbSLNhap.LeadingIcon = null;
            this.txbSLNhap.Location = new System.Drawing.Point(1146, 353);
            this.txbSLNhap.MaxLength = 50;
            this.txbSLNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSLNhap.Multiline = false;
            this.txbSLNhap.Name = "txbSLNhap";
            this.txbSLNhap.Size = new System.Drawing.Size(152, 50);
            this.txbSLNhap.TabIndex = 5;
            this.txbSLNhap.Text = "";
            this.txbSLNhap.TrailingIcon = null;
            this.txbSLNhap.TextChanged += new System.EventHandler(this.txbSLNhap_TextChanged);
            this.txbSLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSLNhap_KeyPress);
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
            this.btnHuyChon.Location = new System.Drawing.Point(1075, 496);
            this.btnHuyChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChon.Size = new System.Drawing.Size(104, 40);
            this.btnHuyChon.TabIndex = 11;
            this.btnHuyChon.Text = "Huỷ chọn";
            this.btnHuyChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChon.UseAccentColor = false;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.AutoSize = false;
            this.btnXoaSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaSach.Depth = 0;
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.HighEmphasis = true;
            this.btnXoaSach.Icon = null;
            this.btnXoaSach.Location = new System.Drawing.Point(1194, 496);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaSach.Size = new System.Drawing.Size(104, 40);
            this.btnXoaSach.TabIndex = 12;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaSach.UseAccentColor = false;
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.AnimateReadOnly = false;
            this.txbMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNV.Depth = 0;
            this.txbMaNV.Enabled = false;
            this.txbMaNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaNV.Hint = "Mã NV quản lí";
            this.txbMaNV.LeadingIcon = null;
            this.txbMaNV.Location = new System.Drawing.Point(354, 96);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(144, 50);
            this.txbMaNV.TabIndex = 15;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            this.txbMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbMaNCC
            // 
            this.txbMaNCC.AnimateReadOnly = false;
            this.txbMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNCC.Depth = 0;
            this.txbMaNCC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaNCC.Hint = "Mã NCC";
            this.txbMaNCC.LeadingIcon = null;
            this.txbMaNCC.Location = new System.Drawing.Point(514, 96);
            this.txbMaNCC.MaxLength = 50;
            this.txbMaNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNCC.Multiline = false;
            this.txbMaNCC.Name = "txbMaNCC";
            this.txbMaNCC.Size = new System.Drawing.Size(144, 50);
            this.txbMaNCC.TabIndex = 1;
            this.txbMaNCC.TabStop = false;
            this.txbMaNCC.Text = "";
            this.txbMaNCC.TrailingIcon = null;
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
            this.txbMaHD.Location = new System.Drawing.Point(43, 96);
            this.txbMaHD.MaxLength = 50;
            this.txbMaHD.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaHD.Multiline = false;
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(139, 50);
            this.txbMaHD.TabIndex = 13;
            this.txbMaHD.Text = "";
            this.txbMaHD.TrailingIcon = null;
            this.txbMaHD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // dtgvCTNS
            // 
            this.dtgvCTNS.AllowUserToDeleteRows = false;
            this.dtgvCTNS.AllowUserToOrderColumns = true;
            this.dtgvCTNS.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtgvCTNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTNS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvCTNS.Location = new System.Drawing.Point(43, 165);
            this.dtgvCTNS.MultiSelect = false;
            this.dtgvCTNS.Name = "dtgvCTNS";
            this.dtgvCTNS.ReadOnly = true;
            this.dtgvCTNS.RowHeadersWidth = 51;
            this.dtgvCTNS.RowTemplate.Height = 24;
            this.dtgvCTNS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCTNS.Size = new System.Drawing.Size(865, 607);
            this.dtgvCTNS.TabIndex = 12;
            this.dtgvCTNS.TabStop = false;
            this.dtgvCTNS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTNS_CellClick);
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
            this.txbSLKho.Location = new System.Drawing.Point(1146, 288);
            this.txbSLKho.MaxLength = 50;
            this.txbSLKho.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSLKho.Multiline = false;
            this.txbSLKho.Name = "txbSLKho";
            this.txbSLKho.Size = new System.Drawing.Size(152, 50);
            this.txbSLKho.TabIndex = 3;
            this.txbSLKho.Text = "";
            this.txbSLKho.TrailingIcon = null;
            this.txbSLKho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(953, 178);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(231, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Chọn sách để thêm vào hoá đơn";
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
            this.cbListSach.Location = new System.Drawing.Point(956, 224);
            this.cbListSach.MaxDropDownItems = 4;
            this.cbListSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbListSach.Name = "cbListSach";
            this.cbListSach.Size = new System.Drawing.Size(342, 49);
            this.cbListSach.StartIndex = 0;
            this.cbListSach.TabIndex = 1;
            this.cbListSach.SelectedIndexChanged += new System.EventHandler(this.cbListSach_SelectedIndexChanged);
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
            this.txbMaSach.Location = new System.Drawing.Point(956, 288);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(173, 50);
            this.txbMaSach.TabIndex = 2;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
            this.txbMaSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
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
            this.txbNgayTao.Location = new System.Drawing.Point(198, 96);
            this.txbNgayTao.MaxLength = 50;
            this.txbNgayTao.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgayTao.Multiline = false;
            this.txbNgayTao.Name = "txbNgayTao";
            this.txbNgayTao.Size = new System.Drawing.Size(140, 50);
            this.txbNgayTao.TabIndex = 41;
            this.txbNgayTao.Text = "";
            this.txbNgayTao.TrailingIcon = null;
            this.txbNgayTao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 804);
            this.Controls.Add(this.txbNgayTao);
            this.Controls.Add(this.txbMaSach);
            this.Controls.Add(this.cbListSach);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lbTongThanhToan);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txbThanhTien);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.txbSLKho);
            this.Controls.Add(this.txbSLNhap);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbMaNCC);
            this.Controls.Add(this.txbMaHD);
            this.Controls.Add(this.dtgvCTNS);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MinimumSize = new System.Drawing.Size(1279, 690);
            this.Name = "NhapSach";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo hoá đơn nhập sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbTongThanhToan;
        private MaterialSkin.Controls.MaterialButton btnHuyHoaDon;
        private MaterialSkin.Controls.MaterialButton btnDone;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnThemSach;
        private MaterialSkin.Controls.MaterialTextBox txbThanhTien;
        private MaterialSkin.Controls.MaterialTextBox txbDonGia;
        private MaterialSkin.Controls.MaterialTextBox txbSLNhap;
        private MaterialSkin.Controls.MaterialButton btnHuyChon;
        private MaterialSkin.Controls.MaterialButton btnXoaSach;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialTextBox txbMaNCC;
        private MaterialSkin.Controls.MaterialTextBox txbMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dtgvCTNS;
        private MaterialSkin.Controls.MaterialTextBox txbSLKho;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbListSach;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
        private MaterialSkin.Controls.MaterialTextBox txbNgayTao;
    }
}