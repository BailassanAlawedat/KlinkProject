namespace Kliniken
{
    partial class frmPatientDatenAnzeigen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PatientID: ";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Maroon;
            this.lblPatientID.Location = new System.Drawing.Point(150, 72);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(49, 20);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(352, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patienten Infos";
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Location = new System.Drawing.Point(21, 95);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(933, 318);
            this.ctrPersonDaten1.TabIndex = 0;
            // 
            // frmPatientDatenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonDaten1);
            this.Name = "frmPatientDatenAnzeigen";
            this.Text = "frmPatientDatenAnzeigen";
            this.Load += new System.EventHandler(this.frmPatientDatenAnzeigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPersonDaten ctrPersonDaten1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label2;
    }
}