namespace Kliniken
{
    partial class frmDatumListeForPatientenAnzeigen
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
            this.DatumListe = new System.Windows.Forms.ListBox();
            this.lable = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGeburtstag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatumListe
            // 
            this.DatumListe.BackColor = System.Drawing.Color.LightGreen;
            this.DatumListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatumListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumListe.ForeColor = System.Drawing.Color.Black;
            this.DatumListe.FormattingEnabled = true;
            this.DatumListe.ItemHeight = 24;
            this.DatumListe.Location = new System.Drawing.Point(0, 62);
            this.DatumListe.Name = "DatumListe";
            this.DatumListe.Size = new System.Drawing.Size(753, 388);
            this.DatumListe.TabIndex = 0;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(12, 22);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(140, 24);
            this.lable.TabIndex = 1;
            this.lable.Text = "Patient Name:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Red;
            this.lblPatientName.Location = new System.Drawing.Point(151, 22);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(90, 24);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "{??????}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(379, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geburtsdatum:";
            // 
            // lblGeburtstag
            // 
            this.lblGeburtstag.AutoSize = true;
            this.lblGeburtstag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeburtstag.ForeColor = System.Drawing.Color.Red;
            this.lblGeburtstag.Location = new System.Drawing.Point(546, 22);
            this.lblGeburtstag.Name = "lblGeburtstag";
            this.lblGeburtstag.Size = new System.Drawing.Size(124, 24);
            this.lblGeburtstag.TabIndex = 4;
            this.lblGeburtstag.Text = "{??/??/????}";
            // 
            // frmDatumListeForPatientenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.lblGeburtstag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.DatumListe);
            this.Name = "frmDatumListeForPatientenAnzeigen";
            this.Text = "frmDatumListeForPatientenAnzeigen";
            this.Load += new System.EventHandler(this.frmDatumListeForPatientenAnzeigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DatumListe;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeburtstag;
    }
}