namespace BadanieWzroku.Komponenty
{
    partial class WyborWady
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
            this.label1 = new System.Windows.Forms.Label();
            this.LeftValueTextBox = new System.Windows.Forms.TextBox();
            this.LeftDecreaseButton = new System.Windows.Forms.Button();
            this.LeftIncreaseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RightValueTextBox = new System.Windows.Forms.TextBox();
            this.RightDecreaseButton = new System.Windows.Forms.Button();
            this.RightIncreaseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LeftValueTextBox);
            this.groupBox1.Controls.Add(this.LeftDecreaseButton);
            this.groupBox1.Controls.Add(this.LeftIncreaseButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lewe oko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wada";
            // 
            // LeftValueTextBox
            // 
            this.LeftValueTextBox.Location = new System.Drawing.Point(37, 33);
            this.LeftValueTextBox.Name = "LeftValueTextBox";
            this.LeftValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.LeftValueTextBox.TabIndex = 1;
            this.LeftValueTextBox.TextChanged += new System.EventHandler(this.LeftValueTextBox_TextChanged);
            this.LeftValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeftValueTextBox_KeyDown);
            // 
            // LeftDecreaseButton
            // 
            this.LeftDecreaseButton.Location = new System.Drawing.Point(5, 33);
            this.LeftDecreaseButton.Name = "LeftDecreaseButton";
            this.LeftDecreaseButton.Size = new System.Drawing.Size(26, 23);
            this.LeftDecreaseButton.TabIndex = 0;
            this.LeftDecreaseButton.Text = "▼";
            this.LeftDecreaseButton.UseVisualStyleBackColor = true;
            this.LeftDecreaseButton.Click += new System.EventHandler(this.LeftDecreaseButton_Click);
            // 
            // LeftIncreaseButton
            // 
            this.LeftIncreaseButton.Location = new System.Drawing.Point(143, 33);
            this.LeftIncreaseButton.Name = "LeftIncreaseButton";
            this.LeftIncreaseButton.Size = new System.Drawing.Size(26, 23);
            this.LeftIncreaseButton.TabIndex = 0;
            this.LeftIncreaseButton.Text = "▲";
            this.LeftIncreaseButton.UseVisualStyleBackColor = true;
            this.LeftIncreaseButton.Click += new System.EventHandler(this.LeftIncreaseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RightValueTextBox);
            this.groupBox2.Controls.Add(this.RightDecreaseButton);
            this.groupBox2.Controls.Add(this.RightIncreaseButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(174, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prawe oko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wada";
            // 
            // RightValueTextBox
            // 
            this.RightValueTextBox.Location = new System.Drawing.Point(37, 33);
            this.RightValueTextBox.Name = "RightValueTextBox";
            this.RightValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.RightValueTextBox.TabIndex = 1;
            this.RightValueTextBox.TextChanged += new System.EventHandler(this.RightValueTextBox_TextChanged);
            this.RightValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightValueTextBox_KeyDown);
            // 
            // RightDecreaseButton
            // 
            this.RightDecreaseButton.Location = new System.Drawing.Point(5, 33);
            this.RightDecreaseButton.Name = "RightDecreaseButton";
            this.RightDecreaseButton.Size = new System.Drawing.Size(26, 23);
            this.RightDecreaseButton.TabIndex = 0;
            this.RightDecreaseButton.Text = "▼";
            this.RightDecreaseButton.UseVisualStyleBackColor = true;
            this.RightDecreaseButton.Click += new System.EventHandler(this.RightDecreaseButton_Click);
            // 
            // RightIncreaseButton
            // 
            this.RightIncreaseButton.Location = new System.Drawing.Point(143, 33);
            this.RightIncreaseButton.Name = "RightIncreaseButton";
            this.RightIncreaseButton.Size = new System.Drawing.Size(26, 23);
            this.RightIncreaseButton.TabIndex = 0;
            this.RightIncreaseButton.Text = "▲";
            this.RightIncreaseButton.UseVisualStyleBackColor = true;
            this.RightIncreaseButton.Click += new System.EventHandler(this.RightIncreaseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 74);
            this.panel1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(274, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WyborWady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 137);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "WyborWady";
            this.Text = "WyborWady";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox LeftValueTextBox;
        private Button LeftDecreaseButton;
        private Button LeftIncreaseButton;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox RightValueTextBox;
        private Button RightDecreaseButton;
        private Button RightIncreaseButton;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button button1;
    }
}