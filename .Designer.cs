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
            this.btnAction = new MaterialSkin.Controls.MaterialButton();
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
            // btnAction
            // 
            this.btnAction.AutoSize = false;
            this.btnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAction.Depth = 0;
            this.btnAction.HighEmphasis = true;
            this.btnAction.Icon = null;
            this.btnAction.Location = new System.Drawing.Point(350, 388);
            this.btnAction.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAction.Name = "btnAction";
            this.btnAction.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAction.Size = new System.Drawing.Size(118, 56);
            this.btnAction.TabIndex = 35;
            this.btnAction.Text = "Cập nhật";
            this.btnAction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAction.UseAccentColor = false;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.TextChanged += new System.EventHandler(this.btnAction_TextChanged);
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
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
            this.txbMaNXB.Location = new System.Drawing.Point(58, 169);
            this.txbMaNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaNXB.MaxLength = 50;
            this.txbMaNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaNXB.Multiline = false;
            this.txbMaNXB.Name = "txbMaNXB";
            this.txbMaNXB.Size = new System.Drawing.Size(410, 50);
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
            this.txbTenNXB.Location = new System.Drawing.Point(58, 277);
            this.txbTenNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenNXB.MaxLength = 50;
            this.txbTenNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txbTenNXB.Multiline = false;
            this.txbTenNXB.Name = "txbTenNXB";
            this.txbTenNXB.Size = new System.Drawing.Size(410, 50);
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
            this.btnHuyChonNXB.Location = new System.Drawing.Point(186, 388);
            this.btnHuyChonNXB.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHuyChonNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChonNXB.Name = "btnHuyChonNXB";
            this.btnHuyChonNXB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChonNXB.Size = new System.Drawing.Size(141, 56);
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
            this.btnXoaNXB.Location = new System.Drawing.Point(58, 388);
            this.btnXoaNXB.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnXoaNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaNXB.Size = new System.Drawing.Size(105, 56);
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
            this.dtgvListNXB.Location = new System.Drawing.Point(532, 169);
            this.dtgvListNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvListNXB.Name = "dtgvListNXB";
            this.dtgvListNXB.ReadOnly = true;
            this.dtgvListNXB.RowHeadersWidth = 51;
            this.dtgvListNXB.RowTemplate.Height = 24;
            this.dtgvListNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListNXB.Size = new System.Drawing.Size(680, 591);
            this.dtgvListNXB.TabIndex = 36;
            this.dtgvListNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNXB_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 321;
            // 
            // ThemNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 805);
            this.Controls.Add(this.dtgvListNXB);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txbMaNXB);
            this.Controls.Add(this.txbTenNXB);
            this.Controls.Add(this.btnHuyChonNXB);
            this.Controls.Add(this.btnXoaNXB);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemNhaXuatBan";
            this.Padding = new System.Windows.Forms.Padding(4, 112, 4, 5);
            this.Text = "Nhà xuất bản";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAction;
        private MaterialSkin.Controls.MaterialTextBox txbMaNXB;
        private MaterialSkin.Controls.MaterialTextBox txbTenNXB;
        private MaterialSkin.Controls.MaterialButton btnHuyChonNXB;
        private MaterialSkin.Controls.MaterialButton btnXoaNXB;
        private System.Windows.Forms.DataGridView dtgvListNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}