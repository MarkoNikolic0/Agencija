namespace WinFormsUI.Forms
{
    partial class StanoviDodajForm
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
            btnDodajStan = new Button();
            Povrsina = new Label();
            PovrsinaTb = new TextBox();
            brojStanaTb = new TextBox();
            brojStana = new Label();
            SuspendLayout();
            // 
            // btnDodajStan
            // 
            btnDodajStan.Location = new Point(171, 109);
            btnDodajStan.Name = "btnDodajStan";
            btnDodajStan.Size = new Size(62, 23);
            btnDodajStan.TabIndex = 0;
            btnDodajStan.Text = "Dodaj";
            btnDodajStan.UseVisualStyleBackColor = true;
            btnDodajStan.Click += btnDodajStan_Click;
            // 
            // Povrsina
            // 
            Povrsina.AutoSize = true;
            Povrsina.Location = new Point(57, 37);
            Povrsina.Name = "Povrsina";
            Povrsina.Size = new Size(52, 15);
            Povrsina.TabIndex = 1;
            Povrsina.Text = "Povrsina";
            // 
            // PovrsinaTb
            // 
            PovrsinaTb.Location = new Point(36, 64);
            PovrsinaTb.Name = "PovrsinaTb";
            PovrsinaTb.Size = new Size(100, 23);
            PovrsinaTb.TabIndex = 2;
            // 
            // brojStanaTb
            // 
            brojStanaTb.Location = new Point(265, 64);
            brojStanaTb.Name = "brojStanaTb";
            brojStanaTb.Size = new Size(100, 23);
            brojStanaTb.TabIndex = 3;
            // 
            // brojStana
            // 
            brojStana.AutoSize = true;
            brojStana.Location = new Point(285, 37);
            brojStana.Name = "brojStana";
            brojStana.Size = new Size(59, 15);
            brojStana.TabIndex = 4;
            brojStana.Text = "Broj stana";
            // 
            // StanoviDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 168);
            Controls.Add(brojStana);
            Controls.Add(brojStanaTb);
            Controls.Add(PovrsinaTb);
            Controls.Add(Povrsina);
            Controls.Add(btnDodajStan);
            Name = "StanoviDodajForm";
            Text = "StanoviDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajStan;
        private Label Povrsina;
        private TextBox PovrsinaTb;
        private TextBox brojStanaTb;
        private Label brojStana;
    }
}