namespace BadanieWzroku.Komponenty
{
    partial class Podsumowanie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrawaWadaLabel = new System.Windows.Forms.Label();
            this.LewaWadaLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WadaSnellenaLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BarwaFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MarkaLabel = new System.Windows.Forms.Label();
            this.KolorLabel = new System.Windows.Forms.Label();
            this.SoczewkiLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrawaWadaLabel);
            this.groupBox1.Controls.Add(this.LewaWadaLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybrana wada wzroku";
            // 
            // PrawaWadaLabel
            // 
            this.PrawaWadaLabel.AutoSize = true;
            this.PrawaWadaLabel.Location = new System.Drawing.Point(12, 74);
            this.PrawaWadaLabel.Name = "PrawaWadaLabel";
            this.PrawaWadaLabel.Size = new System.Drawing.Size(76, 15);
            this.PrawaWadaLabel.TabIndex = 1;
            this.PrawaWadaLabel.Text = "Prawa wada: ";
            // 
            // LewaWadaLabel
            // 
            this.LewaWadaLabel.AutoSize = true;
            this.LewaWadaLabel.Location = new System.Drawing.Point(12, 19);
            this.LewaWadaLabel.Name = "LewaWadaLabel";
            this.LewaWadaLabel.Size = new System.Drawing.Size(71, 15);
            this.LewaWadaLabel.TabIndex = 0;
            this.LewaWadaLabel.Text = "Lewa wada: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WadaSnellenaLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(680, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Badania wady tablicą Snellena";
            // 
            // WadaSnellenaLabel
            // 
            this.WadaSnellenaLabel.AutoSize = true;
            this.WadaSnellenaLabel.Location = new System.Drawing.Point(6, 19);
            this.WadaSnellenaLabel.Name = "WadaSnellenaLabel";
            this.WadaSnellenaLabel.Size = new System.Drawing.Size(91, 15);
            this.WadaSnellenaLabel.TabIndex = 0;
            this.WadaSnellenaLabel.Text = "Wybrana wada: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BarwaFLP);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 506);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Badanie wzroku - barwa";
            // 
            // BarwaFLP
            // 
            this.BarwaFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarwaFLP.Location = new System.Drawing.Point(3, 19);
            this.BarwaFLP.Name = "BarwaFLP";
            this.BarwaFLP.Size = new System.Drawing.Size(674, 484);
            this.BarwaFLP.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SoczewkiLabel);
            this.groupBox4.Controls.Add(this.KolorLabel);
            this.groupBox4.Controls.Add(this.MarkaLabel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(680, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 506);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wybrane okulary";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 506);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 223);
            this.panel1.TabIndex = 5;
            // 
            // MarkaLabel
            // 
            this.MarkaLabel.AutoSize = true;
            this.MarkaLabel.Location = new System.Drawing.Point(6, 19);
            this.MarkaLabel.Name = "MarkaLabel";
            this.MarkaLabel.Size = new System.Drawing.Size(46, 15);
            this.MarkaLabel.TabIndex = 0;
            this.MarkaLabel.Text = "Marka: ";
            // 
            // KolorLabel
            // 
            this.KolorLabel.AutoSize = true;
            this.KolorLabel.Location = new System.Drawing.Point(6, 34);
            this.KolorLabel.Name = "KolorLabel";
            this.KolorLabel.Size = new System.Drawing.Size(41, 15);
            this.KolorLabel.TabIndex = 1;
            this.KolorLabel.Text = "Kolor: ";
            // 
            // SoczewkiLabel
            // 
            this.SoczewkiLabel.AutoSize = true;
            this.SoczewkiLabel.Location = new System.Drawing.Point(6, 49);
            this.SoczewkiLabel.Name = "SoczewkiLabel";
            this.SoczewkiLabel.Size = new System.Drawing.Size(61, 15);
            this.SoczewkiLabel.TabIndex = 2;
            this.SoczewkiLabel.Text = "Soczewki: ";
            // 
            // Podsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Podsumowanie";
            this.Text = "Podsumowanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Panel panel2;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private Label PrawaWadaLabel;
        private Label LewaWadaLabel;
        private Label WadaSnellenaLabel;
        private FlowLayoutPanel BarwaFLP;
        private Label SoczewkiLabel;
        private Label KolorLabel;
        private Label MarkaLabel;
    }
}