namespace BookstoreManager
{
    partial class ThemKhachHang
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
            this.txbMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.txbHoTen = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDT = new MaterialSkin.Controls.MaterialTextBox();
            this.txbDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.txbMaKH.Location = new System.Drawing.Point(37, 99);
            this.txbMaKH.MaxLength = 50;
            this.txbMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaKH.Multiline = false;
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(178, 50);
            this.txbMaKH.TabIndex = 1;
            this.txbMaKH.Text = "";
            this.txbMaKH.TrailingIcon = null;
            this.txbMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbHoTen
            // 
            this.txbHoTen.AnimateReadOnly = false;
            this.txbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHoTen.Depth = 0;
            this.txbHoTen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbHoTen.Hint = "Họ tên";
            this.txbHoTen.LeadingIcon = null;
            this.txbHoTen.Location = new System.Drawing.Point(230, 99);
            this.txbHoTen.MaxLength = 50;
            this.txbHoTen.MouseState = MaterialSkin.MouseState.OUT;
            this.txbHoTen.Multiline = false;
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(324, 50);
            this.txbHoTen.TabIndex = 2;
            this.txbHoTen.Text = "";
            this.txbHoTen.TrailingIcon = null;
            // 
            // txbSDT
            // 
            this.txbSDT.AnimateReadOnly = false;
            this.txbSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDT.Depth = 0;
            this.txbSDT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDT.Hint = "Số điện thoại";
            this.txbSDT.LeadingIcon = null;
            this.txbSDT.Location = new System.Drawing.Point(37, 169);
            this.txbSDT.MaxLength = 10;
            this.txbSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDT.Multiline = false;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(517, 50);
            this.txbSDT.TabIndex = 3;
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
            this.txbDiaChi.Location = new System.Drawing.Point(37, 241);
            this.txbDiaChi.MaxLength = 100;
            this.txbDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDiaChi.Multiline = false;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(517, 50);
            this.txbDiaChi.TabIndex = 4;
            this.txbDiaChi.Text = "";
            this.txbDiaChi.TrailingIcon = null;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(207, 315);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(117, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(346, 315);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(461, 315);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(93, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(593, 384);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaKH);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximumSize = new System.Drawing.Size(593, 384);
            this.MinimumSize = new System.Drawing.Size(593, 384);
            this.Name = "ThemKhachHang";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm khách hàng mới";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txbMaKH;
        private MaterialSkin.Controls.MaterialTextBox txbHoTen;
        private MaterialSkin.Controls.MaterialTextBox txbSDT;
        private MaterialSkin.Controls.MaterialTextBox txbDiaChi;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}