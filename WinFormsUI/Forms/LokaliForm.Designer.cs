namespace WinFormsUI.Forms
{
    partial class LokaliForm
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
            ImeFirme = new ColumnHeader();
            PoslovniProstor = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ImeFirme, PoslovniProstor });
            listView1.Location = new Point(91, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(454, 261);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ImeFirme
            // 
            ImeFirme.Text = "Ime firme";
            // 
            // PoslovniProstor
            // 
            PoslovniProstor.Text = "Poslovni prostor";
            // 
            // LokaliForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(listView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LokaliForm";
            Text = "LokaliForm";
            Load += LokaliForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ImeFirme;
        private ColumnHeader PoslovniProstor;
    }
}