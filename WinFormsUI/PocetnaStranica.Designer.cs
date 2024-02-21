namespace WinFormsUI
{
    partial class PocetnaStranica
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
            this.btnAgencije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgencije
            // 
            this.btnAgencije.Location = new System.Drawing.Point(272, 182);
            this.btnAgencije.Name = "btnAgencije";
            this.btnAgencije.Size = new System.Drawing.Size(170, 67);
            this.btnAgencije.TabIndex = 1;
            this.btnAgencije.Text = "Agencija";
            this.btnAgencije.UseVisualStyleBackColor = true;
            this.btnAgencije.Click += new System.EventHandler(this.btnAgencije_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.btnAgencije);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAgencije;
    }
}