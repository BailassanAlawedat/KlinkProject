namespace Kliniken
{
    partial class frmUpdateUndNeuPatientHinzufügen
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnDatenSpeichern = new System.Windows.Forms.Button();
            this.ctrNeuPersonHinzufügen1 = new Kliniken.ctrNeuPersonHinzufügen();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(724, 112);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(115, 20);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "PatientID: ??";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(270, 112);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(114, 20);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "PersonID: ??";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitel.Location = new System.Drawing.Point(388, 35);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(334, 31);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "Neue Patient hinzufügen";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(48, 526);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(259, 42);
            this.btnAbbrechen.TabIndex = 68;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnDatenSpeichern
            // 
            this.btnDatenSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenSpeichern.Location = new System.Drawing.Point(324, 526);
            this.btnDatenSpeichern.Name = "btnDatenSpeichern";
            this.btnDatenSpeichern.Size = new System.Drawing.Size(259, 42);
            this.btnDatenSpeichern.TabIndex = 67;
            this.btnDatenSpeichern.Text = "Patient Daten Speichern";
            this.btnDatenSpeichern.UseVisualStyleBackColor = true;
            this.btnDatenSpeichern.Click += new System.EventHandler(this.btnDatenSpeichern_Click);
            // 
            // ctrNeuPersonHinzufügen1
            // 
            this.ctrNeuPersonHinzufügen1.Location = new System.Drawing.Point(12, 135);
            this.ctrNeuPersonHinzufügen1.Name = "ctrNeuPersonHinzufügen1";
            this.ctrNeuPersonHinzufügen1.Size = new System.Drawing.Size(1115, 371);
            this.ctrNeuPersonHinzufügen1.TabIndex = 0;
            this.ctrNeuPersonHinzufügen1.OnPersonSelected += new System.Action<int>(this.ctrNeuPersonHinzufügen1_OnPersonSelected);
            this.ctrNeuPersonHinzufügen1.Load += new System.EventHandler(this.ctrNeuPersonHinzufügen1_Load);
            // 
            // frmUpdateUndNeuPatientHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1143, 580);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnDatenSpeichern);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.ctrNeuPersonHinzufügen1);
            this.Name = "frmUpdateUndNeuPatientHinzufügen";
            this.Text = "Update/Neue Person hinzufügen";
            this.Load += new System.EventHandler(this.frmUpdateUndNeuPatientHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrNeuPersonHinzufügen ctrNeuPersonHinzufügen1;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnDatenSpeichern;
    }
}