namespace WinFormsUI.Forms
{
    partial class VlasnikForm
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
            ImeVlasnika = new ColumnHeader();
            PrezimeVlasnika = new ColumnHeader();
            BrojTelefona = new ColumnHeader();
            Funkcija = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ImeVlasnika, PrezimeVlasnika, BrojTelefona, Funkcija });
            listView1.Location = new Point(24, 11);
            listView1.Name = "listView1";
            listView1.Size = new Size(359, 192);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ImeVlasnika
            // 
            ImeVlasnika.Text = "Ime vlasnika";
            // 
            // PrezimeVlasnika
            // 
            PrezimeVlasnika.Text = "Prezime Vlasnika";
            // 
            // BrojTelefona
            // 
            BrojTelefona.Text = "Broj Telefona";
            // 
            // Funkcija
            // 
            Funkcija.Text = "Funkcija";
            // 
            // VlasnikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 229);
            Controls.Add(listView1);
            Name = "VlasnikForm";
            Text = "VlasnikForm";
            Load += VlasnikForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ImeVlasnika;
        private ColumnHeader PrezimeVlasnika;
        private ColumnHeader BrojTelefona;
        private ColumnHeader Funkcija;
    }
}