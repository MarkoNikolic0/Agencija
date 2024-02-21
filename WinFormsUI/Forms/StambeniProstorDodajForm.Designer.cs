namespace WinFormsUI.Forms
{
    partial class StambeniProstorDodajForm
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
            label1 = new Label();
            brojSprataTb = new TextBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Broj sprata";
            // 
            // brojSprataTb
            // 
            brojSprataTb.Location = new Point(69, 50);
            brojSprataTb.Name = "brojSprataTb";
            brojSprataTb.Size = new Size(63, 23);
            brojSprataTb.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(69, 88);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(63, 23);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // StambeniProstorDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 123);
            Controls.Add(btnDodaj);
            Controls.Add(brojSprataTb);
            Controls.Add(label1);
            Name = "StambeniProstorDodajForm";
            Text = "StambeniProstorDodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox brojSprataTb;
        private Button btnDodaj;
    }
}