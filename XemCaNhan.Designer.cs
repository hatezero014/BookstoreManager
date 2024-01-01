namespace BookstoreManager
{
    partial class XemCaNhan
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
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.txbNgaySinhNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbEmailNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbCCCDNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDTNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbDiaChiNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTenNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaNV = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
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
            this.btnThoat.Location = new System.Drawing.Point(456, 387);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(103, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = false;
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = null;
            this.btnCapNhat.Location = new System.Drawing.Point(319, 387);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(117, 41);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txbNgaySinhNV
            // 
            this.txbNgaySinhNV.AnimateReadOnly = true;
            this.txbNgaySinhNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgaySinhNV.Depth = 0;
            this.txbNgaySinhNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgaySinhNV.Hint = "Ngày sinh";
            this.txbNgaySinhNV.LeadingIcon = null;
            this.txbNgaySinhNV.Location = new System.Drawing.Point(310, 244);
            this.txbNgaySinhNV.MaxLength = 25;
            this.txbNgaySinhNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNgaySinhNV.Multiline = false;
            this.txbNgaySinhNV.Name = "txbNgaySinhNV";
            this.txbNgaySinhNV.Size = new System.Drawing.Size(249, 50);
            this.txbNgaySinhNV.TabIndex = 6;
            this.txbNgaySinhNV.Text = "";
            this.txbNgaySinhNV.TrailingIcon = null;
            // 
            // txbEmailNV
            // 
            this.txbEmailNV.AnimateReadOnly = false;
            this.txbEmailNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmailNV.Depth = 0;
            this.txbEmailNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbEmailNV.Hint = "Email";
            this.txbEmailNV.LeadingIcon = null;
            this.txbEmailNV.Location = new System.Drawing.Point(310, 174);
            this.txbEmailNV.MaxLength = 25;
            this.txbEmailNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbEmailNV.Multiline = false;
            this.txbEmailNV.Name = "txbEmailNV";
            this.txbEmailNV.Size = new System.Drawing.Size(249, 50);
            this.txbEmailNV.TabIndex = 4;
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
            this.txbCCCDNV.Location = new System.Drawing.Point(42, 244);
            this.txbCCCDNV.MaxLength = 10;
            this.txbCCCDNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbCCCDNV.Multiline = false;
            this.txbCCCDNV.Name = "txbCCCDNV";
            this.txbCCCDNV.Size = new System.Drawing.Size(254, 50);
            this.txbCCCDNV.TabIndex = 5;
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
            this.txbSDTNV.Location = new System.Drawing.Point(42, 174);
            this.txbSDTNV.MaxLength = 10;
            this.txbSDTNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDTNV.Multiline = false;
            this.txbSDTNV.Name = "txbSDTNV";
            this.txbSDTNV.Size = new System.Drawing.Size(254, 50);
            this.txbSDTNV.TabIndex = 3;
            this.txbSDTNV.Text = "";
            this.txbSDTNV.TrailingIcon = null;
            // 
            // txbDiaChiNV
            // 
            this.txbDiaChiNV.AnimateReadOnly = false;
            this.txbDiaChiNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiaChiNV.Depth = 0;
            this.txbDiaChiNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDiaChiNV.Hint = "Địa chỉ";
            this.txbDiaChiNV.LeadingIcon = null;
            this.txbDiaChiNV.Location = new System.Drawing.Point(42, 313);
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
            this.txbTenNV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenNV.Hint = "Họ tên";
            this.txbTenNV.LeadingIcon = null;
            this.txbTenNV.Location = new System.Drawing.Point(203, 105);
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
            this.txbMaNV.Location = new System.Drawing.Point(42, 105);
            this.txbMaNV.MaxLength = 50;
            this.txbMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNV.Multiline = false;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(148, 50);
            this.txbMaNV.TabIndex = 1;
            this.txbMaNV.Text = "";
            this.txbMaNV.TrailingIcon = null;
            // 
            // XemCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(594, 455);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txbNgaySinhNV);
            this.Controls.Add(this.txbEmailNV);
            this.Controls.Add(this.txbCCCDNV);
            this.Controls.Add(this.txbSDTNV);
            this.Controls.Add(this.txbDiaChiNV);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "XemCaNhan";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialTextBox txbNgaySinhNV;
        private MaterialSkin.Controls.MaterialTextBox txbEmailNV;
        private MaterialSkin.Controls.MaterialTextBox txbCCCDNV;
        private MaterialSkin.Controls.MaterialTextBox txbSDTNV;
        private MaterialSkin.Controls.MaterialTextBox txbDiaChiNV;
        private MaterialSkin.Controls.MaterialTextBox txbTenNV;
        private MaterialSkin.Controls.MaterialTextBox txbMaNV;
    }
}