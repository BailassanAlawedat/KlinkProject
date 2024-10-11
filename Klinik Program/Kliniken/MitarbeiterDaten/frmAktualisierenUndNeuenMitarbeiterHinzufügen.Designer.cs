namespace Kliniken
{
    partial class frmAktualisierenUndNeuenMitarbeiterHinzufügen
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
            this.btnDatenSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.ctrPersonFilter1 = new Kliniken.ctrPersonFilter();
            this.ctrMitarbeiterEinfügen1 = new Kliniken.ctrMitarbeiterEinfügen();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitel.Location = new System.Drawing.Point(296, 25);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(397, 31);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Neuen Mitarbeiter hinzufügen";
            // 
            // btnDatenSpeichern
            // 
            this.btnDatenSpeichern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDatenSpeichern.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDatenSpeichern.Enabled = false;
            this.btnDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenSpeichern.Location = new System.Drawing.Point(222, 724);
            this.btnDatenSpeichern.Name = "btnDatenSpeichern";
            this.btnDatenSpeichern.Size = new System.Drawing.Size(385, 52);
            this.btnDatenSpeichern.TabIndex = 2;
            this.btnDatenSpeichern.Text = "Daten Speichern";
            this.btnDatenSpeichern.UseVisualStyleBackColor = false;
            this.btnDatenSpeichern.Click += new System.EventHandler(this.btnDatenSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(613, 724);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(396, 52);
            this.btnAbbrechen.TabIndex = 3;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            // 
            // ctrPersonFilter1
            // 
            this.ctrPersonFilter1.FilterEnabled = true;
            this.ctrPersonFilter1.Location = new System.Drawing.Point(12, 88);
            this.ctrPersonFilter1.Name = "ctrPersonFilter1";
            this.ctrPersonFilter1.Size = new System.Drawing.Size(955, 98);
            this.ctrPersonFilter1.TabIndex = 5;
            this.ctrPersonFilter1.OnSelectedPersonID += new System.Action<int>(this.ctrPersonFilter1_OnSelectedPersonID);
            // 
            // ctrMitarbeiterEinfügen1
            // 
            this.ctrMitarbeiterEinfügen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMitarbeiterEinfügen1.Location = new System.Drawing.Point(13, 179);
            this.ctrMitarbeiterEinfügen1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrMitarbeiterEinfügen1.Name = "ctrMitarbeiterEinfügen1";
            this.ctrMitarbeiterEinfügen1.Size = new System.Drawing.Size(1031, 538);
            this.ctrMitarbeiterEinfügen1.TabIndex = 4;
            this.ctrMitarbeiterEinfügen1.OnMitarbeiterSelectedID += new System.Action<int>(this.ctrMitarbeiterEinfügen1_OnMitarbeiterSelectedID);
            // 
            // frmAktualisierenUndNeuenMitarbeiterHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1045, 799);
            this.Controls.Add(this.ctrPersonFilter1);
            this.Controls.Add(this.ctrMitarbeiterEinfügen1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnDatenSpeichern);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmAktualisierenUndNeuenMitarbeiterHinzufügen";
            this.Text = "frmAktualisierenUndNeuenMitarbeiterHinzufügen";
            this.Load += new System.EventHandler(this.frmAktualisierenUndNeuenMitarbeiterHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnDatenSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private ctrMitarbeiterEinfügen ctrMitarbeiterEinfügen1;
        private ctrPersonFilter ctrPersonFilter1;
    }
}