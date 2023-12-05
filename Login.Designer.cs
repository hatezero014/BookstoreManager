namespace BookstoreManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txbPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txbUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(423, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(214, 41);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "UIT Bookstore";
            // 
            // txbPass
            // 
            this.txbPass.AcceptsTab = true;
            this.txbPass.AnimateReadOnly = false;
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Depth = 0;
            this.txbPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbPass.Hint = "Mật khẩu";
            this.txbPass.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txbPass.LeadingIcon")));
            this.txbPass.Location = new System.Drawing.Point(421, 258);
            this.txbPass.MaxLength = 50;
            this.txbPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txbPass.Multiline = false;
            this.txbPass.Name = "txbPass";
            this.txbPass.Password = true;
            this.txbPass.Size = new System.Drawing.Size(349, 50);
            this.txbPass.TabIndex = 3;
            this.txbPass.Text = "";
            this.txbPass.TrailingIcon = null;
            // 
            // txbUsername
            // 
            this.txbUsername.AnimateReadOnly = false;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Depth = 0;
            this.txbUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbUsername.Hint = "Tên đăng nhập";
            this.txbUsername.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txbUsername.LeadingIcon")));
            this.txbUsername.Location = new System.Drawing.Point(421, 192);
            this.txbUsername.MaxLength = 50;
            this.txbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txbUsername.Multiline = false;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(349, 50);
            this.txbUsername.TabIndex = 2;
            this.txbUsername.Text = "";
            this.txbUsername.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(650, 340);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(120, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Đăng nhập";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 441);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txbPass;
        private MaterialSkin.Controls.MaterialTextBox txbUsername;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}