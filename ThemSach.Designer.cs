namespace BookstoreManager
{
    partial class ThemSach
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
            this.btnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            this.btnAddBook = new MaterialSkin.Controls.MaterialButton();
            this.txbTenSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTacGia = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbMoTa = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cbNXB = new MaterialSkin.Controls.MaterialComboBox();
            this.txbNamXB = new MaterialSkin.Controls.MaterialTextBox();
            this.cbLoaiSach = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.AutoSize = false;
            this.btnDeleteBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteBook.Depth = 0;
            this.btnDeleteBook.HighEmphasis = true;
            this.btnDeleteBook.Icon = null;
            this.btnDeleteBook.Location = new System.Drawing.Point(473, 632);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteBook.Size = new System.Drawing.Size(81, 36);
            this.btnDeleteBook.TabIndex = 25;
            this.btnDeleteBook.Text = "Xoá";
            this.btnDeleteBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDeleteBook.UseAccentColor = false;
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.AutoSize = false;
            this.btnAddBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddBook.Depth = 0;
            this.btnAddBook.HighEmphasis = true;
            this.btnAddBook.Icon = null;
            this.btnAddBook.Location = new System.Drawing.Point(569, 632);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddBook.Size = new System.Drawing.Size(102, 36);
            this.btnAddBook.TabIndex = 26;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddBook.UseAccentColor = false;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txbTenSach
            // 
            this.txbTenSach.AnimateReadOnly = false;
            this.txbTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenSach.Depth = 0;
            this.txbTenSach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenSach.Hint = "Tên sách";
            this.txbTenSach.LeadingIcon = null;
            this.txbTenSach.Location = new System.Drawing.Point(205, 96);
            this.txbTenSach.MaxLength = 100;
            this.txbTenSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenSach.Multiline = false;
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(466, 50);
            this.txbTenSach.TabIndex = 1;
            this.txbTenSach.Text = "";
            this.txbTenSach.TrailingIcon = null;
            // 
            // txbTacGia
            // 
            this.txbTacGia.AnimateReadOnly = false;
            this.txbTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTacGia.Depth = 0;
            this.txbTacGia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTacGia.Hint = "Tác giả";
            this.txbTacGia.LeadingIcon = null;
            this.txbTacGia.Location = new System.Drawing.Point(37, 235);
            this.txbTacGia.MaxLength = 100;
            this.txbTacGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTacGia.Multiline = false;
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(300, 50);
            this.txbTacGia.TabIndex = 4;
            this.txbTacGia.Text = "";
            this.txbTacGia.TrailingIcon = null;
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
            this.txbMaSach.Location = new System.Drawing.Point(37, 96);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(151, 50);
            this.txbMaSach.TabIndex = 1;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
            // 
            // txbMoTa
            // 
            this.txbMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMoTa.Depth = 0;
            this.txbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbMoTa.Hint = "Mô tả";
            this.txbMoTa.Location = new System.Drawing.Point(37, 341);
            this.txbMoTa.MaxLength = 300;
            this.txbMoTa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(635, 259);
            this.txbMoTa.TabIndex = 6;
            this.txbMoTa.Text = "";
            // 
            // cbNXB
            // 
            this.cbNXB.AutoResize = false;
            this.cbNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNXB.Depth = 0;
            this.cbNXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNXB.DropDownHeight = 174;
            this.cbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXB.DropDownWidth = 121;
            this.cbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Hint = "Nhà xuất bản";
            this.cbNXB.IntegralHeight = false;
            this.cbNXB.ItemHeight = 43;
            this.cbNXB.Location = new System.Drawing.Point(355, 165);
            this.cbNXB.MaxDropDownItems = 4;
            this.cbNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(316, 49);
            this.cbNXB.StartIndex = 0;
            this.cbNXB.TabIndex = 3;
            // 
            // txbNamXB
            // 
            this.txbNamXB.AnimateReadOnly = false;
            this.txbNamXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNamXB.Depth = 0;
            this.txbNamXB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNamXB.Hint = "Năm xuất bản";
            this.txbNamXB.LeadingIcon = null;
            this.txbNamXB.Location = new System.Drawing.Point(355, 235);
            this.txbNamXB.MaxLength = 4;
            this.txbNamXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txbNamXB.Multiline = false;
            this.txbNamXB.Name = "txbNamXB";
            this.txbNamXB.Size = new System.Drawing.Size(316, 50);
            this.txbNamXB.TabIndex = 5;
            this.txbNamXB.Text = "";
            this.txbNamXB.TrailingIcon = null;
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
            this.cbLoaiSach.Location = new System.Drawing.Point(37, 165);
            this.cbLoaiSach.MaxDropDownItems = 4;
            this.cbLoaiSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(300, 49);
            this.cbLoaiSach.StartIndex = 2;
            this.cbLoaiSach.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(38, 310);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Mô tả";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = null;
            this.btnThoat.Location = new System.Drawing.Point(369, 632);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(89, 36);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThemSach
            // 
            this.AcceptButton = this.btnAddBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 707);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbLoaiSach);
            this.Controls.Add(this.txbNamXB);
            this.Controls.Add(this.cbNXB);
            this.Controls.Add(this.txbMoTa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.txbTacGia);
            this.Controls.Add(this.txbMaSach);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "ThemSach";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Text = "Tạo sách mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnDeleteBook;
        private MaterialSkin.Controls.MaterialButton btnAddBook;
        private MaterialSkin.Controls.MaterialTextBox txbTenSach;
        private MaterialSkin.Controls.MaterialTextBox txbTacGia;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txbMoTa;
        private MaterialSkin.Controls.MaterialComboBox cbNXB;
        private MaterialSkin.Controls.MaterialTextBox txbNamXB;
        private MaterialSkin.Controls.MaterialComboBox cbLoaiSach;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}