namespace BadanieWzroku.Komponenty
{
    partial class BadanieWzrokuBarwaTablica
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
            this.TablicaPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnswerFourButton = new System.Windows.Forms.Button();
            this.AnswerThreeButton = new System.Windows.Forms.Button();
            this.AnswerTwoButton = new System.Windows.Forms.Button();
            this.AnswerOneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablicaPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablicaPictureBox
            // 
            this.TablicaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablicaPictureBox.Image = global::BadanieWzroku.Properties.Resources._01;
            this.TablicaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TablicaPictureBox.Name = "TablicaPictureBox";
            this.TablicaPictureBox.Size = new System.Drawing.Size(800, 579);
            this.TablicaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TablicaPictureBox.TabIndex = 0;
            this.TablicaPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnswerFourButton);
            this.groupBox1.Controls.Add(this.AnswerThreeButton);
            this.groupBox1.Controls.Add(this.AnswerTwoButton);
            this.groupBox1.Controls.Add(this.AnswerOneButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odpowiedź:";
            // 
            // AnswerFourButton
            // 
            this.AnswerFourButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AnswerFourButton.Location = new System.Drawing.Point(597, 19);
            this.AnswerFourButton.Name = "AnswerFourButton";
            this.AnswerFourButton.Size = new System.Drawing.Size(198, 78);
            this.AnswerFourButton.TabIndex = 3;
            this.AnswerFourButton.Text = "21";
            this.AnswerFourButton.UseVisualStyleBackColor = true;
            this.AnswerFourButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerThreeButton
            // 
            this.AnswerThreeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AnswerThreeButton.Location = new System.Drawing.Point(399, 19);
            this.AnswerThreeButton.Name = "AnswerThreeButton";
            this.AnswerThreeButton.Size = new System.Drawing.Size(198, 78);
            this.AnswerThreeButton.TabIndex = 2;
            this.AnswerThreeButton.Text = "12";
            this.AnswerThreeButton.UseVisualStyleBackColor = true;
            this.AnswerThreeButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerTwoButton
            // 
            this.AnswerTwoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AnswerTwoButton.Location = new System.Drawing.Point(201, 19);
            this.AnswerTwoButton.Name = "AnswerTwoButton";
            this.AnswerTwoButton.Size = new System.Drawing.Size(198, 78);
            this.AnswerTwoButton.TabIndex = 1;
            this.AnswerTwoButton.Text = "9";
            this.AnswerTwoButton.UseVisualStyleBackColor = true;
            this.AnswerTwoButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerOneButton
            // 
            this.AnswerOneButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AnswerOneButton.Location = new System.Drawing.Point(3, 19);
            this.AnswerOneButton.Name = "AnswerOneButton";
            this.AnswerOneButton.Size = new System.Drawing.Size(198, 78);
            this.AnswerOneButton.TabIndex = 0;
            this.AnswerOneButton.Text = "15";
            this.AnswerOneButton.UseVisualStyleBackColor = true;
            this.AnswerOneButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // BadanieWzrokuBarwaTablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 679);
            this.Controls.Add(this.TablicaPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "BadanieWzrokuBarwaTablica";
            this.Text = "BadanieWzrokuBarwaTablica";
            ((System.ComponentModel.ISupportInitialize)(this.TablicaPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox TablicaPictureBox;
        private GroupBox groupBox1;
        private Button AnswerFourButton;
        private Button AnswerThreeButton;
        private Button AnswerTwoButton;
        private Button AnswerOneButton;
    }
}