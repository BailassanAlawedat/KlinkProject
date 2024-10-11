namespace Kliniken
{
    partial class frmAtkualisierungUndNeueRezepteHinzufügen
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

       # region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRezeptID = new System.Windows.Forms.Label();
            this.lblVersicherungID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRezeptname = new System.Windows.Forms.TextBox();
            this.txtDosierung = new System.Windows.Forms.TextBox();
            this.dtpStartdatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEnddatum = new System.Windows.Forms.DateTimePicker();
            this.cbHäufigkeit = new System.Windows.Forms.ComboBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.cbSpzielleAnweisungen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTerminID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "neues Rezept hinzufügen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "VersicherungID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rezept Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dosierung:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Häufigkeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RezeptID: ";
            // 
            // lblRezeptID
            // 
            this.lblRezeptID.AutoSize = true;
            this.lblRezeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezeptID.ForeColor = System.Drawing.Color.Maroon;
            this.lblRezeptID.Location = new System.Drawing.Point(202, 96);
            this.lblRezeptID.Name = "lblRezeptID";
            this.lblRezeptID.Size = new System.Drawing.Size(49, 20);
            this.lblRezeptID.TabIndex = 6;
            this.lblRezeptID.Text = "[???]";
            // 
            // lblVersicherungID
            // 
            this.lblVersicherungID.AutoSize = true;
            this.lblVersicherungID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersicherungID.ForeColor = System.Drawing.Color.Maroon;
            this.lblVersicherungID.Location = new System.Drawing.Point(813, 96);
            this.lblVersicherungID.Name = "lblVersicherungID";
            this.lblVersicherungID.Size = new System.Drawing.Size(49, 20);
            this.lblVersicherungID.TabIndex = 7;
            this.lblVersicherungID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Startdatum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enddatum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Spezielleaweisungen:";
            // 
            // txtRezeptname
            // 
            this.txtRezeptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRezeptname.Location = new System.Drawing.Point(217, 149);
            this.txtRezeptname.Name = "txtRezeptname";
            this.txtRezeptname.Size = new System.Drawing.Size(267, 26);
            this.txtRezeptname.TabIndex = 11;
            this.txtRezeptname.Validating += new System.ComponentModel.CancelEventHandler(this.txtRezeptname_Validating);
            // 
            // txtDosierung
            // 
            this.txtDosierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosierung.Location = new System.Drawing.Point(654, 149);
            this.txtDosierung.Name = "txtDosierung";
            this.txtDosierung.Size = new System.Drawing.Size(267, 26);
            this.txtDosierung.TabIndex = 12;
            // 
            // dtpStartdatum
            // 
            this.dtpStartdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartdatum.Location = new System.Drawing.Point(217, 199);
            this.dtpStartdatum.Name = "dtpStartdatum";
            this.dtpStartdatum.Size = new System.Drawing.Size(267, 26);
            this.dtpStartdatum.TabIndex = 15;
            // 
            // dtpEnddatum
            // 
            this.dtpEnddatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnddatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnddatum.Location = new System.Drawing.Point(654, 198);
            this.dtpEnddatum.Name = "dtpEnddatum";
            this.dtpEnddatum.Size = new System.Drawing.Size(267, 26);
            this.dtpEnddatum.TabIndex = 16;
            // 
            // cbHäufigkeit
            // 
            this.cbHäufigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHäufigkeit.FormattingEnabled = true;
            this.cbHäufigkeit.Items.AddRange(new object[] {
            "3x täglich",
            "2x täglich",
            "1x täglich",
            "1x täglich morgens",
            "1x täglich abends"});
            this.cbHäufigkeit.Location = new System.Drawing.Point(217, 259);
            this.cbHäufigkeit.Name = "cbHäufigkeit";
            this.cbHäufigkeit.Size = new System.Drawing.Size(267, 28);
            this.cbHäufigkeit.TabIndex = 17;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(202, 399);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(220, 43);
            this.btnSpeichern.TabIndex = 18;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(450, 399);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(220, 43);
            this.btnAbbrechen.TabIndex = 19;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // cbSpzielleAnweisungen
            // 
            this.cbSpzielleAnweisungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpzielleAnweisungen.FormattingEnabled = true;
            this.cbSpzielleAnweisungen.Items.AddRange(new object[] {
            "Mit Essen einnehmen",
            "Mit viel Wasser einnehmen",
            "Vor den Mahlzeiten",
            "Unabhängig von den Mahlzeiten",
            "Nach dem Frühstück und Abendessen",
            "Abends einnehmen",
            "Nicht zusammen mit Grapefruitsaft",
            "Vor dem Frühstück einnehmen",
            "Abends einnehmen",
            "30 Minuten vor dem Frühstück",
            "Auf leeren Magen einnehmen",
            "Vor dem Schlafengehen einnehmen",
            "Vor Licht schützen",
            "Regelmäßige Bluttests erforderlich",
            "Nach Einnahme nicht sofort hinlegen"});
            this.cbSpzielleAnweisungen.Location = new System.Drawing.Point(217, 321);
            this.cbSpzielleAnweisungen.Name = "cbSpzielleAnweisungen";
            this.cbSpzielleAnweisungen.Size = new System.Drawing.Size(704, 28);
            this.cbSpzielleAnweisungen.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(397, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "TerminID:";
            // 
            // lblTerminID
            // 
            this.lblTerminID.AutoSize = true;
            this.lblTerminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminID.ForeColor = System.Drawing.Color.Maroon;
            this.lblTerminID.Location = new System.Drawing.Point(490, 96);
            this.lblTerminID.Name = "lblTerminID";
            this.lblTerminID.Size = new System.Drawing.Size(49, 20);
            this.lblTerminID.TabIndex = 22;
            this.lblTerminID.Text = "[???]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAtkualisierungUndNeueRezepteHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(955, 459);
            this.Controls.Add(this.lblTerminID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSpzielleAnweisungen);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cbHäufigkeit);
            this.Controls.Add(this.dtpEnddatum);
            this.Controls.Add(this.dtpStartdatum);
            this.Controls.Add(this.txtDosierung);
            this.Controls.Add(this.txtRezeptname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVersicherungID);
            this.Controls.Add(this.lblRezeptID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtkualisierungUndNeueRezepteHinzufügen";
            this.Text = "frmAtkualisierungUndNeueRezepteHinzufügen";
            this.Load += new System.EventHandler(this.frmAtkualisierungUndNeueRezepteHinzufügen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRezeptID;
        private System.Windows.Forms.Label lblVersicherungID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRezeptname;
        private System.Windows.Forms.TextBox txtDosierung;
        private System.Windows.Forms.DateTimePicker dtpStartdatum;
        private System.Windows.Forms.DateTimePicker dtpEnddatum;
        private System.Windows.Forms.ComboBox cbHäufigkeit;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.ComboBox cbSpzielleAnweisungen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTerminID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}