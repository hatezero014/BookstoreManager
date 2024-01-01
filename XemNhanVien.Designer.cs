namespace BookstoreManager
{
    partial class XemNhanVien
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
            this.txbDiaChiNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTenNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbEmailNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbCCCDNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDTNV = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.txbNgaySinhNV = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txbDiaChiNV
            // 
            this.txbDiaChiNV.AnimateReadOnly = false;
            this.txbDiaChiNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiaChiNV.Depth = 0;
            this.txbDiaChiNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDiaChiNV.Hint = "Địa chỉ";
            this.txbDiaChiNV.LeadingIcon = null;
            this.txbDiaChiNV.Location = new System.Drawing.Point(37, 302);
            this.txbDiaChiNV.MaxLength = 100;
            this.txbDiaChiNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDiaChiNV.Multiline = false;
            this.txbDiaChiNV.Name = "txbDiaChiNV";
            this.txbDiaChiNV.Size = new System.Drawing.Size(517, 50);
            this.txbDiaChiNV.TabIndex = 7;
            this.txbDiaChiNV.Text = "";
            this.txbDiaChiNV.TrailingIcon = null;
            // 
            // txbTenNV
            // 
            this.txbTenNV.AnimateReadOnly = false;
            this.txbTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNV.Depth = 0;
            this.txbTenNV.Enabled = false;
            this.txbTenNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenNV.Hint = "Họ tên";
            this.txbTenNV.LeadingIcon = null;
            this.txbTenNV.Location = new System.Drawing.Point(198, 94);
            this.txbTenNV.MaxLength = 50;
            this.txbTenNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenNV.Multiline = false;
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(356, 50);
            this.txbTenNV.TabIndex = 2;
            this.txbTenNV.Text = "";
            this.txbTenNV.TrailingIcon = null;
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
            this.txbMaNV.Location = new System.Drawing.Point(37, 94);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(148, 50);
            this.txbMaNV.TabIndex = 1;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            this.txbMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbEmailNV
            // 
            this.txbEmailNV.AnimateReadOnly = false;
            this.txbEmailNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmailNV.Depth = 0;
            this.txbEmailNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbEmailNV.Hint = "Email";
            this.txbEmailNV.LeadingIcon = null;
            this.txbEmailNV.Location = new System.Drawing.Point(305, 233);
            this.txbEmailNV.MaxLength = 25;
            this.txbEmailNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbEmailNV.Multiline = false;
            this.txbEmailNV.Name = "txbEmailNV";
            this.txbEmailNV.Size = new System.Drawing.Size(249, 50);
            this.txbEmailNV.TabIndex = 6;
            this.txbEmailNV.Text = "";
            this.txbEmailNV.TrailingIcon = null;
            // 
            // txbCCCDNV
            // 
            this.txbCCCDNV.AnimateReadOnly = false;
            this.txbCCCDNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCCCDNV.Depth = 0;
            this.txbCCCDNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbCCCDNV.Hint = "Số CCCD";
            this.txbCCCDNV.LeadingIcon = null;
            this.txbCCCDNV.Location = new System.Drawing.Point(37, 163);
            this.txbCCCDNV.MaxLength = 10;
            this.txbCCCDNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbCCCDNV.Multiline = false;
            this.txbCCCDNV.Name = "txbCCCDNV";
            this.txbCCCDNV.Size = new System.Drawing.Size(254, 50);
            this.txbCCCDNV.TabIndex = 3;
            this.txbCCCDNV.Text = "";
            this.txbCCCDNV.TrailingIcon = null;
            // 
            // txbSDTNV
            // 
            this.txbSDTNV.AnimateReadOnly = false;
            this.txbSDTNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDTNV.Depth = 0;
            this.txbSDTNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDTNV.Hint = "Số điện thoại";
            this.txbSDTNV.LeadingIcon = null;
            this.txbSDTNV.Location = new System.Drawing.Point(37, 233);
            this.txbSDTNV.MaxLength = 10;
            this.txbSDTNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDTNV.Multiline = false;
            this.txbSDTNV.Name = "txbSDTNV";
            this.txbSDTNV.Size = new System.Drawing.Size(254, 50);
            this.txbSDTNV.TabIndex = 5;
            this.txbSDTNV.Text = "";
            this.txbSDTNV.TrailingIcon = null;
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
            this.btnThoat.Location = new System.Drawing.Point(467, 376);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(87, 41);
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
            this.btnXoa.Location = new System.Drawing.Point(360, 376);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(87, 41);
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
            this.btnThem.Location = new System.Drawing.Point(224, 376);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(117, 41);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Cập nhật";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbNgaySinhNV
            // 
            this.txbNgaySinhNV.AnimateReadOnly = true;
            this.txbNgaySinhNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgaySinhNV.Depth = 0;
            this.txbNgaySinhNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgaySinhNV.Hint = "Ngày sinh";
            this.txbNgaySinhNV.LeadingIcon = null;
            this.txbNgaySinhNV.Location = new System.Drawing.Point(305, 163);
            this.txbNgaySinhNV.MaxLength = 25;
            this.txbNgaySinhNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgaySinhNV.Multiline = false;
            this.txbNgaySinhNV.Name = "txbNgaySinhNV";
            this.txbNgaySinhNV.Size = new System.Drawing.Size(249, 50);
            this.txbNgaySinhNV.TabIndex = 4;
            this.txbNgaySinhNV.Text = "";
            this.txbNgaySinhNV.TrailingIcon = null;
            this.txbNgaySinhNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNgaySinhNV_KeyPress);
            // 
            // XemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbNgaySinhNV);
            this.Controls.Add(this.txbEmailNV);
            this.Controls.Add(this.txbCCCDNV);
            this.Controls.Add(this.txbSDTNV);
            this.Controls.Add(this.txbDiaChiNV);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "XemNhanVien";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin nhân viên";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txbDiaChiNV;
        private MaterialSkin.Controls.MaterialTextBox txbTenNV;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
        private MaterialSkin.Controls.MaterialTextBox txbEmailNV;
        private MaterialSkin.Controls.MaterialTextBox txbCCCDNV;
        private MaterialSkin.Controls.MaterialTextBox txbSDTNV;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialTextBox txbNgaySinhNV;
    }
}