namespace WinFormsUI.Forms
{
    partial class ZgradaForm
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
            btnPrikaziZgrade = new Button();
            listView1 = new ListView();
            Id = new ColumnHeader();
            Adresa = new ColumnHeader();
            btnObrisiZgradu = new Button();
            btnDodajZgradu = new Button();
            btnUlazi = new Button();
            btnLiftovi = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnStambeniProstor = new Button();
            btnPoslovniProstor = new Button();
            btnGaraza = new Button();
            SuspendLayout();
            // 
            // btnPrikaziZgrade
            // 
            btnPrikaziZgrade.Location = new Point(578, 11);
            btnPrikaziZgrade.Margin = new Padding(3, 2, 3, 2);
            btnPrikaziZgrade.Name = "btnPrikaziZgrade";
            btnPrikaziZgrade.Size = new Size(110, 24);
            btnPrikaziZgrade.TabIndex = 0;
            btnPrikaziZgrade.Text = "Prikazi Zgrade";
            btnPrikaziZgrade.UseVisualStyleBackColor = true;
            btnPrikaziZgrade.Click += btnPrikaziZgrade_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Adresa });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(23, 11);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(353, 214);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa";
            Adresa.Width = 200;
            // 
            // btnObrisiZgradu
            // 
            btnObrisiZgradu.Location = new Point(139, 238);
            btnObrisiZgradu.Margin = new Padding(3, 2, 3, 2);
            btnObrisiZgradu.Name = "btnObrisiZgradu";
            btnObrisiZgradu.Size = new Size(110, 24);
            btnObrisiZgradu.TabIndex = 2;
            btnObrisiZgradu.Text = "Obrisi Zgradu";
            btnObrisiZgradu.UseVisualStyleBackColor = true;
            btnObrisiZgradu.Click += button1_Click;
            // 
            // btnDodajZgradu
            // 
            btnDodajZgradu.Location = new Point(23, 238);
            btnDodajZgradu.Margin = new Padding(3, 2, 3, 2);
            btnDodajZgradu.Name = "btnDodajZgradu";
            btnDodajZgradu.Size = new Size(110, 24);
            btnDodajZgradu.TabIndex = 6;
            btnDodajZgradu.Text = "Dodaj Zgradu";
            btnDodajZgradu.UseVisualStyleBackColor = true;
            btnDodajZgradu.Click += btnDodajZgradu_Click;
            // 
            // btnUlazi
            // 
            btnUlazi.Location = new Point(578, 39);
            btnUlazi.Margin = new Padding(3, 2, 3, 2);
            btnUlazi.Name = "btnUlazi";
            btnUlazi.Size = new Size(110, 24);
            btnUlazi.TabIndex = 8;
            btnUlazi.Text = "Prikazi ulaze";
            btnUlazi.UseVisualStyleBackColor = true;
            btnUlazi.Click += btnUlazi_Click;
            // 
            // btnLiftovi
            // 
            btnLiftovi.Location = new Point(578, 97);
            btnLiftovi.Margin = new Padding(3, 2, 3, 2);
            btnLiftovi.Name = "btnLiftovi";
            btnLiftovi.Size = new Size(110, 22);
            btnLiftovi.TabIndex = 7;
            btnLiftovi.Text = "Prikazi Liftove";
            btnLiftovi.UseVisualStyleBackColor = true;
            btnLiftovi.Click += btnLiftovi_ClickAsync;
            // 
            // button1
            // 
            button1.Location = new Point(578, 68);
            button1.Name = "button1";
            button1.Size = new Size(110, 24);
            button1.TabIndex = 9;
            button1.Text = "Prikazi stanove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnStanovi_ClickAsync;
            // 
            // button2
            // 
            button2.Location = new Point(578, 124);
            button2.Name = "button2";
            button2.Size = new Size(110, 39);
            button2.TabIndex = 10;
            button2.Text = "Prikazi parking mesta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnParkingMesta_ClickAsync;
            // 
            // button3
            // 
            button3.Location = new Point(578, 169);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 11;
            button3.Text = "Prikazi lokale";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnLokali_ClickAsync;
            // 
            // btnStambeniProstor
            // 
            btnStambeniProstor.Location = new Point(391, 12);
            btnStambeniProstor.Name = "btnStambeniProstor";
            btnStambeniProstor.Size = new Size(110, 23);
            btnStambeniProstor.TabIndex = 12;
            btnStambeniProstor.Text = "Stambeni Prostor";
            btnStambeniProstor.UseCompatibleTextRendering = true;
            btnStambeniProstor.UseVisualStyleBackColor = true;
            btnStambeniProstor.Click += btnStambeniProstor_Click;
            // 
            // btnPoslovniProstor
            // 
            btnPoslovniProstor.Location = new Point(391, 40);
            btnPoslovniProstor.Name = "btnPoslovniProstor";
            btnPoslovniProstor.Size = new Size(110, 22);
            btnPoslovniProstor.TabIndex = 13;
            btnPoslovniProstor.Text = "Poslovni prostor";
            btnPoslovniProstor.UseVisualStyleBackColor = true;
            btnPoslovniProstor.Click += btnPoslovniProstor_Click;
            // 
            // btnGaraza
            // 
            btnGaraza.Location = new Point(391, 69);
            btnGaraza.Name = "btnGaraza";
            btnGaraza.Size = new Size(110, 23);
            btnGaraza.TabIndex = 14;
            btnGaraza.Text = "Garaza";
            btnGaraza.UseVisualStyleBackColor = true;
            btnGaraza.Click += btnGaraza_Click;
            // 
            // ZgradaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnGaraza);
            Controls.Add(btnPoslovniProstor);
            Controls.Add(btnStambeniProstor);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnUlazi);
            Controls.Add(btnLiftovi);
            Controls.Add(btnDodajZgradu);
            Controls.Add(btnObrisiZgradu);
            Controls.Add(listView1);
            Controls.Add(btnPrikaziZgrade);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ZgradaForm";
            Text = "ZgradaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrikaziZgrade;
        private ListView listView1;
        private ColumnHeader Adresa;
        private Button btnObrisiZgradu;
        private Button btnDodajZgradu;
        private Button btnUlazi;
        private Button btnLiftovi;
        private ColumnHeader Id;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnStambeniProstor;
        private Button btnPoslovniProstor;
        private Button btnGaraza;
    }
}