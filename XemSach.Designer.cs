namespace BookstoreManager
{
    partial class XemSach
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbLoaiSach = new MaterialSkin.Controls.MaterialComboBox();
            this.txbNamXBSach = new MaterialSkin.Controls.MaterialTextBox();
            this.cbNXBSach = new MaterialSkin.Controls.MaterialComboBox();
            this.txbMoTaSach = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateSach = new MaterialSkin.Controls.MaterialButton();
            this.txbTenSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTacGiaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbSLSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbGiaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbGiaGoc = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(36, 390);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Mô tả";
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.AutoResize = false;
            this.cbLoaiSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLoaiSach.Depth = 0;
            this.cbLoaiSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLoaiSach.DropDownHeight = 174;
            this.cbLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSach.DropDownWidth = 121;
            this.cbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLoaiSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Hint = "Loại sách";
            this.cbLoaiSach.IntegralHeight = false;
            this.cbLoaiSach.ItemHeight = 43;
            this.cbLoaiSach.Location = new System.Drawing.Point(353, 238);
            this.cbLoaiSach.MaxDropDownItems = 4;
            this.cbLoaiSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(316, 49);
            this.cbLoaiSach.StartIndex = 2;
            this.cbLoaiSach.TabIndex = 6;
            // 
            // txbNamXBSach
            // 
            this.txbNamXBSach.AnimateReadOnly = false;
            this.txbNamXBSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNamXBSach.Depth = 0;
            this.txbNamXBSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNamXBSach.Hint = "Năm xuất bản";
            this.txbNamXBSach.LeadingIcon = null;
            this.txbNamXBSach.Location = new System.Drawing.Point(35, 308);
            this.txbNamXBSach.MaxLength = 4;
            this.txbNamXBSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNamXBSach.Multiline = false;
            this.txbNamXBSach.Name = "txbNamXBSach";
            this.txbNamXBSach.Size = new System.Drawing.Size(300, 50);
            this.txbNamXBSach.TabIndex = 7;
            this.txbNamXBSach.Text = "";
            this.txbNamXBSach.TrailingIcon = null;
            // 
            // cbNXBSach
            // 
            this.cbNXBSach.AutoResize = false;
            this.cbNXBSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNXBSach.Depth = 0;
            this.cbNXBSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNXBSach.DropDownHeight = 174;
            this.cbNXBSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXBSach.DropDownWidth = 121;
            this.cbNXBSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNXBSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNXBSach.FormattingEnabled = true;
            this.cbNXBSach.Hint = "Nhà xuất bản";
            this.cbNXBSach.IntegralHeight = false;
            this.cbNXBSach.ItemHeight = 43;
            this.cbNXBSach.Location = new System.Drawing.Point(353, 309);
            this.cbNXBSach.MaxDropDownItems = 4;
            this.cbNXBSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNXBSach.Name = "cbNXBSach";
            this.cbNXBSach.Size = new System.Drawing.Size(316, 49);
            this.cbNXBSach.StartIndex = 0;
            this.cbNXBSach.TabIndex = 8;
            // 
            // txbMoTaSach
            // 
            this.txbMoTaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbMoTaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMoTaSach.Depth = 0;
            this.txbMoTaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoTaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbMoTaSach.Hint = "Mô tả";
            this.txbMoTaSach.Location = new System.Drawing.Point(35, 421);
            this.txbMoTaSach.MaxLength = 300;
            this.txbMoTaSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbMoTaSach.Name = "txbMoTaSach";
            this.txbMoTaSach.Size = new System.Drawing.Size(635, 259);
            this.txbMoTaSach.TabIndex = 9;
            this.txbMoTaSach.Text = "";
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
            this.btnThoat.Location = new System.Drawing.Point(581, 708);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(89, 40);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.AutoSize = false;
            this.btnDeleteBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteBook.Depth = 0;
            this.btnDeleteBook.HighEmphasis = true;
            this.btnDeleteBook.Icon = null;
            this.btnDeleteBook.Location = new System.Drawing.Point(471, 708);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteBook.Size = new System.Drawing.Size(89, 40);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "Xoá";
            this.btnDeleteBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDeleteBook.UseAccentColor = false;
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnUpdateSach
            // 
            this.btnUpdateSach.AutoSize = false;
            this.btnUpdateSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateSach.Depth = 0;
            this.btnUpdateSach.HighEmphasis = true;
            this.btnUpdateSach.Icon = null;
            this.btnUpdateSach.Location = new System.Drawing.Point(350, 708);
            this.btnUpdateSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateSach.Name = "btnUpdateSach";
            this.btnUpdateSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateSach.Size = new System.Drawing.Size(102, 40);
            this.btnUpdateSach.TabIndex = 10;
            this.btnUpdateSach.Text = "Cập nhật";
            this.btnUpdateSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateSach.UseAccentColor = false;
            this.btnUpdateSach.UseVisualStyleBackColor = true;
            this.btnUpdateSach.Click += new System.EventHandler(this.btnUpdateSach_Click);
            // 
            // txbTenSach
            // 
            this.txbTenSach.AnimateReadOnly = false;
            this.txbTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenSach.Depth = 0;
            this.txbTenSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenSach.Hint = "Tên sách";
            this.txbTenSach.LeadingIcon = null;
            this.txbTenSach.Location = new System.Drawing.Point(35, 166);
            this.txbTenSach.MaxLength = 100;
            this.txbTenSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenSach.Multiline = false;
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(408, 50);
            this.txbTenSach.TabIndex = 3;
            this.txbTenSach.Text = "";
            this.txbTenSach.TrailingIcon = null;
            // 
            // txbTacGiaSach
            // 
            this.txbTacGiaSach.AnimateReadOnly = false;
            this.txbTacGiaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTacGiaSach.Depth = 0;
            this.txbTacGiaSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTacGiaSach.Hint = "Tác giả";
            this.txbTacGiaSach.LeadingIcon = null;
            this.txbTacGiaSach.Location = new System.Drawing.Point(35, 237);
            this.txbTacGiaSach.MaxLength = 100;
            this.txbTacGiaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTacGiaSach.Multiline = false;
            this.txbTacGiaSach.Name = "txbTacGiaSach";
            this.txbTacGiaSach.Size = new System.Drawing.Size(300, 50);
            this.txbTacGiaSach.TabIndex = 5;
            this.txbTacGiaSach.Text = "";
            this.txbTacGiaSach.TrailingIcon = null;
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
            this.txbMaSach.Location = new System.Drawing.Point(35, 98);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(179, 50);
            this.txbMaSach.TabIndex = 0;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
            this.txbMaSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbSLSach
            // 
            this.txbSLSach.AnimateReadOnly = false;
            this.txbSLSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLSach.Depth = 0;
            this.txbSLSach.Enabled = false;
            this.txbSLSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSLSach.Hint = "Số lượng";
            this.txbSLSach.LeadingIcon = null;
            this.txbSLSach.Location = new System.Drawing.Point(232, 98);
            this.txbSLSach.MaxLength = 10;
            this.txbSLSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSLSach.Multiline = false;
            this.txbSLSach.Name = "txbSLSach";
            this.txbSLSach.Size = new System.Drawing.Size(211, 50);
            this.txbSLSach.TabIndex = 1;
            this.txbSLSach.Text = "";
            this.txbSLSach.TrailingIcon = null;
            this.txbSLSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // txbGiaSach
            // 
            this.txbGiaSach.AnimateReadOnly = false;
            this.txbGiaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGiaSach.Depth = 0;
            this.txbGiaSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbGiaSach.Hint = "Đơn giá";
            this.txbGiaSach.LeadingIcon = null;
            this.txbGiaSach.Location = new System.Drawing.Point(458, 166);
            this.txbGiaSach.MaxLength = 12;
            this.txbGiaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbGiaSach.Multiline = false;
            this.txbGiaSach.Name = "txbGiaSach";
            this.txbGiaSach.Size = new System.Drawing.Size(211, 50);
            this.txbGiaSach.TabIndex = 4;
            this.txbGiaSach.Text = "";
            this.txbGiaSach.TrailingIcon = null;
            // 
            // txbGiaGoc
            // 
            this.txbGiaGoc.AnimateReadOnly = false;
            this.txbGiaGoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGiaGoc.Depth = 0;
            this.txbGiaGoc.Enabled = false;
            this.txbGiaGoc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbGiaGoc.Hint = "Giá gốc";
            this.txbGiaGoc.LeadingIcon = null;
            this.txbGiaGoc.Location = new System.Drawing.Point(458, 98);
            this.txbGiaGoc.MaxLength = 12;
            this.txbGiaGoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txbGiaGoc.Multiline = false;
            this.txbGiaGoc.Name = "txbGiaGoc";
            this.txbGiaGoc.Size = new System.Drawing.Size(211, 50);
            this.txbGiaGoc.TabIndex = 2;
            this.txbGiaGoc.Text = "";
            this.txbGiaGoc.TrailingIcon = null;
            this.txbGiaGoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readOnlyTxb_KeyDown);
            // 
            // XemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(705, 775);
            this.Controls.Add(this.txbGiaGoc);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbLoaiSach);
            this.Controls.Add(this.txbGiaSach);
            this.Controls.Add(this.txbNamXBSach);
            this.Controls.Add(this.cbNXBSach);
            this.Controls.Add(this.txbMoTaSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateSach);
            this.Controls.Add(this.txbSLSach);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.txbTacGiaSach);
            this.Controls.Add(this.txbMaSach);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MinimumSize = new System.Drawing.Size(705, 690);
            this.Name = "XemSach";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbLoaiSach;
        private MaterialSkin.Controls.MaterialTextBox txbNamXBSach;
        private MaterialSkin.Controls.MaterialComboBox cbNXBSach;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txbMoTaSach;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnDeleteBook;
        private MaterialSkin.Controls.MaterialButton btnUpdateSach;
        private MaterialSkin.Controls.MaterialTextBox txbTenSach;
        private MaterialSkin.Controls.MaterialTextBox txbTacGiaSach;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
        private MaterialSkin.Controls.MaterialTextBox txbSLSach;
        private MaterialSkin.Controls.MaterialTextBox txbGiaSach;
        private MaterialSkin.Controls.MaterialTextBox txbGiaGoc;
    }
}