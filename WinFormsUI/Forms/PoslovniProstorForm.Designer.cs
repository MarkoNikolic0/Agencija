namespace WinFormsUI.Forms
{
    partial class PoslovniProstorForm
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
            btnPrikaziPoslovniProstor = new Button();
            btnDodajPoslovniProstor = new Button();
            IdProstora = new ColumnHeader();
            redniBroj = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdProstora, redniBroj });
            listView1.Location = new Point(40, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(395, 224);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnPrikaziPoslovniProstor
            // 
            btnPrikaziPoslovniProstor.Location = new Point(507, 45);
            btnPrikaziPoslovniProstor.Name = "btnPrikaziPoslovniProstor";
            btnPrikaziPoslovniProstor.Size = new Size(183, 39);
            btnPrikaziPoslovniProstor.TabIndex = 1;
            btnPrikaziPoslovniProstor.Text = "Prikazi poslovne prostore zgrade";
            btnPrikaziPoslovniProstor.UseVisualStyleBackColor = true;
            btnPrikaziPoslovniProstor.Click += btnPrikaziPoslovniProstor_Click;
            // 
            // btnDodajPoslovniProstor
            // 
            btnDodajPoslovniProstor.Location = new Point(524, 116);
            btnDodajPoslovniProstor.Name = "btnDodajPoslovniProstor";
            btnDodajPoslovniProstor.Size = new Size(146, 23);
            btnDodajPoslovniProstor.TabIndex = 2;
            btnDodajPoslovniProstor.Text = "Dodaj poslovni prostor";
            btnDodajPoslovniProstor.UseVisualStyleBackColor = true;
            btnDodajPoslovniProstor.Click += btnDodajPoslovniProstor_Click;
            // 
            // IdProstora
            // 
            IdProstora.Text = "Id";
            // 
            // redniBroj
            // 
            redniBroj.Text = "Redni broj";
            // 
            // PoslovniProstorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 283);
            Controls.Add(btnDodajPoslovniProstor);
            Controls.Add(btnPrikaziPoslovniProstor);
            Controls.Add(listView1);
            Name = "PoslovniProstorForm";
            Text = "PoslovniProstorForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnPrikaziPoslovniProstor;
        private Button btnDodajPoslovniProstor;
        private ColumnHeader IdProstora;
        private ColumnHeader redniBroj;
    }
}