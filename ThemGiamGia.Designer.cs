namespace BookstoreManager
{
    partial class ThemGiamGia
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
            this.btnHuyChon = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.dtgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbMaSach = new MaterialSkin.Controls.MaterialTextBox();
            this.txbGiaGiam = new MaterialSkin.Controls.MaterialTextBox();
            this.txbGiaTruocGiam = new MaterialSkin.Controls.MaterialTextBox();
            this.txbGiamDen = new MaterialSkin.Controls.MaterialTextBox();
            this.cbListSach = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).BeginInit();
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
            this.btnAction.Location = new System.Drawing.Point(498, 703);
            this.btnAction.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAction.Name = "btnAction";
            this.btnAction.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAction.Size = new System.Drawing.Size(154, 56);
            this.btnAction.TabIndex = 15;
            this.btnAction.Text = "Cập nhật";
            this.btnAction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAction.UseAccentColor = false;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.TextChanged += new System.EventHandler(this.btnAction_TextChanged);
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.AutoSize = false;
            this.btnHuyChon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyChon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChon.Depth = 0;
            this.btnHuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChon.HighEmphasis = true;
            this.btnHuyChon.Icon = null;
            this.btnHuyChon.Location = new System.Drawing.Point(183, 703);
            this.btnHuyChon.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHuyChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChon.Size = new System.Drawing.Size(154, 56);
            this.btnHuyChon.TabIndex = 13;
            this.btnHuyChon.Text = "Huỷ chọn";
            this.btnHuyChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHuyChon.UseAccentColor = false;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(358, 703);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(117, 56);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvList
            // 
            this.dtgvList.AllowUserToDeleteRows = false;
            this.dtgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvList.Location = new System.Drawing.Point(716, 156);
            this.dtgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvList.Name = "dtgvList";
            this.dtgvList.ReadOnly = true;
            this.dtgvList.RowHeadersWidth = 51;
            this.dtgvList.RowTemplate.Height = 24;
            this.dtgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvList.Size = new System.Drawing.Size(837, 603);
            this.dtgvList.TabIndex = 16;
            this.dtgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách giảm giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá trước giảm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá giảm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giảm đến";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
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
            this.txbMaSach.Location = new System.Drawing.Point(88, 156);
            this.txbMaSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaSach.MaxLength = 50;
            this.txbMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txbMaSach.Multiline = false;
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(344, 50);
            this.txbMaSach.TabIndex = 18;
            this.txbMaSach.Text = "";
            this.txbMaSach.TrailingIcon = null;
            // 
            // txbGiaGiam
            // 
            this.txbGiaGiam.AnimateReadOnly = false;
            this.txbGiaGiam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGiaGiam.Depth = 0;
            this.txbGiaGiam.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbGiaGiam.Hint = "Giá giảm";
            this.txbGiaGiam.LeadingIcon = null;
            this.txbGiaGiam.Location = new System.Drawing.Point(88, 353);
            this.txbGiaGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbGiaGiam.MaxLength = 100;
            this.txbGiaGiam.MouseState = MaterialSkin.MouseState.OUT;
            this.txbGiaGiam.Multiline = false;
            this.txbGiaGiam.Name = "txbGiaGiam";
            this.txbGiaGiam.Size = new System.Drawing.Size(344, 50);
            this.txbGiaGiam.TabIndex = 19;
            this.txbGiaGiam.Text = "";
            this.txbGiaGiam.TrailingIcon = null;
            this.txbGiaGiam.TextChanged += new System.EventHandler(this.txbGiaGiam_TextChanged);
            this.txbGiaGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGiaGiam_KeyPress);
            // 
            // txbGiaTruocGiam
            // 
            this.txbGiaTruocGiam.AnimateReadOnly = false;
            this.txbGiaTruocGiam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGiaTruocGiam.Depth = 0;
            this.txbGiaTruocGiam.Enabled = false;
            this.txbGiaTruocGiam.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbGiaTruocGiam.Hint = "Giá trước giảm";
            this.txbGiaTruocGiam.LeadingIcon = null;
            this.txbGiaTruocGiam.Location = new System.Drawing.Point(88, 443);
            this.txbGiaTruocGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbGiaTruocGiam.MaxLength = 100;
            this.txbGiaTruocGiam.MouseState = MaterialSkin.MouseState.OUT;
            this.txbGiaTruocGiam.Multiline = false;
            this.txbGiaTruocGiam.Name = "txbGiaTruocGiam";
            this.txbGiaTruocGiam.Size = new System.Drawing.Size(344, 50);
            this.txbGiaTruocGiam.TabIndex = 20;
            this.txbGiaTruocGiam.Text = "";
            this.txbGiaTruocGiam.TrailingIcon = null;
            this.txbGiaTruocGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGiaTruocGiam_KeyPress);
            // 
            // txbGiamDen
            // 
            this.txbGiamDen.AnimateReadOnly = false;
            this.txbGiamDen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGiamDen.Depth = 0;
            this.txbGiamDen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbGiamDen.Hint = "Giảm đến";
            this.txbGiamDen.LeadingIcon = null;
            this.txbGiamDen.Location = new System.Drawing.Point(88, 547);
            this.txbGiamDen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbGiamDen.MaxLength = 100;
            this.txbGiamDen.MouseState = MaterialSkin.MouseState.OUT;
            this.txbGiamDen.Multiline = false;
            this.txbGiamDen.Name = "txbGiamDen";
            this.txbGiamDen.Size = new System.Drawing.Size(344, 50);
            this.txbGiamDen.TabIndex = 21;
            this.txbGiamDen.Text = "";
            this.txbGiamDen.TrailingIcon = null;
            this.txbGiamDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGiamDen_KeyPress);
            // 
            // cbListSach
            // 
            this.cbListSach.AutoResize = false;
            this.cbListSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbListSach.Depth = 0;
            this.cbListSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbListSach.DropDownHeight = 174;
            this.cbListSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListSach.DropDownWidth = 121;
            this.cbListSach.Enabled = false;
            this.cbListSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbListSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbListSach.FormattingEnabled = true;
            this.cbListSach.Hint = "Tên sách";
            this.cbListSach.IntegralHeight = false;
            this.cbListSach.ItemHeight = 43;
            this.cbListSach.Location = new System.Drawing.Point(88, 260);
            this.cbListSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbListSach.MaxDropDownItems = 4;
            this.cbListSach.MouseState = MaterialSkin.MouseState.OUT;
            this.cbListSach.Name = "cbListSach";
            this.cbListSach.Size = new System.Drawing.Size(344, 49);
            this.cbListSach.StartIndex = 0;
            this.cbListSach.TabIndex = 31;
            this.cbListSach.SelectedIndexChanged += new System.EventHandler(this.cbListSach_SelectedIndexChanged);
            // 
            // ThemGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 894);
            this.Controls.Add(this.cbListSach);
            this.Controls.Add(this.txbGiamDen);
            this.Controls.Add(this.txbGiaTruocGiam);
            this.Controls.Add(this.txbGiaGiam);
            this.Controls.Add(this.txbMaSach);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgvList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemGiamGia";
            this.Padding = new System.Windows.Forms.Padding(4, 100, 4, 5);
            this.Text = "Giảm giá sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAction;
        private MaterialSkin.Controls.MaterialButton btnHuyChon;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private System.Windows.Forms.DataGridView dtgvList;
        private MaterialSkin.Controls.MaterialTextBox txbMaSach;
        private MaterialSkin.Controls.MaterialTextBox txbGiaGiam;
        private MaterialSkin.Controls.MaterialTextBox txbGiaTruocGiam;
        private MaterialSkin.Controls.MaterialTextBox txbGiamDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialComboBox cbListSach;
    }
}