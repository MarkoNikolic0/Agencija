namespace WinFormsUI.Forms
{
    partial class LiftDodajForm
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
            btnDodajLift = new Button();
            serijskiBroj = new Label();
            tip = new Label();
            proizvodjac = new Label();
            brojOsoba = new Label();
            nosivost = new Label();
            proizvodjacTb = new TextBox();
            serijskiBrojTb = new TextBox();
            tipTb = new TextBox();
            brojOsobaTb = new TextBox();
            nosivostTb = new TextBox();
            SuspendLayout();
            // 
            // btnDodajLift
            // 
            btnDodajLift.Location = new Point(39, 201);
            btnDodajLift.Name = "btnDodajLift";
            btnDodajLift.Size = new Size(75, 23);
            btnDodajLift.TabIndex = 0;
            btnDodajLift.Text = "Dodaj";
            btnDodajLift.UseVisualStyleBackColor = true;
            btnDodajLift.Click += btnDodajLift_Click;
            // 
            // serijskiBroj
            // 
            serijskiBroj.AutoSize = true;
            serijskiBroj.Location = new Point(39, 22);
            serijskiBroj.Name = "serijskiBroj";
            serijskiBroj.Size = new Size(67, 15);
            serijskiBroj.TabIndex = 1;
            serijskiBroj.Text = "Serijski broj";
            // 
            // tip
            // 
            tip.AutoSize = true;
            tip.Location = new Point(228, 171);
            tip.Name = "tip";
            tip.Size = new Size(23, 15);
            tip.TabIndex = 2;
            tip.Text = "Tip";
            // 
            // proizvodjac
            // 
            proizvodjac.AutoSize = true;
            proizvodjac.Location = new Point(212, 22);
            proizvodjac.Name = "proizvodjac";
            proizvodjac.Size = new Size(68, 15);
            proizvodjac.TabIndex = 3;
            proizvodjac.Text = "Proizvodjac";
            // 
            // brojOsoba
            // 
            brojOsoba.AutoSize = true;
            brojOsoba.Location = new Point(41, 103);
            brojOsoba.Name = "brojOsoba";
            brojOsoba.Size = new Size(63, 15);
            brojOsoba.TabIndex = 4;
            brojOsoba.Text = "Broj osoba";
            // 
            // nosivost
            // 
            nosivost.AutoSize = true;
            nosivost.Location = new Point(212, 103);
            nosivost.Name = "nosivost";
            nosivost.Size = new Size(53, 15);
            nosivost.TabIndex = 7;
            nosivost.Text = "Nosivost";
            // 
            // proizvodjacTb
            // 
            proizvodjacTb.Location = new Point(199, 50);
            proizvodjacTb.Name = "proizvodjacTb";
            proizvodjacTb.Size = new Size(100, 23);
            proizvodjacTb.TabIndex = 10;
            // 
            // serijskiBrojTb
            // 
            serijskiBrojTb.Location = new Point(25, 50);
            serijskiBrojTb.Name = "serijskiBrojTb";
            serijskiBrojTb.Size = new Size(100, 23);
            serijskiBrojTb.TabIndex = 11;
            // 
            // tipTb
            // 
            tipTb.Location = new Point(189, 202);
            tipTb.Name = "tipTb";
            tipTb.Size = new Size(100, 23);
            tipTb.TabIndex = 12;
            // 
            // brojOsobaTb
            // 
            brojOsobaTb.Location = new Point(25, 121);
            brojOsobaTb.Name = "brojOsobaTb";
            brojOsobaTb.Size = new Size(100, 23);
            brojOsobaTb.TabIndex = 13;
            // 
            // nosivostTb
            // 
            nosivostTb.Location = new Point(189, 121);
            nosivostTb.Name = "nosivostTb";
            nosivostTb.Size = new Size(100, 23);
            nosivostTb.TabIndex = 14;
            // 
            // LiftDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 260);
            Controls.Add(nosivostTb);
            Controls.Add(brojOsobaTb);
            Controls.Add(tipTb);
            Controls.Add(serijskiBrojTb);
            Controls.Add(proizvodjacTb);
            Controls.Add(nosivost);
            Controls.Add(brojOsoba);
            Controls.Add(proizvodjac);
            Controls.Add(tip);
            Controls.Add(serijskiBroj);
            Controls.Add(btnDodajLift);
            Name = "LiftDodajForm";
            Text = "LiftDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajLift;
        private Label serijskiBroj;
        private Label tip;
        private Label proizvodjac;
        private Label brojOsoba;
        private Label nosivost;
        private TextBox textBox1;
        private TextBox proizvodjacTb;
        private TextBox serijskiBrojTb;
        private TextBox tipTb;
        private TextBox brojOsobaTb;
        private TextBox nosivostTb;
    }
}