namespace Project
{
    partial class Tagsag_vasarlas_tagnak
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
            this.Tagsag_vasarlas_button = new System.Windows.Forms.Button();
            this.Tagsag_label = new System.Windows.Forms.Label();
            this.TagsagVasarlas_TagId_textBox = new System.Windows.Forms.TextBox();
            this.TagId_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FoKepernyo_valtozo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoKepernyo_valtozo_panel
            // 
            this.FoKepernyo_valtozo_panel.BackColor = System.Drawing.Color.LightGray;
            this.FoKepernyo_valtozo_panel.Controls.Add(this.listBox1);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Tagsag_vasarlas_button);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Tagsag_label);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagsagVasarlas_TagId_textBox);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagId_label);
            this.FoKepernyo_valtozo_panel.Location = new System.Drawing.Point(0, 0);
            this.FoKepernyo_valtozo_panel.Name = "FoKepernyo_valtozo_panel";
            this.FoKepernyo_valtozo_panel.Size = new System.Drawing.Size(998, 406);
            this.FoKepernyo_valtozo_panel.TabIndex = 3;
            // 
            // Tagsag_vasarlas_button
            // 
            this.Tagsag_vasarlas_button.Location = new System.Drawing.Point(387, 223);
            this.Tagsag_vasarlas_button.Name = "Tagsag_vasarlas_button";
            this.Tagsag_vasarlas_button.Size = new System.Drawing.Size(122, 47);
            this.Tagsag_vasarlas_button.TabIndex = 35;
            this.Tagsag_vasarlas_button.Text = "Submit";
            this.Tagsag_vasarlas_button.UseVisualStyleBackColor = true;
            this.Tagsag_vasarlas_button.Click += new System.EventHandler(this.Tagsag_vasarlas_button_Click);
            // 
            // Tagsag_label
            // 
            this.Tagsag_label.AutoSize = true;
            this.Tagsag_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tagsag_label.Location = new System.Drawing.Point(356, 137);
            this.Tagsag_label.Name = "Tagsag_label";
            this.Tagsag_label.Size = new System.Drawing.Size(60, 21);
            this.Tagsag_label.TabIndex = 33;
            this.Tagsag_label.Text = "Tagsag:";
            // 
            // TagsagVasarlas_TagId_textBox
            // 
            this.TagsagVasarlas_TagId_textBox.Location = new System.Drawing.Point(356, 87);
            this.TagsagVasarlas_TagId_textBox.Name = "TagsagVasarlas_TagId_textBox";
            this.TagsagVasarlas_TagId_textBox.Size = new System.Drawing.Size(213, 23);
            this.TagsagVasarlas_TagId_textBox.TabIndex = 32;
            this.TagsagVasarlas_TagId_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TagsagVasarlas_TagId_textBox_KeyPress);
            // 
            // TagId_label
            // 
            this.TagId_label.AutoSize = true;
            this.TagId_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagId_label.Location = new System.Drawing.Point(356, 63);
            this.TagId_label.Name = "TagId_label";
            this.TagId_label.Size = new System.Drawing.Size(55, 21);
            this.TagId_label.TabIndex = 31;
            this.TagId_label.Text = "Tag ID:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "Sima",
            "Edzos"});
            this.listBox1.Location = new System.Drawing.Point(356, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 27);
            this.listBox1.TabIndex = 36;
            // 
            // Tagsag_vasarlas_tagnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 367);
            this.Controls.Add(this.FoKepernyo_valtozo_panel);
            this.Name = "Tagsag_vasarlas_tagnak";
            this.Text = "Tagsag_vasarlas_tagnak";
            this.FoKepernyo_valtozo_panel.ResumeLayout(false);
            this.FoKepernyo_valtozo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FoKepernyo_valtozo_panel;
        private Button Tagsag_vasarlas_button;
        private Label Tagsag_label;
        private TextBox TagsagVasarlas_TagId_textBox;
        private Label TagId_label;
        private ListBox listBox1;
    }
}