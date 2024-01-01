namespace BookstoreManager
{
    partial class XemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemKhachHang));
            this.btnCapNhatKH = new MaterialSkin.Controls.MaterialButton();
            this.txbDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSDT = new MaterialSkin.Controls.MaterialTextBox();
            this.txbHoTen = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.btnXoaKH = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnCapNhatKH
            // 
            resources.ApplyResources(this.btnCapNhatKH, "btnCapNhatKH");
            this.btnCapNhatKH.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhatKH.Depth = 0;
            this.btnCapNhatKH.HighEmphasis = true;
            this.btnCapNhatKH.Icon = null;
            this.btnCapNhatKH.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhatKH.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhatKH.UseAccentColor = false;
            this.btnCapNhatKH.UseVisualStyleBackColor = true;
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AnimateReadOnly = false;
            this.txbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiaChi.Depth = 0;
            resources.ApplyResources(this.txbDiaChi, "txbDiaChi");
            this.txbDiaChi.LeadingIcon = null;
            this.txbDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.TrailingIcon = null;
            // 
            // txbSDT
            // 
            this.txbSDT.AnimateReadOnly = false;
            this.txbSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSDT.Depth = 0;
            resources.ApplyResources(this.txbSDT, "txbSDT");
            this.txbSDT.LeadingIcon = null;
            this.txbSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.TrailingIcon = null;
            // 
            // txbHoTen
            // 
            this.txbHoTen.AnimateReadOnly = false;
            this.txbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHoTen.Depth = 0;
            resources.ApplyResources(this.txbHoTen, "txbHoTen");
            this.txbHoTen.LeadingIcon = null;
            this.txbHoTen.MouseState = MaterialSkin.MouseState.OUT;
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.TrailingIcon = null;
            // 
            // txbMaKH
            // 
            this.txbMaKH.AnimateReadOnly = false;
            this.txbMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaKH.Depth = 0;
            resources.ApplyResources(this.txbMaKH, "txbMaKH");
            this.txbMaKH.LeadingIcon = null;
            this.txbMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.TrailingIcon = null;
            this.txbMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // btnXoaKH
            // 
            resources.ApplyResources(this.btnXoaKH, "btnXoaKH");
            this.btnXoaKH.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaKH.Depth = 0;
            this.btnXoaKH.HighEmphasis = true;
            this.btnXoaKH.Icon = null;
            this.btnXoaKH.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaKH.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaKH.UseAccentColor = false;
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = null;
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // XemKhachHang
            // 
            this.AcceptButton = this.btnCapNhatKH;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnCapNhatKH);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaKH);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "XemKhachHang";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnCapNhatKH;
        private MaterialSkin.Controls.MaterialTextBox txbDiaChi;
        private MaterialSkin.Controls.MaterialTextBox txbSDT;
        private MaterialSkin.Controls.MaterialTextBox txbHoTen;
        private MaterialSkin.Controls.MaterialTextBox txbMaKH;
        private MaterialSkin.Controls.MaterialButton btnXoaKH;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}