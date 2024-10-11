namespace Kliniken
{
    partial class frmPersonDatenAnzeigen
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitel.Location = new System.Drawing.Point(330, 21);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(179, 31);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Person Infos";
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Location = new System.Drawing.Point(14, 64);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(938, 312);
            this.ctrPersonDaten1.TabIndex = 1;
            // 
            // frmPersonDatenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 375);
            this.Controls.Add(this.ctrPersonDaten1);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmPersonDatenAnzeigen";
            this.Text = "frmPersonDatenAnzeigen";
            this.Load += new System.EventHandler(this.frmPersonDatenAnzeigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private ctrPersonDaten ctrPersonDaten1;
    }
}