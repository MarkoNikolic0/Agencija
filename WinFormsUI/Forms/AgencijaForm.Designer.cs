namespace WinFormsUI.Forms
{
    partial class AgencijaForm
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
            btnZgrade = new Button();
            btnUpravnici = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnZgrade
            // 
            btnZgrade.Location = new Point(276, 88);
            btnZgrade.Margin = new Padding(3, 2, 3, 2);
            btnZgrade.Name = "btnZgrade";
            btnZgrade.Size = new Size(116, 25);
            btnZgrade.TabIndex = 2;
            btnZgrade.Text = "Zgrade";
            btnZgrade.UseVisualStyleBackColor = true;
            btnZgrade.Click += btnZgrade_Click;
            // 
            // btnUpravnici
            // 
            btnUpravnici.Location = new Point(276, 128);
            btnUpravnici.Margin = new Padding(3, 2, 3, 2);
            btnUpravnici.Name = "btnUpravnici";
            btnUpravnici.Size = new Size(116, 22);
            btnUpravnici.TabIndex = 3;
            btnUpravnici.Text = "Upravnici";
            btnUpravnici.UseVisualStyleBackColor = true;
            btnUpravnici.Click += btnUpravnici_Click;
            // 
            // button1
            // 
            button1.Location = new Point(276, 166);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 4;
            button1.Text = "Licence";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLicence_Click;
            // 
            // AgencijaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(btnUpravnici);
            Controls.Add(btnZgrade);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgencijaForm";
            Text = "AgencijaForm";
            Load += AgencijaForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnZgrade;
        private Button btnUpravnici;
        private Button button1;
    }
}