namespace Kliniken
{
    partial class frmMitarbeiterDatenAnzeigen
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
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.ctrMiratbeiterKarte1 = new Kliniken.ctrMiratbeiterKarte();
            this.SuspendLayout();
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonDaten1.Location = new System.Drawing.Point(13, 409);
            this.ctrPersonDaten1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(1091, 367);
            this.ctrPersonDaten1.TabIndex = 1;
            // 
            // ctrMiratbeiterKarte1
            // 
            this.ctrMiratbeiterKarte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrMiratbeiterKarte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMiratbeiterKarte1.Location = new System.Drawing.Point(13, 12);
            this.ctrMiratbeiterKarte1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrMiratbeiterKarte1.Name = "ctrMiratbeiterKarte1";
            this.ctrMiratbeiterKarte1.Size = new System.Drawing.Size(1098, 391);
            this.ctrMiratbeiterKarte1.TabIndex = 0;
            // 
            // frmMitarbeiterDatenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 782);
            this.Controls.Add(this.ctrPersonDaten1);
            this.Controls.Add(this.ctrMiratbeiterKarte1);
            this.Name = "frmMitarbeiterDatenAnzeigen";
            this.Text = "frmMitarbeiterDatenAnzeigen";
            this.Load += new System.EventHandler(this.frmMitarbeiterDatenAnzeigen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrMiratbeiterKarte ctrMiratbeiterKarte1;
        private ctrPersonDaten ctrPersonDaten1;
    }
}