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
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.AddBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 157);
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
            this.materialTextBox1.Location = new System.Drawing.Point(33, 88);
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
            this.materialTextBox2.Location = new System.Drawing.Point(494, 88);
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
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(189, 89);
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
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Enabled = false;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.materialTextBox5.Hint = "Mã nhân viên";
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(334, 88);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(144, 50);
            this.materialTextBox5.TabIndex = 2;
            this.materialTextBox5.Text = "NV001";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(934, 630);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Thành tiền";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(938, 672);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(342, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Thanh toán";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(1212, 631);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "111,000đ";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(938, 720);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(342, 36);
            this.materialButton3.TabIndex = 10;
            this.materialButton3.Text = "Huỷ bỏ";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(939, 166);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(299, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Nhập thông tin sách để thêm vào hoá đơn";
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = false;
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddBtn.Depth = 0;
            this.AddBtn.HighEmphasis = true;
            this.AddBtn.Icon = null;
            this.AddBtn.Location = new System.Drawing.Point(1176, 482);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddBtn.Size = new System.Drawing.Size(104, 36);
            this.AddBtn.TabIndex = 38;
            this.AddBtn.Text = "Thêm sách";
            this.AddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddBtn.UseAccentColor = false;
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.AnimateReadOnly = false;
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Enabled = false;
            this.materialTextBox7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox7.Hint = "Thành tiền";
            this.materialTextBox7.LeadingIcon = null;
            this.materialTextBox7.Location = new System.Drawing.Point(938, 406);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(342, 50);
            this.materialTextBox7.TabIndex = 35;
            this.materialTextBox7.Text = "";
            this.materialTextBox7.TrailingIcon = null;
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.Hint = "Đơn giá";
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(938, 339);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(175, 50);
            this.materialTextBox6.TabIndex = 34;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.AnimateReadOnly = false;
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.materialTextBox9.Hint = "Kho";
            this.materialTextBox9.LeadingIcon = null;
            this.materialTextBox9.Location = new System.Drawing.Point(1128, 209);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(152, 50);
            this.materialTextBox9.TabIndex = 36;
            this.materialTextBox9.Text = "0";
            this.materialTextBox9.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.Hint = "Số lượng";
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(1128, 339);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(152, 50);
            this.materialTextBox4.TabIndex = 37;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.AnimateReadOnly = false;
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Enabled = false;
            this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox8.Hint = "Mã sách";
            this.materialTextBox8.LeadingIcon = null;
            this.materialTextBox8.Location = new System.Drawing.Point(938, 209);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(175, 50);
            this.materialTextBox8.TabIndex = 32;
            this.materialTextBox8.Text = "";
            this.materialTextBox8.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Enabled = false;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Tên sách";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(938, 274);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(342, 50);
            this.materialTextBox3.TabIndex = 33;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1047, 482);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(104, 36);
            this.materialButton1.TabIndex = 31;
            this.materialButton1.Text = "Huỷ chọn";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
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
            this.DeleteBtn.Location = new System.Drawing.Point(938, 482);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Size = new System.Drawing.Size(101, 36);
            this.DeleteBtn.TabIndex = 30;
            this.DeleteBtn.Text = "Xoá";
            this.DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.DeleteBtn.UseAccentColor = false;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 789);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.materialTextBox7);
            this.Controls.Add(this.materialTextBox6);
            this.Controls.Add(this.materialTextBox9);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialTextBox8);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialLabel1);
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
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton AddBtn;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
    }
}