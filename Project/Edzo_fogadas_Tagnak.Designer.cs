namespace Project
{
    partial class Edzo_fogadas_Tagnak
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
            this.Edzes_fogadas_tagnak_label = new System.Windows.Forms.Panel();
            this.Edzo_fogadas_tagnak_button = new System.Windows.Forms.Button();
            this.Edzo_label = new System.Windows.Forms.Label();
            this.UJ_tag_NEV_textBox = new System.Windows.Forms.TextBox();
            this.TagId_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Edzes_fogadas_tagnak_label.SuspendLayout();
            this.SuspendLayout();
            // 
            // Edzes_fogadas_tagnak_label
            // 
            this.Edzes_fogadas_tagnak_label.BackColor = System.Drawing.Color.LightGray;
            this.Edzes_fogadas_tagnak_label.Controls.Add(this.listBox1);
            this.Edzes_fogadas_tagnak_label.Controls.Add(this.Edzo_fogadas_tagnak_button);
            this.Edzes_fogadas_tagnak_label.Controls.Add(this.Edzo_label);
            this.Edzes_fogadas_tagnak_label.Controls.Add(this.UJ_tag_NEV_textBox);
            this.Edzes_fogadas_tagnak_label.Controls.Add(this.TagId_label);
            this.Edzes_fogadas_tagnak_label.Location = new System.Drawing.Point(3, 0);
            this.Edzes_fogadas_tagnak_label.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edzes_fogadas_tagnak_label.Name = "Edzes_fogadas_tagnak_label";
            this.Edzes_fogadas_tagnak_label.Size = new System.Drawing.Size(998, 406);
            this.Edzes_fogadas_tagnak_label.TabIndex = 0;
            // 
            // Edzo_fogadas_tagnak_button
            // 
            this.Edzo_fogadas_tagnak_button.Location = new System.Drawing.Point(380, 206);
            this.Edzo_fogadas_tagnak_button.Name = "Edzo_fogadas_tagnak_button";
            this.Edzo_fogadas_tagnak_button.Size = new System.Drawing.Size(129, 47);
            this.Edzo_fogadas_tagnak_button.TabIndex = 20;
            this.Edzo_fogadas_tagnak_button.Text = "Submit";
            this.Edzo_fogadas_tagnak_button.UseVisualStyleBackColor = true;
            this.Edzo_fogadas_tagnak_button.Click += new System.EventHandler(this.Edzo_fogadas_tagnak_button_Click);
            // 
            // Edzo_label
            // 
            this.Edzo_label.AutoSize = true;
            this.Edzo_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edzo_label.Location = new System.Drawing.Point(353, 140);
            this.Edzo_label.Name = "Edzo_label";
            this.Edzo_label.Size = new System.Drawing.Size(46, 21);
            this.Edzo_label.TabIndex = 17;
            this.Edzo_label.Text = "Edzo:";
            // 
            // UJ_tag_NEV_textBox
            // 
            this.UJ_tag_NEV_textBox.Location = new System.Drawing.Point(353, 99);
            this.UJ_tag_NEV_textBox.Name = "UJ_tag_NEV_textBox";
            this.UJ_tag_NEV_textBox.Size = new System.Drawing.Size(213, 23);
            this.UJ_tag_NEV_textBox.TabIndex = 16;
            this.UJ_tag_NEV_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UJ_tag_NEV_textBox_KeyPress);
            // 
            // TagId_label
            // 
            this.TagId_label.AutoSize = true;
            this.TagId_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagId_label.Location = new System.Drawing.Point(353, 66);
            this.TagId_label.Name = "TagId_label";
            this.TagId_label.Size = new System.Drawing.Size(55, 21);
            this.TagId_label.TabIndex = 15;
            this.TagId_label.Text = "Tag_ID";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Nagy Janos",
            "Kiss Laszlo",
            "Bodor Lorant",
            "Nagy Agnes",
            "Peter Abigel"});
            this.listBox1.Location = new System.Drawing.Point(353, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 25);
            this.listBox1.TabIndex = 21;
            // 
            // Edzo_fogadas_Tagnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 370);
            this.Controls.Add(this.Edzes_fogadas_tagnak_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edzo_fogadas_Tagnak";
            this.ShowInTaskbar = false;
            this.Text = "Edzo_fogadas_Tagnak";
            this.Edzes_fogadas_tagnak_label.ResumeLayout(false);
            this.Edzes_fogadas_tagnak_label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Edzes_fogadas_tagnak_label;
        private Label Edzo_label;
        private TextBox UJ_tag_NEV_textBox;
        private Label TagId_label;
        private Button Edzo_fogadas_tagnak_button;
        private ListBox listBox1;
    }
}