namespace Kliniken
{
    partial class frmAktualisierenUndNeueArztHinzufügen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblArztID = new System.Windows.Forms.Label();
            this.cbFachrichtungen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnDatenSpeichern = new System.Windows.Forms.Button();
            this.ctrNeuPersonHinzufügen1 = new Kliniken.ctrNeuPersonHinzufügen();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(417, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Neue Arzt hinzufügen";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.Maroon;
            this.lblPersonID.Location = new System.Drawing.Point(614, 118);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(119, 20);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "PersonID: ?? ";
            // 
            // lblArztID
            // 
            this.lblArztID.AutoSize = true;
            this.lblArztID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArztID.ForeColor = System.Drawing.Color.Maroon;
            this.lblArztID.Location = new System.Drawing.Point(927, 118);
            this.lblArztID.Name = "lblArztID";
            this.lblArztID.Size = new System.Drawing.Size(91, 20);
            this.lblArztID.TabIndex = 3;
            this.lblArztID.Text = "ArztID: ??";
            // 
            // cbFachrichtungen
            // 
            this.cbFachrichtungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFachrichtungen.FormattingEnabled = true;
            this.cbFachrichtungen.Location = new System.Drawing.Point(271, 115);
            this.cbFachrichtungen.Name = "cbFachrichtungen";
            this.cbFachrichtungen.Size = new System.Drawing.Size(296, 28);
            this.cbFachrichtungen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fachrichtung auswählen:";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(158, 547);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(290, 50);
            this.btnAbbrechen.TabIndex = 68;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnDatenSpeichern
            // 
            this.btnDatenSpeichern.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatenSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenSpeichern.Location = new System.Drawing.Point(553, 547);
            this.btnDatenSpeichern.Name = "btnDatenSpeichern";
            this.btnDatenSpeichern.Size = new System.Drawing.Size(290, 50);
            this.btnDatenSpeichern.TabIndex = 67;
            this.btnDatenSpeichern.Text = "Arzt Daten Speichern";
            this.btnDatenSpeichern.UseVisualStyleBackColor = false;
            this.btnDatenSpeichern.Click += new System.EventHandler(this.btnDatenSpeichern_Click);
            // 
            // ctrNeuPersonHinzufügen1
            // 
            this.ctrNeuPersonHinzufügen1.Location = new System.Drawing.Point(12, 149);
            this.ctrNeuPersonHinzufügen1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrNeuPersonHinzufügen1.Name = "ctrNeuPersonHinzufügen1";
            this.ctrNeuPersonHinzufügen1.Size = new System.Drawing.Size(1115, 388);
            this.ctrNeuPersonHinzufügen1.TabIndex = 0;
            this.ctrNeuPersonHinzufügen1.OnPersonSelected += new System.Action<int>(this.ctrNeuPersonHinzufügen1_OnPersonSelected);
            // 
            // frmAktualisierenUndNeueArztHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 609);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnDatenSpeichern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFachrichtungen);
            this.Controls.Add(this.lblArztID);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrNeuPersonHinzufügen1);
            this.Name = "frmAktualisierenUndNeueArztHinzufügen";
            this.Text = "frmAktualisierenUndNeueArztHinzufügen";
            this.Load += new System.EventHandler(this.frmAktualisierenUndNeueArztHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrNeuPersonHinzufügen ctrNeuPersonHinzufügen1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblArztID;
        private System.Windows.Forms.ComboBox cbFachrichtungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnDatenSpeichern;
    }
}