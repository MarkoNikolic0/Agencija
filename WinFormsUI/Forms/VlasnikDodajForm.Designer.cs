namespace WinFormsUI.Forms
{
    partial class VlasnikDodajForm
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
            JMBG = new Label();
            label2 = new Label();
            Prezime = new Label();
            Ime = new Label();
            BrojTelefona = new Label();
            Funkcija = new Label();
            Adresa = new Label();
            adresaTb = new TextBox();
            brojTelefonaTb = new TextBox();
            prezimeTb = new TextBox();
            imeRoditeljatb = new TextBox();
            imeTb = new TextBox();
            jmbgTb = new TextBox();
            funkcijaTb = new TextBox();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(178, 233);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // JMBG
            // 
            JMBG.AutoSize = true;
            JMBG.Location = new Point(49, 9);
            JMBG.Name = "JMBG";
            JMBG.Size = new Size(37, 15);
            JMBG.TabIndex = 1;
            JMBG.Text = "JMBG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Ime roditelja";
            // 
            // Prezime
            // 
            Prezime.AutoSize = true;
            Prezime.Location = new Point(37, 216);
            Prezime.Name = "Prezime";
            Prezime.Size = new Size(49, 15);
            Prezime.TabIndex = 3;
            Prezime.Text = "Prezime";
            // 
            // Ime
            // 
            Ime.AutoSize = true;
            Ime.Location = new Point(49, 76);
            Ime.Name = "Ime";
            Ime.Size = new Size(27, 15);
            Ime.TabIndex = 4;
            Ime.Text = "Ime";
            // 
            // BrojTelefona
            // 
            BrojTelefona.AutoSize = true;
            BrojTelefona.Location = new Point(178, 9);
            BrojTelefona.Name = "BrojTelefona";
            BrojTelefona.Size = new Size(74, 15);
            BrojTelefona.TabIndex = 5;
            BrojTelefona.Text = "Broj telefona";
            // 
            // Funkcija
            // 
            Funkcija.AutoSize = true;
            Funkcija.Location = new Point(190, 145);
            Funkcija.Name = "Funkcija";
            Funkcija.Size = new Size(51, 15);
            Funkcija.TabIndex = 6;
            Funkcija.Text = "Funkcija";
            // 
            // Adresa
            // 
            Adresa.AutoSize = true;
            Adresa.Location = new Point(190, 76);
            Adresa.Name = "Adresa";
            Adresa.Size = new Size(43, 15);
            Adresa.TabIndex = 7;
            Adresa.Text = "Adresa";
            // 
            // adresaTb
            // 
            adresaTb.Location = new Point(165, 94);
            adresaTb.Name = "adresaTb";
            adresaTb.Size = new Size(100, 23);
            adresaTb.TabIndex = 8;
            // 
            // brojTelefonaTb
            // 
            brojTelefonaTb.Location = new Point(165, 27);
            brojTelefonaTb.Name = "brojTelefonaTb";
            brojTelefonaTb.Size = new Size(100, 23);
            brojTelefonaTb.TabIndex = 9;
            // 
            // prezimeTb
            // 
            prezimeTb.Location = new Point(12, 234);
            prezimeTb.Name = "prezimeTb";
            prezimeTb.Size = new Size(100, 23);
            prezimeTb.TabIndex = 10;
            // 
            // imeRoditeljatb
            // 
            imeRoditeljatb.Location = new Point(12, 163);
            imeRoditeljatb.Name = "imeRoditeljatb";
            imeRoditeljatb.Size = new Size(100, 23);
            imeRoditeljatb.TabIndex = 11;
            // 
            // imeTb
            // 
            imeTb.Location = new Point(12, 94);
            imeTb.Name = "imeTb";
            imeTb.Size = new Size(100, 23);
            imeTb.TabIndex = 12;
            // 
            // jmbgTb
            // 
            jmbgTb.Location = new Point(12, 27);
            jmbgTb.Name = "jmbgTb";
            jmbgTb.Size = new Size(100, 23);
            jmbgTb.TabIndex = 13;
            // 
            // funkcijaTb
            // 
            funkcijaTb.Location = new Point(165, 163);
            funkcijaTb.Name = "funkcijaTb";
            funkcijaTb.Size = new Size(100, 23);
            funkcijaTb.TabIndex = 14;
            // 
            // VlasnikDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 295);
            Controls.Add(funkcijaTb);
            Controls.Add(jmbgTb);
            Controls.Add(imeTb);
            Controls.Add(imeRoditeljatb);
            Controls.Add(prezimeTb);
            Controls.Add(brojTelefonaTb);
            Controls.Add(adresaTb);
            Controls.Add(Adresa);
            Controls.Add(Funkcija);
            Controls.Add(BrojTelefona);
            Controls.Add(Ime);
            Controls.Add(Prezime);
            Controls.Add(label2);
            Controls.Add(JMBG);
            Controls.Add(btnDodaj);
            Name = "VlasnikDodajForm";
            Text = "VlasnikDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private Label JMBG;
        private Label label2;
        private Label Prezime;
        private Label Ime;
        private Label BrojTelefona;
        private Label Funkcija;
        private Label Adresa;
        private TextBox adresaTb;
        private TextBox brojTelefonaTb;
        private TextBox prezimeTb;
        private TextBox imeRoditeljatb;
        private TextBox imeTb;
        private TextBox jmbgTb;
        private TextBox funkcijaTb;
    }
}