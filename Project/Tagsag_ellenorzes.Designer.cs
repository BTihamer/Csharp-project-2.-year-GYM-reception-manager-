namespace Project
{
    partial class Tagsag_ellenorzes
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
            this.Edzo_fogadas_tagnak_button = new System.Windows.Forms.Button();
            this.TagsagEllenorzes_TagID_textBox = new System.Windows.Forms.TextBox();
            this.TagId_label = new System.Windows.Forms.Label();
            this.FoKepernyo_valtozo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoKepernyo_valtozo_panel
            // 
            this.FoKepernyo_valtozo_panel.BackColor = System.Drawing.Color.LightGray;
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Edzo_fogadas_tagnak_button);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagsagEllenorzes_TagID_textBox);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagId_label);
            this.FoKepernyo_valtozo_panel.Location = new System.Drawing.Point(0, 0);
            this.FoKepernyo_valtozo_panel.Name = "FoKepernyo_valtozo_panel";
            this.FoKepernyo_valtozo_panel.Size = new System.Drawing.Size(998, 406);
            this.FoKepernyo_valtozo_panel.TabIndex = 3;
            // 
            // Edzo_fogadas_tagnak_button
            // 
            this.Edzo_fogadas_tagnak_button.Location = new System.Drawing.Point(415, 190);
            this.Edzo_fogadas_tagnak_button.Name = "Edzo_fogadas_tagnak_button";
            this.Edzo_fogadas_tagnak_button.Size = new System.Drawing.Size(129, 47);
            this.Edzo_fogadas_tagnak_button.TabIndex = 23;
            this.Edzo_fogadas_tagnak_button.Text = "Submit";
            this.Edzo_fogadas_tagnak_button.UseVisualStyleBackColor = true;
            this.Edzo_fogadas_tagnak_button.Click += new System.EventHandler(this.Edzo_fogadas_tagnak_button_Click);
            // 
            // TagsagEllenorzes_TagID_textBox
            // 
            this.TagsagEllenorzes_TagID_textBox.Location = new System.Drawing.Point(377, 142);
            this.TagsagEllenorzes_TagID_textBox.Name = "TagsagEllenorzes_TagID_textBox";
            this.TagsagEllenorzes_TagID_textBox.Size = new System.Drawing.Size(213, 23);
            this.TagsagEllenorzes_TagID_textBox.TabIndex = 22;
            this.TagsagEllenorzes_TagID_textBox.TextChanged += new System.EventHandler(this.TagsagEllenorzes_TagID_textBox_TextChanged);
            this.TagsagEllenorzes_TagID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TagsagEllenorzes_TagID_textBox_KeyPress);
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
            this.TagId_label.Click += new System.EventHandler(this.TagId_label_Click);
            // 
            // Tagsag_ellenorzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 367);
            this.Controls.Add(this.FoKepernyo_valtozo_panel);
            this.Name = "Tagsag_ellenorzes";
            this.Text = "Tagsag_ellenorzes";
            this.FoKepernyo_valtozo_panel.ResumeLayout(false);
            this.FoKepernyo_valtozo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FoKepernyo_valtozo_panel;
        private Button Edzo_fogadas_tagnak_button;
        private TextBox TagsagEllenorzes_TagID_textBox;
        private Label TagId_label;
    }
}