namespace BookstoreManager
{
    partial class DoiMatKhau
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
            this.txbTaiKhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMatKhauMoi = new MaterialSkin.Controls.MaterialTextBox();
            this.txbNLMatKhauMoi = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txbMatKhau = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
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
            this.txbTaiKhoan.Location = new System.Drawing.Point(38, 105);
            this.txbTaiKhoan.MaxLength = 50;
            this.txbTaiKhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTaiKhoan.Multiline = false;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(488, 50);
            this.txbTaiKhoan.TabIndex = 1;
            this.txbTaiKhoan.Text = "";
            this.txbTaiKhoan.TrailingIcon = null;
            this.txbTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialTextBox1_KeyDown);
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.AnimateReadOnly = false;
            this.txbMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMatKhauMoi.Depth = 0;
            this.txbMatKhauMoi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMatKhauMoi.Hint = "Mật khẩu mới";
            this.txbMatKhauMoi.LeadingIcon = null;
            this.txbMatKhauMoi.Location = new System.Drawing.Point(38, 243);
            this.txbMatKhauMoi.MaxLength = 50;
            this.txbMatKhauMoi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMatKhauMoi.Multiline = false;
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Password = true;
            this.txbMatKhauMoi.Size = new System.Drawing.Size(488, 50);
            this.txbMatKhauMoi.TabIndex = 3;
            this.txbMatKhauMoi.Text = "";
            this.txbMatKhauMoi.TrailingIcon = null;
            // 
            // txbNLMatKhauMoi
            // 
            this.txbNLMatKhauMoi.AnimateReadOnly = false;
            this.txbNLMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNLMatKhauMoi.Depth = 0;
            this.txbNLMatKhauMoi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNLMatKhauMoi.Hint = "Xác nhận mật khẩu";
            this.txbNLMatKhauMoi.LeadingIcon = null;
            this.txbNLMatKhauMoi.Location = new System.Drawing.Point(38, 315);
            this.txbNLMatKhauMoi.MaxLength = 50;
            this.txbNLMatKhauMoi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNLMatKhauMoi.Multiline = false;
            this.txbNLMatKhauMoi.Name = "txbNLMatKhauMoi";
            this.txbNLMatKhauMoi.Password = true;
            this.txbNLMatKhauMoi.Size = new System.Drawing.Size(488, 50);
            this.txbNLMatKhauMoi.TabIndex = 4;
            this.txbNLMatKhauMoi.Text = "";
            this.txbNLMatKhauMoi.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(314, 397);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(102, 40);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Cập nhật";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(424, 397);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(102, 40);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "Thoát";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.AnimateReadOnly = false;
            this.txbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMatKhau.Depth = 0;
            this.txbMatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMatKhau.Hint = "Mật khẩu";
            this.txbMatKhau.LeadingIcon = null;
            this.txbMatKhau.Location = new System.Drawing.Point(38, 172);
            this.txbMatKhau.MaxLength = 50;
            this.txbMatKhau.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Password = true;
            this.txbMatKhau.Size = new System.Drawing.Size(488, 50);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.Text = "";
            this.txbMatKhau.TrailingIcon = null;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton2;
            this.ClientSize = new System.Drawing.Size(557, 467);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txbNLMatKhauMoi);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbTaiKhoan);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "DoiMatKhau";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txbTaiKhoan;
        private MaterialSkin.Controls.MaterialTextBox txbMatKhauMoi;
        private MaterialSkin.Controls.MaterialTextBox txbNLMatKhauMoi;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox txbMatKhau;
    }
}