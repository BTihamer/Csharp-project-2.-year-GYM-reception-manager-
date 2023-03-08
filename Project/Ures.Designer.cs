namespace Project
{
    partial class Ures
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
            this.FoKepernyo_valtozo_panel = new System.Windows.Forms.Panel();
            this.Szoveg_label = new System.Windows.Forms.Label();
            this.Clock_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FoKepernyo_valtozo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoKepernyo_valtozo_panel
            // 
            this.FoKepernyo_valtozo_panel.BackColor = System.Drawing.Color.LightGray;
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Clock_label);
            this.FoKepernyo_valtozo_panel.Controls.Add(this.Szoveg_label);
            this.FoKepernyo_valtozo_panel.Location = new System.Drawing.Point(0, 0);
            this.FoKepernyo_valtozo_panel.Name = "FoKepernyo_valtozo_panel";
            this.FoKepernyo_valtozo_panel.Size = new System.Drawing.Size(998, 406);
            this.FoKepernyo_valtozo_panel.TabIndex = 3;
            // 
            // Szoveg_label
            // 
            this.Szoveg_label.AutoSize = true;
            this.Szoveg_label.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Szoveg_label.Location = new System.Drawing.Point(5, 51);
            this.Szoveg_label.Name = "Szoveg_label";
            this.Szoveg_label.Size = new System.Drawing.Size(966, 81);
            this.Szoveg_label.TabIndex = 0;
            this.Szoveg_label.Text = " \"Make It Happen. Shock Everyone\"";
            // 
            // Clock_label
            // 
            this.Clock_label.AutoSize = true;
            this.Clock_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clock_label.Location = new System.Drawing.Point(363, 164);
            this.Clock_label.Name = "Clock_label";
            this.Clock_label.Size = new System.Drawing.Size(222, 65);
            this.Clock_label.TabIndex = 1;
            this.Clock_label.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 370);
            this.Controls.Add(this.FoKepernyo_valtozo_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ures";
            this.Text = "Ures";
            this.Load += new System.EventHandler(this.Ures_Load);
            this.FoKepernyo_valtozo_panel.ResumeLayout(false);
            this.FoKepernyo_valtozo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FoKepernyo_valtozo_panel;
        private Label Clock_label;
        private Label Szoveg_label;
        private System.Windows.Forms.Timer timer1;
    }
}