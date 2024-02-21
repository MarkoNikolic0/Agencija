namespace WinFormsUI.Forms
{
    partial class GarazaForm
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
            btnPrikaziGarazu = new Button();
            btnDodajGarazu = new Button();
            IdGaraze = new ColumnHeader();
            RedniBroj = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdGaraze, RedniBroj });
            listView1.Location = new Point(25, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(386, 190);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnPrikaziGarazu
            // 
            btnPrikaziGarazu.Location = new Point(446, 67);
            btnPrikaziGarazu.Name = "btnPrikaziGarazu";
            btnPrikaziGarazu.Size = new Size(127, 23);
            btnPrikaziGarazu.TabIndex = 1;
            btnPrikaziGarazu.Text = "Prikazi garaze";
            btnPrikaziGarazu.UseVisualStyleBackColor = true;
            btnPrikaziGarazu.Click += btnPrikaziGarazu_Click;
            // 
            // btnDodajGarazu
            // 
            btnDodajGarazu.Location = new Point(446, 110);
            btnDodajGarazu.Name = "btnDodajGarazu";
            btnDodajGarazu.Size = new Size(127, 23);
            btnDodajGarazu.TabIndex = 2;
            btnDodajGarazu.Text = "Dodaj garazu";
            btnDodajGarazu.UseVisualStyleBackColor = true;
            btnDodajGarazu.Click += btnDodajGarazu_Click;
            // 
            // IdGaraze
            // 
            IdGaraze.Text = "Id";
            // 
            // RedniBroj
            // 
            RedniBroj.Text = "Redni broj";
            // 
            // GarazaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 257);
            Controls.Add(btnDodajGarazu);
            Controls.Add(btnPrikaziGarazu);
            Controls.Add(listView1);
            Name = "GarazaForm";
            Text = "GarazaForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnPrikaziGarazu;
        private Button btnDodajGarazu;
        private ColumnHeader IdGaraze;
        private ColumnHeader RedniBroj;
    }
}