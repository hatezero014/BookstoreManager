namespace BookstoreManager
{
    partial class BanHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.BookNoComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.BookNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.QuantityTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.UnitPriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TotalPriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AddBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PayBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CancelBtn = new MaterialSkin.Controls.MaterialButton();
            this.ResetBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(30, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Enabled = false;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.materialTextBox1.Hint = "Mã hoá đơn";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(30, 82);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(139, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "BH28112301";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Mã khách hàng";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(491, 82);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(144, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Enabled = false;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.Hint = "Ngày tạo";
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(186, 83);
            this.materialMaskedTextBox1.Mask = "00/00/0000";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = true;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 10;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(129, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 3;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "28-11-2023";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // BookNoComboBox
            // 
            this.BookNoComboBox.AutoResize = false;
            this.BookNoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BookNoComboBox.Depth = 0;
            this.BookNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BookNoComboBox.DropDownHeight = 174;
            this.BookNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookNoComboBox.DropDownWidth = 138;
            this.BookNoComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BookNoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BookNoComboBox.FormattingEnabled = true;
            this.BookNoComboBox.Hint = "Mã sách";
            this.BookNoComboBox.IntegralHeight = false;
            this.BookNoComboBox.ItemHeight = 43;
            this.BookNoComboBox.Items.AddRange(new object[] {
            "Chọn sách",
            "MS001",
            "MS002",
            "MS003",
            "MS004"});
            this.BookNoComboBox.Location = new System.Drawing.Point(935, 176);
            this.BookNoComboBox.MaxDropDownItems = 4;
            this.BookNoComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BookNoComboBox.Name = "BookNoComboBox";
            this.BookNoComboBox.Size = new System.Drawing.Size(197, 49);
            this.BookNoComboBox.StartIndex = 0;
            this.BookNoComboBox.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.AutoSize = false;
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.HighEmphasis = true;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.Location = new System.Drawing.Point(932, 381);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Size = new System.Drawing.Size(104, 36);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Xoá";
            this.DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.DeleteBtn.UseAccentColor = false;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.AnimateReadOnly = false;
            this.BookNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookNameTextBox.Depth = 0;
            this.BookNameTextBox.Enabled = false;
            this.BookNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BookNameTextBox.Hint = "Tên sách";
            this.BookNameTextBox.LeadingIcon = null;
            this.BookNameTextBox.Location = new System.Drawing.Point(935, 240);
            this.BookNameTextBox.MaxLength = 50;
            this.BookNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BookNameTextBox.Multiline = false;
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(342, 50);
            this.BookNameTextBox.TabIndex = 6;
            this.BookNameTextBox.Text = "";
            this.BookNameTextBox.TrailingIcon = null;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.AnimateReadOnly = false;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Depth = 0;
            this.QuantityTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityTextBox.Hint = "Số lượng";
            this.QuantityTextBox.LeadingIcon = null;
            this.QuantityTextBox.Location = new System.Drawing.Point(1146, 175);
            this.QuantityTextBox.MaxLength = 50;
            this.QuantityTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityTextBox.Multiline = false;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(131, 50);
            this.QuantityTextBox.TabIndex = 7;
            this.QuantityTextBox.Text = "";
            this.QuantityTextBox.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Enabled = false;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.materialTextBox5.Hint = "Mã nhân viên";
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(331, 82);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(144, 50);
            this.materialTextBox5.TabIndex = 2;
            this.materialTextBox5.Text = "NV001";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.AnimateReadOnly = false;
            this.UnitPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceTextBox.Depth = 0;
            this.UnitPriceTextBox.Enabled = false;
            this.UnitPriceTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UnitPriceTextBox.Hint = "Đơn giá";
            this.UnitPriceTextBox.LeadingIcon = null;
            this.UnitPriceTextBox.Location = new System.Drawing.Point(935, 305);
            this.UnitPriceTextBox.MaxLength = 50;
            this.UnitPriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UnitPriceTextBox.Multiline = false;
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(164, 50);
            this.UnitPriceTextBox.TabIndex = 7;
            this.UnitPriceTextBox.Text = "";
            this.UnitPriceTextBox.TrailingIcon = null;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.AnimateReadOnly = false;
            this.TotalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPriceTextBox.Depth = 0;
            this.TotalPriceTextBox.Enabled = false;
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPriceTextBox.Hint = "Thành tiền";
            this.TotalPriceTextBox.LeadingIcon = null;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(1115, 305);
            this.TotalPriceTextBox.MaxLength = 50;
            this.TotalPriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalPriceTextBox.Multiline = false;
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(164, 50);
            this.TotalPriceTextBox.TabIndex = 7;
            this.TotalPriceTextBox.Text = "";
            this.TotalPriceTextBox.TrailingIcon = null;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = false;
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddBtn.Depth = 0;
            this.AddBtn.HighEmphasis = true;
            this.AddBtn.Icon = null;
            this.AddBtn.Location = new System.Drawing.Point(1173, 381);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddBtn.Size = new System.Drawing.Size(104, 36);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Thêm sách";
            this.AddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddBtn.UseAccentColor = false;
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(931, 624);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Thành tiền";
            // 
            // PayBtn
            // 
            this.PayBtn.AutoSize = false;
            this.PayBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PayBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PayBtn.Depth = 0;
            this.PayBtn.HighEmphasis = true;
            this.PayBtn.Icon = null;
            this.PayBtn.Location = new System.Drawing.Point(935, 666);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PayBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PayBtn.Size = new System.Drawing.Size(342, 36);
            this.PayBtn.TabIndex = 10;
            this.PayBtn.Text = "Thanh toán";
            this.PayBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PayBtn.UseAccentColor = false;
            this.PayBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(1209, 625);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "111,000đ";
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.HighEmphasis = true;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(935, 714);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelBtn.Size = new System.Drawing.Size(342, 36);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Huỷ đơn";
            this.CancelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.CancelBtn.UseAccentColor = false;
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetBtn.AutoSize = false;
            this.ResetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetBtn.Depth = 0;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.HighEmphasis = true;
            this.ResetBtn.Icon = null;
            this.ResetBtn.Location = new System.Drawing.Point(1044, 381);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResetBtn.Size = new System.Drawing.Size(104, 36);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Huỷ";
            this.ResetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.ResetBtn.UseAccentColor = false;
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 789);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BookNoComboBox);
            this.Controls.Add(this.materialMaskedTextBox1);
            this.Controls.Add(this.materialTextBox5);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BanHang";
            this.Text = "Tạo đơn bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialComboBox BookNoComboBox;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private MaterialSkin.Controls.MaterialTextBox BookNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox QuantityTextBox;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox UnitPriceTextBox;
        private MaterialSkin.Controls.MaterialTextBox TotalPriceTextBox;
        private MaterialSkin.Controls.MaterialButton AddBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton PayBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton CancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialButton ResetBtn;
    }
}