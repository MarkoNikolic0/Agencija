namespace WinFormsUI.Forms
{
    partial class ZgradaDodajForm
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
            tbAdresa = new TextBox();
            btnDodajZgradu = new Button();
            label2 = new Label();
            tbUpravnikId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Adresa";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(176, 44);
            tbAdresa.Margin = new Padding(3, 2, 3, 2);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(110, 23);
            tbAdresa.TabIndex = 1;
            // 
            // btnDodajZgradu
            // 
            btnDodajZgradu.Location = new Point(235, 164);
            btnDodajZgradu.Margin = new Padding(3, 2, 3, 2);
            btnDodajZgradu.Name = "btnDodajZgradu";
            btnDodajZgradu.Size = new Size(82, 22);
            btnDodajZgradu.TabIndex = 2;
            btnDodajZgradu.Text = "Dodaj";
            btnDodajZgradu.UseVisualStyleBackColor = true;
            btnDodajZgradu.Click += btnDodajZgradu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "UpravnikId";
            // 
            // tbUpravnikId
            // 
            tbUpravnikId.Location = new Point(176, 82);
            tbUpravnikId.Margin = new Padding(3, 2, 3, 2);
            tbUpravnikId.Name = "tbUpravnikId";
            tbUpravnikId.Size = new Size(110, 23);
            tbUpravnikId.TabIndex = 5;
            // 
            // ZgradaDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 202);
            Controls.Add(tbUpravnikId);
            Controls.Add(btnDodajZgradu);
            Controls.Add(tbAdresa);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ZgradaDodajForm";
            Text = "ZgradaDodajForm";
            Load += ZgradaDodajForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbAdresa;
        private Button btnDodajZgradu;
        private Label label2;
        private TextBox tbUpravnikId;
    }
}