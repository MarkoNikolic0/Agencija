namespace WinFormsUI.Forms
{
    partial class PoslovniProstorDodajForm
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
            btnDodaj = new Button();
            redniBrojProstoraTb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(71, 103);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(63, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // redniBrojProstoraTb
            // 
            redniBrojProstoraTb.Location = new Point(71, 65);
            redniBrojProstoraTb.Name = "redniBrojProstoraTb";
            redniBrojProstoraTb.Size = new Size(63, 23);
            redniBrojProstoraTb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "Redni broj prostora";
            // 
            // PoslovniProstorDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 170);
            Controls.Add(btnDodaj);
            Controls.Add(redniBrojProstoraTb);
            Controls.Add(label1);
            Name = "PoslovniProstorDodajForm";
            Text = "PoslovniProstorDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private TextBox redniBrojProstoraTb;
        private Label label1;
    }
}