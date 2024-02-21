namespace WinFormsUI.Forms
{
    partial class LicencaDodajForm
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
            button1 = new Button();
            brojLicenceTb = new TextBox();
            nazivInstitucijeTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(191, 190);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 0;
            button1.Text = "Dodaj licencu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDodajLicencu_Click;
            // 
            // brojLicenceTb
            // 
            brojLicenceTb.Location = new Point(95, 121);
            brojLicenceTb.Name = "brojLicenceTb";
            brojLicenceTb.Size = new Size(100, 23);
            brojLicenceTb.TabIndex = 1;
            // 
            // nazivInstitucijeTb
            // 
            nazivInstitucijeTb.Location = new Point(289, 121);
            nazivInstitucijeTb.Name = "nazivInstitucijeTb";
            nazivInstitucijeTb.Size = new Size(111, 23);
            nazivInstitucijeTb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 103);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Broj licence";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 103);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Naziv institucije";
            // 
            // LicencaDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 234);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nazivInstitucijeTb);
            Controls.Add(brojLicenceTb);
            Controls.Add(button1);
            Name = "LicencaDodajForm";
            Text = "LicencaDodajForm";
            Load += LicencaDodajForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox brojLicenceTb;
        private TextBox nazivInstitucijeTb;
        private Label label1;
        private Label label2;
    }
}