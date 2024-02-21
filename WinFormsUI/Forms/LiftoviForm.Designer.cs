namespace WinFormsUI.Forms
{
    partial class LiftoviForm
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
            SerijskiBroj = new ColumnHeader();
            Proizvodjac = new ColumnHeader();
            Tip = new ColumnHeader();
            Nosivost = new ColumnHeader();
            BrojOsoba = new ColumnHeader();
            btnDodajLift = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { SerijskiBroj, Proizvodjac, Tip, Nosivost, BrojOsoba });
            listView1.Location = new Point(69, 30);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(562, 203);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // SerijskiBroj
            // 
            SerijskiBroj.Text = "SerijskiBroj";
            // 
            // Proizvodjac
            // 
            Proizvodjac.Text = "Proizvodjac";
            // 
            // Tip
            // 
            Tip.Text = "Tip";
            // 
            // Nosivost
            // 
            Nosivost.Text = "Nosivost";
            // 
            // BrojOsoba
            // 
            BrojOsoba.Text = "BrojOsoba";
            // 
            // btnDodajLift
            // 
            btnDodajLift.Location = new Point(325, 269);
            btnDodajLift.Name = "btnDodajLift";
            btnDodajLift.Size = new Size(75, 23);
            btnDodajLift.TabIndex = 1;
            btnDodajLift.Text = "Dodaj lift";
            btnDodajLift.UseVisualStyleBackColor = true;
            btnDodajLift.Click += btnDodajLift_Click;
            // 
            // LiftoviForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnDodajLift);
            Controls.Add(listView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LiftoviForm";
            Text = "LiftoviForm";
            Load += LiftoviForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader SerijskiBroj;
        private ColumnHeader Proizvodjac;
        private ColumnHeader Tip;
        private ColumnHeader Nosivost;
        private ColumnHeader BrojOsoba;
        private Button btnDodajLift;
    }
}