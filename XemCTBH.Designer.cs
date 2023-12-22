namespace BookstoreManager
{
    partial class XemCTBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemCTBH));
            this.lbThanhToan = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaBH = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgvListCTBH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbNgayTao = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCTBH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Depth = 0;
            this.lbThanhToan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbThanhToan.Location = new System.Drawing.Point(200, 797);
            this.lbThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(25, 19);
            this.lbThanhToan.TabIndex = 48;
            this.lbThanhToan.Text = "Giá";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(33, 794);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Thành tiền";
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
            this.txbMaNV.Location = new System.Drawing.Point(334, 88);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(144, 50);
            this.txbMaNV.TabIndex = 43;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            // 
            // txbMaKH
            // 
            this.txbMaKH.AnimateReadOnly = false;
            this.txbMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaKH.Depth = 0;
            this.txbMaKH.Enabled = false;
            this.txbMaKH.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaKH.Hint = "Mã khách hàng";
            this.txbMaKH.LeadingIcon = null;
            this.txbMaKH.Location = new System.Drawing.Point(494, 88);
            this.txbMaKH.MaxLength = 50;
            this.txbMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaKH.Multiline = false;
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(144, 50);
            this.txbMaKH.TabIndex = 42;
            this.txbMaKH.Text = "";
            this.txbMaKH.TrailingIcon = null;
            // 
            // txbMaBH
            // 
            this.txbMaBH.AnimateReadOnly = false;
            this.txbMaBH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaBH.Depth = 0;
            this.txbMaBH.Enabled = false;
            this.txbMaBH.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaBH.Hint = "Mã hoá đơn";
            this.txbMaBH.LeadingIcon = null;
            this.txbMaBH.Location = new System.Drawing.Point(33, 88);
            this.txbMaBH.MaxLength = 50;
            this.txbMaBH.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaBH.Multiline = false;
            this.txbMaBH.Name = "txbMaBH";
            this.txbMaBH.Size = new System.Drawing.Size(139, 50);
            this.txbMaBH.TabIndex = 41;
            this.txbMaBH.Text = "";
            this.txbMaBH.TrailingIcon = null;
            // 
            // dtgvListCTBH
            // 
            this.dtgvListCTBH.AllowUserToDeleteRows = false;
            this.dtgvListCTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListCTBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvListCTBH.Location = new System.Drawing.Point(33, 157);
            this.dtgvListCTBH.Name = "dtgvListCTBH";
            this.dtgvListCTBH.ReadOnly = true;
            this.dtgvListCTBH.RowHeadersWidth = 51;
            this.dtgvListCTBH.RowTemplate.Height = 24;
            this.dtgvListCTBH.Size = new System.Drawing.Size(865, 599);
            this.dtgvListCTBH.TabIndex = 40;
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
            // txbNgayTao
            // 
            this.txbNgayTao.AnimateReadOnly = false;
            this.txbNgayTao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgayTao.Depth = 0;
            this.txbNgayTao.Enabled = false;
            this.txbNgayTao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgayTao.Hint = "Ngày";
            this.txbNgayTao.LeadingIcon = null;
            this.txbNgayTao.Location = new System.Drawing.Point(189, 88);
            this.txbNgayTao.MaxLength = 50;
            this.txbNgayTao.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgayTao.Multiline = false;
            this.txbNgayTao.Name = "txbNgayTao";
            this.txbNgayTao.Size = new System.Drawing.Size(129, 50);
            this.txbNgayTao.TabIndex = 42;
            this.txbNgayTao.Text = "";
            this.txbNgayTao.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialButton1.Location = new System.Drawing.Point(745, 784);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(153, 43);
            this.materialButton1.TabIndex = 49;
            this.materialButton1.Text = "In hoá đơn";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = null;
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(643, 784);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(87, 43);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // XemCTBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 851);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbThanhToan);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbNgayTao);
            this.Controls.Add(this.txbMaKH);
            this.Controls.Add(this.txbMaBH);
            this.Controls.Add(this.dtgvListCTBH);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "XemCTBH";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Text = "Chi tiết bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCTBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbThanhToan;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialTextBox txbMaKH;
        private MaterialSkin.Controls.MaterialTextBox txbMaBH;
        private System.Windows.Forms.DataGridView dtgvListCTBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialTextBox txbNgayTao;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}