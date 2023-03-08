namespace Project
{
    partial class Tagsag_hosszabitas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Uj_tag_letrehoz_button = new System.Windows.Forms.Button();
            this.Edzo_label = new System.Windows.Forms.Label();
            this.TagsagHosszabittas_TagID_textBox = new System.Windows.Forms.TextBox();
            this.TagId_label = new System.Windows.Forms.Label();
            this.FoKepernyo_valtozo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoKepernyo_valtozo_panel
            // 
            this.FoKepernyo_valtozo_panel.BackColor = System.Drawing.Color.LightGray;
            this.FoKepernyo_valtozo_panel.Controls.Add(this.listBox1);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Uj_tag_letrehoz_button);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Edzo_label);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagsagHosszabittas_TagID_textBox);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.TagId_label);
            this.FoKepernyo_valtozo_panel.Location = new System.Drawing.Point(0, 0);
            this.FoKepernyo_valtozo_panel.Name = "FoKepernyo_valtozo_panel";
            this.FoKepernyo_valtozo_panel.Size = new System.Drawing.Size(998, 406);
            this.FoKepernyo_valtozo_panel.TabIndex = 3;
            this.FoKepernyo_valtozo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.FoKepernyo_valtozo_panel_Paint);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "30",
            "60",
            "90"});
            this.listBox1.Location = new System.Drawing.Point(367, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 27);
            this.listBox1.TabIndex = 37;
            // 
            // Uj_tag_letrehoz_button
            // 
            this.Uj_tag_letrehoz_button.Location = new System.Drawing.Point(385, 240);
            this.Uj_tag_letrehoz_button.Name = "Uj_tag_letrehoz_button";
            this.Uj_tag_letrehoz_button.Size = new System.Drawing.Size(149, 45);
            this.Uj_tag_letrehoz_button.TabIndex = 31;
            this.Uj_tag_letrehoz_button.Text = "Submit";
            this.Uj_tag_letrehoz_button.UseVisualStyleBackColor = true;
            this.Uj_tag_letrehoz_button.Click += new System.EventHandler(this.Uj_tag_letrehoz_button_Click);
            // 
            // Edzo_label
            // 
            this.Edzo_label.AutoSize = true;
            this.Edzo_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edzo_label.Location = new System.Drawing.Point(367, 138);
            this.Edzo_label.Name = "Edzo_label";
            this.Edzo_label.Size = new System.Drawing.Size(54, 21);
            this.Edzo_label.TabIndex = 29;
            this.Edzo_label.Text = "Hossz:";
            // 
            // TagsagHosszabittas_TagID_textBox
            // 
            this.TagsagHosszabittas_TagID_textBox.Location = new System.Drawing.Point(367, 88);
            this.TagsagHosszabittas_TagID_textBox.Name = "TagsagHosszabittas_TagID_textBox";
            this.TagsagHosszabittas_TagID_textBox.Size = new System.Drawing.Size(213, 23);
            this.TagsagHosszabittas_TagID_textBox.TabIndex = 28;
            this.TagsagHosszabittas_TagID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TagsagHosszabittas_TagID_textBox_KeyPress);
            // 
            // TagId_label
            // 
            this.TagId_label.AutoSize = true;
            this.TagId_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagId_label.Location = new System.Drawing.Point(367, 64);
            this.TagId_label.Name = "TagId_label";
            this.TagId_label.Size = new System.Drawing.Size(55, 21);
            this.TagId_label.TabIndex = 27;
            this.TagId_label.Text = "Tag ID:";
            // 
            // Tagsag_hosszabitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 367);
            this.Controls.Add(this.FoKepernyo_valtozo_panel);
            this.Name = "Tagsag_hosszabitas";
            this.Text = "Tagsag_hosszabitas";
            this.FoKepernyo_valtozo_panel.ResumeLayout(false);
            this.FoKepernyo_valtozo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FoKepernyo_valtozo_panel;
        private Button Uj_tag_letrehoz_button;
        private Label Edzo_label;
        private TextBox TagsagHosszabittas_TagID_textBox;
        private Label TagId_label;
        private ListBox listBox1;
    }
}