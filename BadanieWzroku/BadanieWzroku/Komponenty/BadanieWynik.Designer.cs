namespace BadanieWzroku.Komponenty
{
    partial class BadanieWynik
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label.Location = new System.Drawing.Point(0, 292);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(311, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "test";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(311, 292);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // BadanieWynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Label);
            this.Name = "BadanieWynik";
            this.Size = new System.Drawing.Size(311, 307);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Label;
        private PictureBox pb;
    }
}
