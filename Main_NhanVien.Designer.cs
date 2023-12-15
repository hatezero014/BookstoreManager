namespace BookstoreManager
{
    partial class Main_NhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_NhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.HomepageTab = new System.Windows.Forms.TabPage();
            this.BookTab = new System.Windows.Forms.TabPage();
            this.ReceiptTab = new System.Windows.Forms.TabPage();
            this.Receipt_DataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Receipt_SearchBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.Receipt_DataGridView = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ImportTab = new System.Windows.Forms.TabPage();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.AccountTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.EmployeeTabControl.SuspendLayout();
            this.ReceiptTab.SuspendLayout();
            this.Receipt_DataPanel.SuspendLayout();
            this.Receipt_SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Receipt_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeTabControl
            // 
            this.EmployeeTabControl.Controls.Add(this.HomepageTab);
            this.EmployeeTabControl.Controls.Add(this.BookTab);
            this.EmployeeTabControl.Controls.Add(this.ReceiptTab);
            this.EmployeeTabControl.Controls.Add(this.ImportTab);
            this.EmployeeTabControl.Controls.Add(this.CustomerTab);
            this.EmployeeTabControl.Controls.Add(this.AccountTab);
            this.EmployeeTabControl.Depth = 0;
            this.EmployeeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTabControl.ImageList = this.imageList1;
            this.EmployeeTabControl.ItemSize = new System.Drawing.Size(132, 42);
            this.EmployeeTabControl.Location = new System.Drawing.Point(0, 80);
            this.EmployeeTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeTabControl.Multiline = true;
            this.EmployeeTabControl.Name = "EmployeeTabControl";
            this.EmployeeTabControl.SelectedIndex = 0;
            this.EmployeeTabControl.Size = new System.Drawing.Size(1401, 898);
            this.EmployeeTabControl.TabIndex = 1;
            this.EmployeeTabControl.SelectedIndexChanged += new System.EventHandler(this.EmployeeTabControl_SelectedIndexChanged);
            // 
            // HomepageTab
            // 
            this.HomepageTab.ImageKey = "home_FILL0_wght400_GRAD0_opsz24.png";
            this.HomepageTab.Location = new System.Drawing.Point(4, 46);
            this.HomepageTab.Name = "HomepageTab";
            this.HomepageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomepageTab.Size = new System.Drawing.Size(1393, 848);
            this.HomepageTab.TabIndex = 4;
            this.HomepageTab.Text = "Trang chủ";
            this.HomepageTab.UseVisualStyleBackColor = true;
            // 
            // BookTab
            // 
            this.BookTab.ImageKey = "book_4_FILL0_wght400_GRAD0_opsz24.png";
            this.BookTab.Location = new System.Drawing.Point(4, 46);
            this.BookTab.Name = "BookTab";
            this.BookTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookTab.Size = new System.Drawing.Size(1393, 848);
            this.BookTab.TabIndex = 1;
            this.BookTab.Text = "Sách";
            this.BookTab.UseVisualStyleBackColor = true;
            // 
            // ReceiptTab
            // 
            this.ReceiptTab.Controls.Add(this.Receipt_DataPanel);
            this.ReceiptTab.ImageKey = "unarchive_FILL0_wght400_GRAD0_opsz24.png";
            this.ReceiptTab.Location = new System.Drawing.Point(4, 46);
            this.ReceiptTab.Name = "ReceiptTab";
            this.ReceiptTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiptTab.Size = new System.Drawing.Size(1393, 848);
            this.ReceiptTab.TabIndex = 0;
            this.ReceiptTab.Text = "Bán hàng";
            this.ReceiptTab.UseVisualStyleBackColor = true;
            // 
            // Receipt_DataPanel
            // 
            this.Receipt_DataPanel.ColumnCount = 1;
            this.Receipt_DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1387F));
            this.Receipt_DataPanel.Controls.Add(this.Receipt_SearchBarPanel, 0, 0);
            this.Receipt_DataPanel.Controls.Add(this.Receipt_DataGridView, 0, 2);
            this.Receipt_DataPanel.Controls.Add(this.materialLabel1, 0, 1);
            this.Receipt_DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Receipt_DataPanel.Location = new System.Drawing.Point(3, 3);
            this.Receipt_DataPanel.Name = "Receipt_DataPanel";
            this.Receipt_DataPanel.RowCount = 3;
            this.Receipt_DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Receipt_DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Receipt_DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Receipt_DataPanel.Size = new System.Drawing.Size(1387, 842);
            this.Receipt_DataPanel.TabIndex = 2;
            // 
            // Receipt_SearchBarPanel
            // 
            this.Receipt_SearchBarPanel.ColumnCount = 2;
            this.Receipt_SearchBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66128F));
            this.Receipt_SearchBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.Receipt_SearchBarPanel.Controls.Add(this.materialButton1, 1, 0);
            this.Receipt_SearchBarPanel.Controls.Add(this.materialTextBox21, 0, 0);
            this.Receipt_SearchBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Receipt_SearchBarPanel.Location = new System.Drawing.Point(3, 3);
            this.Receipt_SearchBarPanel.Name = "Receipt_SearchBarPanel";
            this.Receipt_SearchBarPanel.RowCount = 1;
            this.Receipt_SearchBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Receipt_SearchBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.Receipt_SearchBarPanel.Size = new System.Drawing.Size(1381, 56);
            this.Receipt_SearchBarPanel.TabIndex = 1;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(1250, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(127, 44);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Tìm kiếm";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = true;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTextBox21.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Nhập mã hoá đơn";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(3, 3);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(1240, 48);
            this.materialTextBox21.TabIndex = 3;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // Receipt_DataGridView
            // 
            this.Receipt_DataGridView.AllowUserToAddRows = false;
            this.Receipt_DataGridView.AllowUserToDeleteRows = false;
            this.Receipt_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Receipt_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Receipt_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Receipt_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Receipt_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Receipt_DataGridView.Location = new System.Drawing.Point(3, 98);
            this.Receipt_DataGridView.Name = "Receipt_DataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Receipt_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Receipt_DataGridView.RowHeadersWidth = 51;
            this.Receipt_DataGridView.RowTemplate.Height = 24;
            this.Receipt_DataGridView.Size = new System.Drawing.Size(1381, 741);
            this.Receipt_DataGridView.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.Location = new System.Drawing.Point(3, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1381, 33);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Chọn một hoá đơn để xem chi tiết";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportTab
            // 
            this.ImportTab.ImageKey = "archive_FILL0_wght400_GRAD0_opsz24.png";
            this.ImportTab.Location = new System.Drawing.Point(4, 46);
            this.ImportTab.Name = "ImportTab";
            this.ImportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportTab.Size = new System.Drawing.Size(1393, 848);
            this.ImportTab.TabIndex = 3;
            this.ImportTab.Text = "Nhập sách";
            this.ImportTab.UseVisualStyleBackColor = true;
            // 
            // CustomerTab
            // 
            this.CustomerTab.ImageKey = "digital_wellbeing_FILL0_wght400_GRAD0_opsz24.png";
            this.CustomerTab.Location = new System.Drawing.Point(4, 46);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(1393, 848);
            this.CustomerTab.TabIndex = 2;
            this.CustomerTab.Text = "Khách hàng";
            this.CustomerTab.UseVisualStyleBackColor = true;
            // 
            // AccountTab
            // 
            this.AccountTab.ImageKey = "account_circle_FILL0_wght400_GRAD0_opsz24.png";
            this.AccountTab.Location = new System.Drawing.Point(4, 46);
            this.AccountTab.Name = "AccountTab";
            this.AccountTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountTab.Size = new System.Drawing.Size(1393, 848);
            this.AccountTab.TabIndex = 5;
            this.AccountTab.Text = "Tài khoản";
            this.AccountTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(1, "book_4_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(2, "unarchive_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(3, "archive_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(4, "digital_wellbeing_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList1.Images.SetKeyName(5, "account_circle_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // Main_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 981);
            this.Controls.Add(this.EmployeeTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.EmployeeTabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Name = "Main_Employee";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 3, 3);
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.EmployeeTabControl.ResumeLayout(false);
            this.ReceiptTab.ResumeLayout(false);
            this.Receipt_DataPanel.ResumeLayout(false);
            this.Receipt_DataPanel.PerformLayout();
            this.Receipt_SearchBarPanel.ResumeLayout(false);
            this.Receipt_SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Receipt_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl EmployeeTabControl;
        private System.Windows.Forms.TabPage HomepageTab;
        private System.Windows.Forms.TabPage BookTab;
        private System.Windows.Forms.TabPage ReceiptTab;
        private System.Windows.Forms.TableLayoutPanel Receipt_DataPanel;
        private System.Windows.Forms.TableLayoutPanel Receipt_SearchBarPanel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private System.Windows.Forms.DataGridView Receipt_DataGridView;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage ImportTab;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.TabPage AccountTab;
        private System.Windows.Forms.ImageList imageList1;
    }
}