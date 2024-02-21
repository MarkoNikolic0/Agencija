namespace WinFormsUI.Forms
{
    partial class UpravnikDodajForm
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
            lblJMBG = new Label();
            tbJMBG = new TextBox();
            tbIme = new TextBox();
            tbImeRoditelja = new TextBox();
            tbBrLk = new TextBox();
            tbPrezime = new TextBox();
            tbDatumRodjenja = new TextBox();
            tbAdresa = new TextBox();
            tbMestoIzdavanja = new TextBox();
            tbBrTel = new TextBox();
            label1 = new Label();
            ImeRoditelja = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDodaj = new Button();
            label11 = new Label();
            tbLicencaId = new TextBox();
            label8 = new Label();
            tbInstitucija = new TextBox();
            label10 = new Label();
            tb = new Label();
            tbDatumSticanja = new TextBox();
            tbZvanje = new TextBox();
            SuspendLayout();
            // 
            // lblJMBG
            // 
            lblJMBG.AutoSize = true;
            lblJMBG.Location = new Point(35, 37);
            lblJMBG.Name = "lblJMBG";
            lblJMBG.Size = new Size(37, 15);
            lblJMBG.TabIndex = 0;
            lblJMBG.Text = "JMBG";
            lblJMBG.Click += lblJMBG_Click;
            // 
            // tbJMBG
            // 
            tbJMBG.Location = new Point(140, 32);
            tbJMBG.Margin = new Padding(3, 2, 3, 2);
            tbJMBG.Name = "tbJMBG";
            tbJMBG.Size = new Size(110, 23);
            tbJMBG.TabIndex = 1;
            tbJMBG.TextChanged += tbJMBG_TextChanged;
            // 
            // tbIme
            // 
            tbIme.Location = new Point(140, 74);
            tbIme.Margin = new Padding(3, 2, 3, 2);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(110, 23);
            tbIme.TabIndex = 2;
            tbIme.TextChanged += tbIme_TextChanged;
            // 
            // tbImeRoditelja
            // 
            tbImeRoditelja.Location = new Point(140, 118);
            tbImeRoditelja.Margin = new Padding(3, 2, 3, 2);
            tbImeRoditelja.Name = "tbImeRoditelja";
            tbImeRoditelja.Size = new Size(110, 23);
            tbImeRoditelja.TabIndex = 3;
            tbImeRoditelja.TextChanged += tbImeRoditelja_TextChanged;
            // 
            // tbBrLk
            // 
            tbBrLk.Location = new Point(140, 257);
            tbBrLk.Margin = new Padding(3, 2, 3, 2);
            tbBrLk.Name = "tbBrLk";
            tbBrLk.Size = new Size(110, 23);
            tbBrLk.TabIndex = 4;
            tbBrLk.TextChanged += tbBrLk_TextChanged;
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(140, 159);
            tbPrezime.Margin = new Padding(3, 2, 3, 2);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(110, 23);
            tbPrezime.TabIndex = 4;
            tbPrezime.TextChanged += tbPrezime_TextChanged;
            // 
            // tbDatumRodjenja
            // 
            tbDatumRodjenja.Location = new Point(140, 203);
            tbDatumRodjenja.Margin = new Padding(3, 2, 3, 2);
            tbDatumRodjenja.Name = "tbDatumRodjenja";
            tbDatumRodjenja.Size = new Size(110, 23);
            tbDatumRodjenja.TabIndex = 5;
            tbDatumRodjenja.TextChanged += tbDatumRodjenja_TextChanged;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(453, 118);
            tbAdresa.Margin = new Padding(3, 2, 3, 2);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(110, 23);
            tbAdresa.TabIndex = 6;
            tbAdresa.TextChanged += tbAdresa_TextChanged;
            // 
            // tbMestoIzdavanja
            // 
            tbMestoIzdavanja.Location = new Point(453, 32);
            tbMestoIzdavanja.Margin = new Padding(3, 2, 3, 2);
            tbMestoIzdavanja.Name = "tbMestoIzdavanja";
            tbMestoIzdavanja.Size = new Size(110, 23);
            tbMestoIzdavanja.TabIndex = 6;
            tbMestoIzdavanja.TextChanged += tbMestoIzdavanja_TextChanged;
            // 
            // tbBrTel
            // 
            tbBrTel.Location = new Point(453, 74);
            tbBrTel.Margin = new Padding(3, 2, 3, 2);
            tbBrTel.Name = "tbBrTel";
            tbBrTel.Size = new Size(110, 23);
            tbBrTel.TabIndex = 7;
            tbBrTel.TextChanged += tbBrTel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 80);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 9;
            label1.Text = "Ime";
            label1.Click += label1_Click;
            // 
            // ImeRoditelja
            // 
            ImeRoditelja.AutoSize = true;
            ImeRoditelja.Location = new Point(35, 123);
            ImeRoditelja.Name = "ImeRoditelja";
            ImeRoditelja.Size = new Size(73, 15);
            ImeRoditelja.TabIndex = 10;
            ImeRoditelja.Text = "ImeRoditelja";
            ImeRoditelja.Click += ImeRoditelja_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 164);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Prezime";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 208);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 12;
            label3.Text = "DatumRodjenja";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 262);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 13;
            label4.Text = "BrojLicneKarte";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 37);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 14;
            label5.Text = "MestoIzdavanja";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 80);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 15;
            label6.Text = "BrojTelefona";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 123);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 16;
            label7.Text = "Adresa";
            label7.Click += label7_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(453, 323);
            btnDodaj.Margin = new Padding(3, 2, 3, 2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(174, 38);
            btnDodaj.TabIndex = 22;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 310);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 23;
            label11.Text = "LicencaId";
            label11.Click += label11_Click;
            // 
            // tbLicencaId
            // 
            tbLicencaId.Location = new Point(140, 307);
            tbLicencaId.Margin = new Padding(3, 2, 3, 2);
            tbLicencaId.Name = "tbLicencaId";
            tbLicencaId.Size = new Size(110, 23);
            tbLicencaId.TabIndex = 24;
            tbLicencaId.TextChanged += tbLicencaId_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 164);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 17;
            label8.Text = "Institucija";
            label8.Click += label8_Click;
            // 
            // tbInstitucija
            // 
            tbInstitucija.Location = new Point(453, 159);
            tbInstitucija.Margin = new Padding(3, 2, 3, 2);
            tbInstitucija.Name = "tbInstitucija";
            tbInstitucija.Size = new Size(110, 23);
            tbInstitucija.TabIndex = 8;
            tbInstitucija.TextChanged += tbInstitucija_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 259);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 28;
            label10.Text = "DatumSticanja";
            // 
            // tb
            // 
            tb.AutoSize = true;
            tb.Location = new Point(334, 211);
            tb.Name = "tb";
            tb.Size = new Size(42, 15);
            tb.TabIndex = 27;
            tb.Text = "Zvanje";
            // 
            // tbDatumSticanja
            // 
            tbDatumSticanja.Location = new Point(453, 254);
            tbDatumSticanja.Margin = new Padding(3, 2, 3, 2);
            tbDatumSticanja.Name = "tbDatumSticanja";
            tbDatumSticanja.Size = new Size(110, 23);
            tbDatumSticanja.TabIndex = 26;
            // 
            // tbZvanje
            // 
            tbZvanje.Location = new Point(453, 205);
            tbZvanje.Margin = new Padding(3, 2, 3, 2);
            tbZvanje.Name = "tbZvanje";
            tbZvanje.Size = new Size(110, 23);
            tbZvanje.TabIndex = 25;
            // 
            // UpravnikDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 372);
            Controls.Add(label10);
            Controls.Add(tb);
            Controls.Add(tbDatumSticanja);
            Controls.Add(tbZvanje);
            Controls.Add(tbLicencaId);
            Controls.Add(label11);
            Controls.Add(btnDodaj);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ImeRoditelja);
            Controls.Add(label1);
            Controls.Add(tbInstitucija);
            Controls.Add(tbBrTel);
            Controls.Add(tbMestoIzdavanja);
            Controls.Add(tbAdresa);
            Controls.Add(tbDatumRodjenja);
            Controls.Add(tbPrezime);
            Controls.Add(tbBrLk);
            Controls.Add(tbImeRoditelja);
            Controls.Add(tbIme);
            Controls.Add(tbJMBG);
            Controls.Add(lblJMBG);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpravnikDodajForm";
            Text = "UpravnikDodajForm";
            Load += UpravnikDodajForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJMBG;
        private TextBox tbJMBG;
        private TextBox tbIme;
        private TextBox tbImeRoditelja;
        private TextBox tbBrLk;
        private TextBox tbPrezime;
        private TextBox tbDatumRodjenja;
        private TextBox tbAdresa;
        private TextBox tbMestoIzdavanja;
        private TextBox tbBrTel;
        private Label label1;
        private Label ImeRoditelja;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDodaj;
        private Label label11;
        private TextBox tbLicencaId;
        private Label label8;
        private TextBox tbInstitucija;
        private Label label10;
        private Label tb;
        private TextBox tbDatumSticanja;
        private TextBox tbZvanje;
    }
}