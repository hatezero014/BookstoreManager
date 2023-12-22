namespace BookstoreManager
{
    partial class ThemNhaXuatBan
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
            this.btnThemNXB = new MaterialSkin.Controls.MaterialButton();
            this.txbMaNXB = new MaterialSkin.Controls.MaterialTextBox();
            this.txbTenNXB = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuyChonNXB = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaNXB = new MaterialSkin.Controls.MaterialButton();
            this.dtgvListNXB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.AutoSize = false;
            this.btnThemNXB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNXB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemNXB.Depth = 0;
            this.btnThemNXB.HighEmphasis = true;
            this.btnThemNXB.Icon = null;
            this.btnThemNXB.Location = new System.Drawing.Point(233, 248);
            this.btnThemNXB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNXB.Size = new System.Drawing.Size(79, 36);
            this.btnThemNXB.TabIndex = 35;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNXB.UseAccentColor = false;
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // txbMaNXB
            // 
            this.txbMaNXB.AnimateReadOnly = false;
            this.txbMaNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNXB.Depth = 0;
            this.txbMaNXB.Enabled = false;
            this.txbMaNXB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbMaNXB.Hint = "Mã nhà xuất bản";
            this.txbMaNXB.LeadingIcon = null;
            this.txbMaNXB.Location = new System.Drawing.Point(39, 108);
            this.txbMaNXB.MaxLength = 50;
            this.txbMaNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNXB.Multiline = false;
            this.txbMaNXB.Name = "txbMaNXB";
            this.txbMaNXB.Size = new System.Drawing.Size(273, 50);
            this.txbMaNXB.TabIndex = 33;
            this.txbMaNXB.Text = "";
            this.txbMaNXB.TrailingIcon = null;
            // 
            // txbTenNXB
            // 
            this.txbTenNXB.AnimateReadOnly = false;
            this.txbTenNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNXB.Depth = 0;
            this.txbTenNXB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenNXB.Hint = "Tên nhà xuất bản";
            this.txbTenNXB.LeadingIcon = null;
            this.txbTenNXB.Location = new System.Drawing.Point(39, 177);
            this.txbTenNXB.MaxLength = 50;
            this.txbTenNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenNXB.Multiline = false;
            this.txbTenNXB.Name = "txbTenNXB";
            this.txbTenNXB.Size = new System.Drawing.Size(273, 50);
            this.txbTenNXB.TabIndex = 34;
            this.txbTenNXB.Text = "";
            this.txbTenNXB.TrailingIcon = null;
            // 
            // btnHuyChonNXB
            // 
            this.btnHuyChonNXB.AutoSize = false;
            this.btnHuyChonNXB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChonNXB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyChonNXB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChonNXB.Depth = 0;
            this.btnHuyChonNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChonNXB.HighEmphasis = true;
            this.btnHuyChonNXB.Icon = null;
            this.btnHuyChonNXB.Location = new System.Drawing.Point(124, 248);
            this.btnHuyChonNXB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChonNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChonNXB.Name = "btnHuyChonNXB";
            this.btnHuyChonNXB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChonNXB.Size = new System.Drawing.Size(94, 36);
            this.btnHuyChonNXB.TabIndex = 32;
            this.btnHuyChonNXB.Text = "Huỷ chọn";
            this.btnHuyChonNXB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChonNXB.UseAccentColor = false;
            this.btnHuyChonNXB.UseVisualStyleBackColor = true;
            this.btnHuyChonNXB.Click += new System.EventHandler(this.btnHuyChonNXB_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.AutoSize = false;
            this.btnXoaNXB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaNXB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaNXB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaNXB.Depth = 0;
            this.btnXoaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNXB.HighEmphasis = true;
            this.btnXoaNXB.Icon = null;
            this.btnXoaNXB.Location = new System.Drawing.Point(39, 248);
            this.btnXoaNXB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaNXB.Size = new System.Drawing.Size(70, 36);
            this.btnXoaNXB.TabIndex = 31;
            this.btnXoaNXB.Text = "Xoá";
            this.btnXoaNXB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoaNXB.UseAccentColor = false;
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // dtgvListNXB
            // 
            this.dtgvListNXB.AllowUserToDeleteRows = false;
            this.dtgvListNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvListNXB.Location = new System.Drawing.Point(355, 108);
            this.dtgvListNXB.Name = "dtgvListNXB";
            this.dtgvListNXB.RowHeadersWidth = 51;
            this.dtgvListNXB.RowTemplate.Height = 24;
            this.dtgvListNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListNXB.Size = new System.Drawing.Size(453, 378);
            this.dtgvListNXB.TabIndex = 36;
            this.dtgvListNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNXB_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 321;
            // 
            // ThemNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.dtgvListNXB);
            this.Controls.Add(this.btnThemNXB);
            this.Controls.Add(this.txbMaNXB);
            this.Controls.Add(this.txbTenNXB);
            this.Controls.Add(this.btnHuyChonNXB);
            this.Controls.Add(this.btnXoaNXB);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "ThemNhaXuatBan";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Text = "Nhà xuất bản";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnThemNXB;
        private MaterialSkin.Controls.MaterialTextBox txbMaNXB;
        private MaterialSkin.Controls.MaterialTextBox txbTenNXB;
        private MaterialSkin.Controls.MaterialButton btnHuyChonNXB;
        private MaterialSkin.Controls.MaterialButton btnXoaNXB;
        private System.Windows.Forms.DataGridView dtgvListNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}