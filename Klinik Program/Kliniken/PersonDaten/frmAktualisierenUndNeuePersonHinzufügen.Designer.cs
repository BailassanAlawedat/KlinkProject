namespace Kliniken
{
    partial class frmAktualisierenUndNeuePersonHinzufügen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDatenSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ctrNeuPersonHinzufügen1 = new Kliniken.ctrNeuPersonHinzufügen();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PersonID:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitel.Location = new System.Drawing.Point(321, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(334, 31);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Neue Person hinzufügen";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPersonID.Location = new System.Drawing.Point(140, 82);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(39, 20);
            this.lblPersonID.TabIndex = 63;
            this.lblPersonID.Text = "???";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDatenSpeichern
            // 
            this.btnDatenSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenSpeichern.Location = new System.Drawing.Point(404, 499);
            this.btnDatenSpeichern.Name = "btnDatenSpeichern";
            this.btnDatenSpeichern.Size = new System.Drawing.Size(235, 50);
            this.btnDatenSpeichern.TabIndex = 64;
            this.btnDatenSpeichern.Text = "Person Daten Speichern";
            this.btnDatenSpeichern.UseVisualStyleBackColor = true;
            this.btnDatenSpeichern.Click += new System.EventHandler(this.btnDatenSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(128, 499);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(235, 50);
            this.btnAbbrechen.TabIndex = 66;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctrNeuPersonHinzufügen1
            // 
            this.ctrNeuPersonHinzufügen1.Location = new System.Drawing.Point(9, 105);
            this.ctrNeuPersonHinzufügen1.Name = "ctrNeuPersonHinzufügen1";
            this.ctrNeuPersonHinzufügen1.Size = new System.Drawing.Size(1115, 388);
            this.ctrNeuPersonHinzufügen1.TabIndex = 67;
            this.ctrNeuPersonHinzufügen1.OnPersonSelected += new System.Action<int>(this.ctrNeuPersonHinzufügen1_OnPersonSelected);
            // 
            // frmAktualisierenUndNeuePersonHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 561);
            this.Controls.Add(this.ctrNeuPersonHinzufügen1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnDatenSpeichern);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.label1);
            this.Name = "frmAktualisierenUndNeuePersonHinzufügen";
            this.Text = "Person hinzufügen";
            this.Load += new System.EventHandler(this.frmNeuePersonHinzufügen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDatenSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ctrNeuPersonHinzufügen ctrNeuPersonHinzufügen1;
    }
}

