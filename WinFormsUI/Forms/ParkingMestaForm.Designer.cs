﻿namespace WinFormsUI.Forms
{
    partial class ParkingMestaForm
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
            RegistarskiBroj = new ColumnHeader();
            RedniBroj = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { RegistarskiBroj, RedniBroj });
            listView1.Location = new Point(21, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(461, 238);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RegistarskiBroj
            // 
            RegistarskiBroj.Text = "Registarski broj";
            // 
            // RedniBroj
            // 
            RedniBroj.Text = "Redni broj garaze";
            // 
            // ParkingMestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Name = "ParkingMestaForm";
            Text = "ParkingMestaForm";
            Load += ParkingMestaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader RegistarskiBroj;
        private ColumnHeader RedniBroj;
    }
}