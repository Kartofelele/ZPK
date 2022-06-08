namespace BadanieWzroku.Komponenty
{
    partial class WyborOkularow
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
            this.label1 = new System.Windows.Forms.Label();
            this.MarkiComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KoloryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoczewkiComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // MarkiComboBox
            // 
            this.MarkiComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarkiComboBox.FormattingEnabled = true;
            this.MarkiComboBox.Location = new System.Drawing.Point(3, 34);
            this.MarkiComboBox.Name = "MarkiComboBox";
            this.MarkiComboBox.Size = new System.Drawing.Size(205, 23);
            this.MarkiComboBox.TabIndex = 1;
            this.MarkiComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kolor";
            // 
            // KoloryComboBox
            // 
            this.KoloryComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.KoloryComboBox.FormattingEnabled = true;
            this.KoloryComboBox.Location = new System.Drawing.Point(3, 72);
            this.KoloryComboBox.Name = "KoloryComboBox";
            this.KoloryComboBox.Size = new System.Drawing.Size(205, 23);
            this.KoloryComboBox.TabIndex = 1;
            this.KoloryComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soczewki";
            // 
            // SoczewkiComboBox
            // 
            this.SoczewkiComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SoczewkiComboBox.FormattingEnabled = true;
            this.SoczewkiComboBox.Location = new System.Drawing.Point(3, 110);
            this.SoczewkiComboBox.Name = "SoczewkiComboBox";
            this.SoczewkiComboBox.Size = new System.Drawing.Size(205, 23);
            this.SoczewkiComboBox.TabIndex = 1;
            this.SoczewkiComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SoczewkiComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.KoloryComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MarkiComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 127);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje";
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(3, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(205, 105);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WyborOkularow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 265);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "WyborOkularow";
            this.Text = "WyborOkularow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox MarkiComboBox;
        private Label label2;
        private ComboBox KoloryComboBox;
        private Label label3;
        private ComboBox SoczewkiComboBox;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button SaveButton;
    }
}