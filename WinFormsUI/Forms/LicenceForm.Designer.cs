namespace WinFormsUI.Forms
{
    partial class LicenceForm
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
            listView1 = new ListView();
            Id = new ColumnHeader();
            BrojLicence = new ColumnHeader();
            NazivInstitucije = new ColumnHeader();
            DatumSticanja = new ColumnHeader();
            ImeUpravnika = new ColumnHeader();
            PrezimeUpravnika = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, BrojLicence, NazivInstitucije, DatumSticanja, ImeUpravnika, PrezimeUpravnika });
            listView1.Location = new Point(12, 46);
            listView1.Name = "listView1";
            listView1.Size = new Size(418, 206);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // BrojLicence
            // 
            BrojLicence.Text = "Broj licence";
            // 
            // NazivInstitucije
            // 
            NazivInstitucije.Text = "Naziv institucije";
            // 
            // DatumSticanja
            // 
            DatumSticanja.Text = "Datum sticanja";
            // 
            // ImeUpravnika
            // 
            ImeUpravnika.Text = "Ime upravnika";
            // 
            // PrezimeUpravnika
            // 
            PrezimeUpravnika.Text = "Prezime upravnika";
            // 
            // button1
            // 
            button1.Location = new Point(466, 71);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 1;
            button1.Text = "Dodaj licencu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDodajLicencu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 120);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 2;
            button2.Text = "Prikazi licence";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnPrikaziLicence_Click;
            // 
            // LicenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 270);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "LicenceForm";
            Text = "LicenceForm";
            Load += btnPrikaziLicence_Click;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private ColumnHeader Id;
        private ColumnHeader BrojLicence;
        private ColumnHeader NazivInstitucije;
        private ColumnHeader DatumSticanja;
        private ColumnHeader ImeUpravnika;
        private ColumnHeader PrezimeUpravnika;
    }
}