namespace BookstoreManager
{
    partial class ThemNhanVien
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
            this.txbDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDT = new MaterialSkin.Controls.MaterialTextBox();
            this.txbHoTen = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbCCCD = new MaterialSkin.Controls.MaterialTextBox();
            this.txbEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txbNgaySinh = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AnimateReadOnly = false;
            this.txbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiaChi.Depth = 0;
            this.txbDiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDiaChi.Hint = "Địa chỉ";
            this.txbDiaChi.LeadingIcon = null;
            this.txbDiaChi.Location = new System.Drawing.Point(47, 309);
            this.txbDiaChi.MaxLength = 100;
            this.txbDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDiaChi.Multiline = false;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(517, 50);
            this.txbDiaChi.TabIndex = 7;
            this.txbDiaChi.Text = "";
            this.txbDiaChi.TrailingIcon = null;
            // 
            // txbSDT
            // 
            this.txbSDT.AnimateReadOnly = false;
            this.txbSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDT.Depth = 0;
            this.txbSDT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDT.Hint = "Số điện thoại";
            this.txbSDT.LeadingIcon = null;
            this.txbSDT.Location = new System.Drawing.Point(47, 170);
            this.txbSDT.MaxLength = 10;
            this.txbSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDT.Multiline = false;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(254, 50);
            this.txbSDT.TabIndex = 3;
            this.txbSDT.Text = "";
            this.txbSDT.TrailingIcon = null;
            this.txbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDT_KeyPress);
            // 
            // txbHoTen
            // 
            this.txbHoTen.AnimateReadOnly = false;
            this.txbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHoTen.Depth = 0;
            this.txbHoTen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbHoTen.Hint = "Họ tên";
            this.txbHoTen.LeadingIcon = null;
            this.txbHoTen.Location = new System.Drawing.Point(209, 101);
            this.txbHoTen.MaxLength = 50;
            this.txbHoTen.MouseState = MaterialSkin.MouseState.OUT;
            this.txbHoTen.Multiline = false;
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(355, 50);
            this.txbHoTen.TabIndex = 2;
            this.txbHoTen.Text = "";
            this.txbHoTen.TrailingIcon = null;
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
            this.txbMaNV.Location = new System.Drawing.Point(47, 101);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(148, 50);
            this.txbMaNV.TabIndex = 1;
            this.txbMaNV.TabStop = false;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            this.txbMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbCCCD
            // 
            this.txbCCCD.AnimateReadOnly = false;
            this.txbCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCCCD.Depth = 0;
            this.txbCCCD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbCCCD.Hint = "Số CCCD";
            this.txbCCCD.LeadingIcon = null;
            this.txbCCCD.Location = new System.Drawing.Point(47, 240);
            this.txbCCCD.MaxLength = 10;
            this.txbCCCD.MouseState = MaterialSkin.MouseState.OUT;
            this.txbCCCD.Multiline = false;
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(254, 50);
            this.txbCCCD.TabIndex = 5;
            this.txbCCCD.Text = "";
            this.txbCCCD.TrailingIcon = null;
            this.txbCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCCCD_KeyPress);
            // 
            // txbEmail
            // 
            this.txbEmail.AnimateReadOnly = false;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Depth = 0;
            this.txbEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbEmail.Hint = "Email";
            this.txbEmail.LeadingIcon = null;
            this.txbEmail.Location = new System.Drawing.Point(315, 170);
            this.txbEmail.MaxLength = 25;
            this.txbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txbEmail.Multiline = false;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(249, 50);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.Text = "";
            this.txbEmail.TrailingIcon = null;
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.AnimateReadOnly = true;
            this.txbNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgaySinh.Depth = 0;
            this.txbNgaySinh.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgaySinh.Hint = "Ngày sinh";
            this.txbNgaySinh.LeadingIcon = null;
            this.txbNgaySinh.Location = new System.Drawing.Point(315, 240);
            this.txbNgaySinh.MaxLength = 25;
            this.txbNgaySinh.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgaySinh.Multiline = false;
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.Size = new System.Drawing.Size(249, 50);
            this.txbNgaySinh.TabIndex = 6;
            this.txbNgaySinh.Text = "";
            this.txbNgaySinh.TrailingIcon = null;
            this.txbNgaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNgaySinh_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = null;
            this.btnThoat.Location = new System.Drawing.Point(447, 385);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(117, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(310, 385);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(117, 39);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(173, 385);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(117, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemNhanVien
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(600, 458);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbNgaySinh);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbCCCD);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaNV);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "ThemNhanVien";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhân viên";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txbDiaChi;
        private MaterialSkin.Controls.MaterialTextBox txbSDT;
        private MaterialSkin.Controls.MaterialTextBox txbHoTen;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialTextBox txbCCCD;
        private MaterialSkin.Controls.MaterialTextBox txbEmail;
        private MaterialSkin.Controls.MaterialTextBox txbNgaySinh;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
    }
}