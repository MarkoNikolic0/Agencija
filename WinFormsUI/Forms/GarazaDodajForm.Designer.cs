namespace WinFormsUI.Forms
{
    partial class GarazaDodajForm
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
            btnDodaj = new Button();
            redniBrojTb = new TextBox();
            redniBroj = new Label();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(59, 104);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(63, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // redniBrojTb
            // 
            redniBrojTb.Location = new Point(59, 66);
            redniBrojTb.Name = "redniBrojTb";
            redniBrojTb.Size = new Size(63, 23);
            redniBrojTb.TabIndex = 4;
            // 
            // redniBroj
            // 
            redniBroj.AutoSize = true;
            redniBroj.Location = new Point(59, 37);
            redniBroj.Name = "redniBroj";
            redniBroj.Size = new Size(61, 15);
            redniBroj.TabIndex = 3;
            redniBroj.Text = "Redni broj";
            // 
            // GarazaDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 176);
            Controls.Add(btnDodaj);
            Controls.Add(redniBrojTb);
            Controls.Add(redniBroj);
            Name = "GarazaDodajForm";
            Text = "GarazaDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private TextBox redniBrojTb;
        private Label redniBroj;
    }
}