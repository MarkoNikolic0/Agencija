namespace WinFormsUI.Forms
{
    partial class StanoviForm
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
            IdStana = new ColumnHeader();
            BrojStana = new ColumnHeader();
            Povrsina = new ColumnHeader();
            ImeVlasnika = new ColumnHeader();
            PrezimeVlasnika = new ColumnHeader();
            BrojSprata = new ColumnHeader();
            btnPrikaziVlasnika = new Button();
            btnObrisiStan = new Button();
            btnDodajVlasnika = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdStana, BrojStana, Povrsina, ImeVlasnika, PrezimeVlasnika, BrojSprata });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(22, 23);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(364, 203);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // IdStana
            // 
            IdStana.Text = "Id";
            // 
            // BrojStana
            // 
            BrojStana.Text = "BrojStana";
            // 
            // Povrsina
            // 
            Povrsina.Text = "Povrsina";
            // 
            // ImeVlasnika
            // 
            ImeVlasnika.Text = "Ime vlasnika";
            // 
            // PrezimeVlasnika
            // 
            PrezimeVlasnika.Text = "Prezime vlasnika";
            // 
            // BrojSprata
            // 
            BrojSprata.Text = "Broj sprata";
            // 
            // btnPrikaziVlasnika
            // 
            btnPrikaziVlasnika.Location = new Point(411, 38);
            btnPrikaziVlasnika.Name = "btnPrikaziVlasnika";
            btnPrikaziVlasnika.Size = new Size(136, 23);
            btnPrikaziVlasnika.TabIndex = 1;
            btnPrikaziVlasnika.Text = "Prikazi vlasnika stana";
            btnPrikaziVlasnika.UseVisualStyleBackColor = true;
            btnPrikaziVlasnika.Click += btnPrikaziVlasnika_Click;
            // 
            // btnObrisiStan
            // 
            btnObrisiStan.Location = new Point(438, 85);
            btnObrisiStan.Name = "btnObrisiStan";
            btnObrisiStan.Size = new Size(75, 23);
            btnObrisiStan.TabIndex = 2;
            btnObrisiStan.Text = "Obrisi stan";
            btnObrisiStan.UseVisualStyleBackColor = true;
            btnObrisiStan.Click += btnObrisiStan_Click;
            // 
            // btnDodajVlasnika
            // 
            btnDodajVlasnika.Location = new Point(427, 135);
            btnDodajVlasnika.Name = "btnDodajVlasnika";
            btnDodajVlasnika.Size = new Size(100, 23);
            btnDodajVlasnika.TabIndex = 3;
            btnDodajVlasnika.Text = "Dodaj vlasnika";
            btnDodajVlasnika.UseVisualStyleBackColor = true;
            btnDodajVlasnika.Click += btnDodajVlasnika_Click;
            // 
            // StanoviForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 338);
            Controls.Add(btnDodajVlasnika);
            Controls.Add(btnObrisiStan);
            Controls.Add(btnPrikaziVlasnika);
            Controls.Add(listView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StanoviForm";
            Text = "StanoviForm";
            Load += StanoviForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader BrojStana;
        private ColumnHeader Povrsina;
        private ColumnHeader ImeVlasnika;
        private ColumnHeader PrezimeVlasnika;
        private ColumnHeader BrojSprata;
        private Button btnPrikaziVlasnika;
        private Button btnObrisiStan;
        private ColumnHeader IdStana;
        private Button btnDodajVlasnika;
    }
}