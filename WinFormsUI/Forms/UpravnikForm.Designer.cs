namespace WinFormsUI.Forms
{
    partial class UpravnikForm
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
            btnDodajUpravnika = new Button();
            listView1 = new ListView();
            JMBG = new ColumnHeader();
            Ime = new ColumnHeader();
            ImeRoditelja = new ColumnHeader();
            Prezime = new ColumnHeader();
            DatumRodjenja = new ColumnHeader();
            BrojLicneKarte = new ColumnHeader();
            MestoIzdavanja = new ColumnHeader();
            BrojTelefona = new ColumnHeader();
            Adresa = new ColumnHeader();
            Institucija = new ColumnHeader();
            Zvanje = new ColumnHeader();
            DatumSticanja = new ColumnHeader();
            Licenca = new ColumnHeader();
            btnPrikaziUpravnike = new Button();
            btnIzmeniUpravnike = new Button();
            btnObrisiUpravnika = new Button();
            IdUpravnika = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDodajUpravnika
            // 
            btnDodajUpravnika.Location = new Point(757, 42);
            btnDodajUpravnika.Margin = new Padding(3, 2, 3, 2);
            btnDodajUpravnika.Name = "btnDodajUpravnika";
            btnDodajUpravnika.Size = new Size(130, 22);
            btnDodajUpravnika.TabIndex = 0;
            btnDodajUpravnika.Text = "Dodaj Upravnika";
            btnDodajUpravnika.UseVisualStyleBackColor = true;
            btnDodajUpravnika.Click += btnDodajUpravnika_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdUpravnika ,JMBG, Ime, ImeRoditelja, Prezime, DatumRodjenja, BrojLicneKarte, MestoIzdavanja, BrojTelefona, Adresa, Institucija, Zvanje, DatumSticanja, Licenca});
            listView1.FullRowSelect = true;
            listView1.Location = new Point(10, 18);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(704, 217);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // JMBG
            // 
            JMBG.DisplayIndex = 1;
            JMBG.Text = "JMBG";
            // 
            // Ime
            // 
            Ime.DisplayIndex = 2;
            Ime.Text = "Ime";
            // 
            // ImeRoditelja
            // 
            ImeRoditelja.DisplayIndex = 3;
            ImeRoditelja.Text = "ImeRoditelja";
            // 
            // Prezime
            // 
            Prezime.DisplayIndex = 4;
            Prezime.Text = "Prezime";
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DisplayIndex = 5;
            DatumRodjenja.Text = "DatumRodjenja";
            // 
            // BrojLicneKarte
            // 
            BrojLicneKarte.DisplayIndex = 6;
            BrojLicneKarte.Text = "BrojLicneKarte";
            // 
            // MestoIzdavanja
            // 
            MestoIzdavanja.DisplayIndex = 7;
            MestoIzdavanja.Text = "MestoIzdavanja";
            // 
            // BrojTelefona
            // 
            BrojTelefona.DisplayIndex = 8;
            BrojTelefona.Text = "BrojTelefona";
            // 
            // Adresa
            // 
            Adresa.DisplayIndex = 9;
            Adresa.Text = "Adresa";
            // 
            // Institucija
            // 
            Institucija.DisplayIndex = 10;
            Institucija.Text = "Institucija";
            // 
            // Zvanje
            // 
            Zvanje.DisplayIndex = 11;
            Zvanje.Text = "Zvanje";
            // 
            // DatumSticanja
            // 
            DatumSticanja.DisplayIndex = 12;
            DatumSticanja.Text = "DatumSticanja";
            // 
            // Licenca
            // 
            Licenca.DisplayIndex = 13;
            Licenca.Text = "Licenca";
            // 
            // btnPrikaziUpravnike
            // 
            btnPrikaziUpravnike.Location = new Point(757, 18);
            btnPrikaziUpravnike.Margin = new Padding(3, 2, 3, 2);
            btnPrikaziUpravnike.Name = "btnPrikaziUpravnike";
            btnPrikaziUpravnike.Size = new Size(130, 20);
            btnPrikaziUpravnike.TabIndex = 2;
            btnPrikaziUpravnike.Text = "Prikazi Upravnike";
            btnPrikaziUpravnike.UseVisualStyleBackColor = true;
            btnPrikaziUpravnike.Click += btnPrikaziUpravnike_Click;
            // 
            // btnIzmeniUpravnike
            // 
            btnIzmeniUpravnike.Location = new Point(757, 68);
            btnIzmeniUpravnike.Margin = new Padding(3, 2, 3, 2);
            btnIzmeniUpravnike.Name = "btnIzmeniUpravnike";
            btnIzmeniUpravnike.Size = new Size(130, 22);
            btnIzmeniUpravnike.TabIndex = 3;
            btnIzmeniUpravnike.Text = "Izmeni Upravnika";
            btnIzmeniUpravnike.UseVisualStyleBackColor = true;
            btnIzmeniUpravnike.Click += btnIzmeniUpravnike_Click;
            // 
            // btnObrisiUpravnika
            // 
            btnObrisiUpravnika.Location = new Point(757, 94);
            btnObrisiUpravnika.Margin = new Padding(3, 2, 3, 2);
            btnObrisiUpravnika.Name = "btnObrisiUpravnika";
            btnObrisiUpravnika.Size = new Size(130, 22);
            btnObrisiUpravnika.TabIndex = 4;
            btnObrisiUpravnika.Text = "Obrisi Upravnika";
            btnObrisiUpravnika.UseVisualStyleBackColor = true;
            btnObrisiUpravnika.Click += btnObrisiUpravnika_Click;
            // 
            // IdUpravnika
            // 
            IdUpravnika.DisplayIndex = 0;
            IdUpravnika.Text = "Id";
            // 
            // UpravnikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 338);
            Controls.Add(btnObrisiUpravnika);
            Controls.Add(btnIzmeniUpravnike);
            Controls.Add(btnPrikaziUpravnike);
            Controls.Add(listView1);
            Controls.Add(btnDodajUpravnika);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpravnikForm";
            Text = "UpravnikForm";
            Load += UpravnikForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDodajUpravnika;
        private ListView listView1;
        private Button btnPrikaziUpravnike;
        private Button btnIzmeniUpravnike;
        private ColumnHeader JMBG;
        private ColumnHeader Ime;
        private ColumnHeader ImeRoditelja;
        private ColumnHeader Prezime;
        private ColumnHeader DatumRodjenja;
        private ColumnHeader BrojLicneKarte;
        private ColumnHeader MestoIzdavanja;
        private ColumnHeader BrojTelefona;
        private ColumnHeader Adresa;
        private ColumnHeader Institucija;
        private ColumnHeader Zvanje;
        private ColumnHeader DatumSticanja;
        private ColumnHeader Licenca;
        private Button btnObrisiUpravnika;
        private ColumnHeader IdUpravnika;
    }
}