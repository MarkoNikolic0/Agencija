namespace WinFormsUI.Forms
{
    partial class StambeniProstorForm
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
            IdProstora = new ColumnHeader();
            RedniBroj = new ColumnHeader();
            btnDodajStambeniProstor = new Button();
            btnPrikaziStambeniProstor = new Button();
            btnDodajStan = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdProstora, RedniBroj });
            listView1.Location = new Point(45, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(434, 214);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // IdProstora
            // 
            IdProstora.Text = "Id";
            // 
            // RedniBroj
            // 
            RedniBroj.Text = "Redni broj";
            // 
            // btnDodajStambeniProstor
            // 
            btnDodajStambeniProstor.Location = new Point(507, 68);
            btnDodajStambeniProstor.Name = "btnDodajStambeniProstor";
            btnDodajStambeniProstor.Size = new Size(155, 23);
            btnDodajStambeniProstor.TabIndex = 1;
            btnDodajStambeniProstor.Text = "Dodaj stambeni prostor";
            btnDodajStambeniProstor.UseVisualStyleBackColor = true;
            btnDodajStambeniProstor.Click += btnDodajStambeniProstor_Click;
            // 
            // btnPrikaziStambeniProstor
            // 
            btnPrikaziStambeniProstor.Location = new Point(507, 23);
            btnPrikaziStambeniProstor.Name = "btnPrikaziStambeniProstor";
            btnPrikaziStambeniProstor.Size = new Size(155, 39);
            btnPrikaziStambeniProstor.TabIndex = 2;
            btnPrikaziStambeniProstor.Text = "Prikazi stambene prostore zgrade";
            btnPrikaziStambeniProstor.UseVisualStyleBackColor = true;
            btnPrikaziStambeniProstor.Click += btnPrikaziStambeniProstor_Click;
            // 
            // btnDodajStan
            // 
            btnDodajStan.Location = new Point(549, 110);
            btnDodajStan.Name = "btnDodajStan";
            btnDodajStan.Size = new Size(75, 23);
            btnDodajStan.TabIndex = 4;
            btnDodajStan.Text = "Dodaj stan";
            btnDodajStan.UseVisualStyleBackColor = true;
            btnDodajStan.Click += btnDodajStan_Click;
            // 
            // StambeniProstorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 257);
            Controls.Add(btnDodajStan);
            Controls.Add(btnPrikaziStambeniProstor);
            Controls.Add(btnDodajStambeniProstor);
            Controls.Add(listView1);
            Name = "StambeniProstorForm";
            Text = "StambeniProstorForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnDodajStambeniProstor;
        private Button btnPrikaziStambeniProstor;
        private ColumnHeader IdProstora;
        private ColumnHeader RedniBroj;
        private Button btnDodajStan;
    }
}