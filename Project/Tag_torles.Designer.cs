namespace Project
{
    partial class Tag_torles
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
            this.FoKepernyo_valtozo_panel = new System.Windows.Forms.Panel();
            this.Tag_torles_button = new System.Windows.Forms.Button();
            this.TagsagTorles_TagID_textBox = new System.Windows.Forms.TextBox();
            this.TagId_label = new System.Windows.Forms.Label();
            this.FoKepernyo_valtozo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoKepernyo_valtozo_panel
            // 
            this.FoKepernyo_valtozo_panel.BackColor = System.Drawing.Color.LightGray;
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Tag_torles_button);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagsagTorles_TagID_textBox);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagId_label);
            this.FoKepernyo_valtozo_panel.Location = new System.Drawing.Point(0, 0);
            this.FoKepernyo_valtozo_panel.Name = "FoKepernyo_valtozo_panel";
            this.FoKepernyo_valtozo_panel.Size = new System.Drawing.Size(998, 406);
            this.FoKepernyo_valtozo_panel.TabIndex = 4;
            // 
            // Tag_torles_button
            // 
            this.Tag_torles_button.Location = new System.Drawing.Point(415, 190);
            this.Tag_torles_button.Name = "Tag_torles_button";
            this.Tag_torles_button.Size = new System.Drawing.Size(129, 47);
            this.Tag_torles_button.TabIndex = 23;
            this.Tag_torles_button.Text = "Submit";
            this.Tag_torles_button.UseVisualStyleBackColor = true;
            this.Tag_torles_button.Click += new System.EventHandler(this.Tag_torles_button_Click);
            // 
            // TagsagTorles_TagID_textBox
            // 
            this.TagsagTorles_TagID_textBox.Location = new System.Drawing.Point(377, 142);
            this.TagsagTorles_TagID_textBox.Name = "TagsagTorles_TagID_textBox";
            this.TagsagTorles_TagID_textBox.Size = new System.Drawing.Size(213, 23);
            this.TagsagTorles_TagID_textBox.TabIndex = 22;
            this.TagsagTorles_TagID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TagsagTorles_TagID_textBox_KeyPress);
            // 
            // TagId_label
            // 
            this.TagId_label.AutoSize = true;
            this.TagId_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagId_label.Location = new System.Drawing.Point(377, 108);
            this.TagId_label.Name = "TagId_label";
            this.TagId_label.Size = new System.Drawing.Size(55, 21);
            this.TagId_label.TabIndex = 21;
            this.TagId_label.Text = "Tag_ID";
            // 
            // Tag_torles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 367);
            this.Controls.Add(this.FoKepernyo_valtozo_panel);
            this.Name = "Tag_torles";
            this.Text = "Tag_torles";
            this.FoKepernyo_valtozo_panel.ResumeLayout(false);
            this.FoKepernyo_valtozo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FoKepernyo_valtozo_panel;
        private Button Tag_torles_button;
        private TextBox TagsagTorles_TagID_textBox;
        private Label TagId_label;
    }
}