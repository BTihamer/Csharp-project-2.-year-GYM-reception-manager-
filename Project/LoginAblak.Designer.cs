namespace Project
{
    partial class LoginAblak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAblak));
            this.LOGIN_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LOGIN_button = new System.Windows.Forms.Button();
            this.PASSWORD_TextBox = new System.Windows.Forms.TextBox();
            this.USERNAME_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.USERNAME_LABEL = new System.Windows.Forms.Label();
            this.LOGIN_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LOGIN_panel
            // 
            this.LOGIN_panel.BackColor = System.Drawing.Color.Silver;
            this.LOGIN_panel.Controls.Add(this.pictureBox1);
            this.LOGIN_panel.Controls.Add(this.groupBox1);
            this.LOGIN_panel.Location = new System.Drawing.Point(0, 0);
            this.LOGIN_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LOGIN_panel.Name = "LOGIN_panel";
            this.LOGIN_panel.Size = new System.Drawing.Size(1141, 695);
            this.LOGIN_panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LOGIN_button);
            this.groupBox1.Controls.Add(this.PASSWORD_TextBox);
            this.groupBox1.Controls.Add(this.USERNAME_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.USERNAME_LABEL);
            this.groupBox1.Location = new System.Drawing.Point(370, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(425, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-215, -375);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2213, 1453);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN_button
            // 
            this.LOGIN_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LOGIN_button.BackgroundImage")));
            this.LOGIN_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LOGIN_button.Location = new System.Drawing.Point(71, 357);
            this.LOGIN_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LOGIN_button.Name = "LOGIN_button";
            this.LOGIN_button.Size = new System.Drawing.Size(285, 87);
            this.LOGIN_button.TabIndex = 4;
            this.LOGIN_button.Text = "LOGIN";
            this.LOGIN_button.UseVisualStyleBackColor = true;
            this.LOGIN_button.Click += new System.EventHandler(this.LOGIN_button_Click);
            // 
            // PASSWORD_TextBox
            // 
            this.PASSWORD_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PASSWORD_TextBox.Location = new System.Drawing.Point(25, 249);
            this.PASSWORD_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PASSWORD_TextBox.Multiline = true;
            this.PASSWORD_TextBox.Name = "PASSWORD_TextBox";
            this.PASSWORD_TextBox.PasswordChar = '*';
            this.PASSWORD_TextBox.Size = new System.Drawing.Size(311, 48);
            this.PASSWORD_TextBox.TabIndex = 3;
            // 
            // USERNAME_TextBox
            // 
            this.USERNAME_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.USERNAME_TextBox.Location = new System.Drawing.Point(25, 112);
            this.USERNAME_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.USERNAME_TextBox.Multiline = true;
            this.USERNAME_TextBox.Name = "USERNAME_TextBox";
            this.USERNAME_TextBox.Size = new System.Drawing.Size(311, 48);
            this.USERNAME_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD";
            // 
            // USERNAME_LABEL
            // 
            this.USERNAME_LABEL.AutoSize = true;
            this.USERNAME_LABEL.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.USERNAME_LABEL.Location = new System.Drawing.Point(19, 60);
            this.USERNAME_LABEL.Name = "USERNAME_LABEL";
            this.USERNAME_LABEL.Size = new System.Drawing.Size(161, 37);
            this.USERNAME_LABEL.TabIndex = 0;
            this.USERNAME_LABEL.Text = "USERNAME:";
            // 
            // LoginAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 692);
            this.Controls.Add(this.LOGIN_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginAblak";
            this.Text = "Edzo_terem";
            this.LOGIN_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LOGIN_panel;
        private GroupBox groupBox1;
        private TextBox USERNAME_TextBox;
        private Label label1;
        private Label USERNAME_LABEL;
        private TextBox PASSWORD_TextBox;
        private Button LOGIN_button;
        private PictureBox pictureBox1;
    }
}