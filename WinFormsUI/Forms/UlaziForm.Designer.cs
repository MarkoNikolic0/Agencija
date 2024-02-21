namespace WinFormsUI.Forms
{
    partial class UlaziForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.RedniBroj = new System.Windows.Forms.ColumnHeader();
            this.Kamera = new System.Windows.Forms.ColumnHeader();
            this.Otvoren = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.RedniBroj,
            this.Kamera,
            this.Otvoren});
            this.listView1.Location = new System.Drawing.Point(193, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 227);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // RedniBroj
            // 
            this.RedniBroj.Text = "RedniBroj";
            this.RedniBroj.Width = 80;
            // 
            // Kamera
            // 
            this.Kamera.Text = "Kamera";
            // 
            // Otvoren
            // 
            this.Otvoren.Text = "Otvoren";
            // 
            // UlaziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "UlaziForm";
            this.Text = "UlaziForm";
            this.Load += new System.EventHandler(this.UlaziForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader RedniBroj;
        private ColumnHeader Kamera;
        private ColumnHeader Otvoren;
    }
}