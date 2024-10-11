namespace Kliniken
{
    partial class ctrNeuPersonHinzufügen
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbNeuePersonHinzufügen = new System.Windows.Forms.GroupBox();
            this.dtpRegistrierungsDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGeburtsTag = new System.Windows.Forms.DateTimePicker();
            this.rbWeiblich = new System.Windows.Forms.RadioButton();
            this.rbMänlich = new System.Windows.Forms.RadioButton();
            this.llBildLöschen = new System.Windows.Forms.LinkLabel();
            this.llBildSetzen = new System.Windows.Forms.LinkLabel();
            this.pbPersonBild = new System.Windows.Forms.PictureBox();
            this.cbLandName = new System.Windows.Forms.ComboBox();
            this.txtTelefonNummer = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHausNummer = new System.Windows.Forms.TextBox();
            this.txtStraße = new System.Windows.Forms.TextBox();
            this.txtPostleitzahl = new System.Windows.Forms.TextBox();
            this.txtStadt = new System.Windows.Forms.TextBox();
            this.txtAusweisID = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbNeuePersonHinzufügen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNeuePersonHinzufügen
            // 
            this.gbNeuePersonHinzufügen.Controls.Add(this.dtpRegistrierungsDatum);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label1);
            this.gbNeuePersonHinzufügen.Controls.Add(this.dtpGeburtsTag);
            this.gbNeuePersonHinzufügen.Controls.Add(this.rbWeiblich);
            this.gbNeuePersonHinzufügen.Controls.Add(this.rbMänlich);
            this.gbNeuePersonHinzufügen.Controls.Add(this.llBildLöschen);
            this.gbNeuePersonHinzufügen.Controls.Add(this.llBildSetzen);
            this.gbNeuePersonHinzufügen.Controls.Add(this.pbPersonBild);
            this.gbNeuePersonHinzufügen.Controls.Add(this.cbLandName);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtTelefonNummer);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtEmail);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtHausNummer);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtStraße);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtPostleitzahl);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtStadt);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtAusweisID);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtNachname);
            this.gbNeuePersonHinzufügen.Controls.Add(this.txtVorname);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label3);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label7);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label6);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label4);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label5);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label8);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label12);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label9);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label11);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label10);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label14);
            this.gbNeuePersonHinzufügen.Controls.Add(this.label15);
            this.gbNeuePersonHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNeuePersonHinzufügen.Location = new System.Drawing.Point(15, 18);
            this.gbNeuePersonHinzufügen.Name = "gbNeuePersonHinzufügen";
            this.gbNeuePersonHinzufügen.Size = new System.Drawing.Size(1084, 368);
            this.gbNeuePersonHinzufügen.TabIndex = 91;
            this.gbNeuePersonHinzufügen.TabStop = false;
            this.gbNeuePersonHinzufügen.Text = "Neue Person hinzufügen";
            this.gbNeuePersonHinzufügen.Enter += new System.EventHandler(this.gbNeuePersonHinzufügen_Enter);
            // 
            // dtpRegistrierungsDatum
            // 
            this.dtpRegistrierungsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistrierungsDatum.Location = new System.Drawing.Point(224, 324);
            this.dtpRegistrierungsDatum.Name = "dtpRegistrierungsDatum";
            this.dtpRegistrierungsDatum.Size = new System.Drawing.Size(329, 26);
            this.dtpRegistrierungsDatum.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "RegistrierungsDatum:";
            // 
            // dtpGeburtsTag
            // 
            this.dtpGeburtsTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGeburtsTag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeburtsTag.Location = new System.Drawing.Point(585, 80);
            this.dtpGeburtsTag.Name = "dtpGeburtsTag";
            this.dtpGeburtsTag.Size = new System.Drawing.Size(233, 26);
            this.dtpGeburtsTag.TabIndex = 78;
            // 
            // rbWeiblich
            // 
            this.rbWeiblich.AutoSize = true;
            this.rbWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWeiblich.ForeColor = System.Drawing.Color.Maroon;
            this.rbWeiblich.Location = new System.Drawing.Point(275, 126);
            this.rbWeiblich.Name = "rbWeiblich";
            this.rbWeiblich.Size = new System.Drawing.Size(86, 24);
            this.rbWeiblich.TabIndex = 80;
            this.rbWeiblich.Text = "Weiblich";
            this.rbWeiblich.UseVisualStyleBackColor = true;
            this.rbWeiblich.Click += new System.EventHandler(this.rbWeiblich_Click);
            // 
            // rbMänlich
            // 
            this.rbMänlich.AutoSize = true;
            this.rbMänlich.Checked = true;
            this.rbMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMänlich.ForeColor = System.Drawing.Color.Maroon;
            this.rbMänlich.Location = new System.Drawing.Point(124, 126);
            this.rbMänlich.Name = "rbMänlich";
            this.rbMänlich.Size = new System.Drawing.Size(81, 24);
            this.rbMänlich.TabIndex = 79;
            this.rbMänlich.TabStop = true;
            this.rbMänlich.Text = "Mänlich";
            this.rbMänlich.UseVisualStyleBackColor = true;
            this.rbMänlich.Click += new System.EventHandler(this.rbMänlich_Click);
            // 
            // llBildLöschen
            // 
            this.llBildLöschen.AutoSize = true;
            this.llBildLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llBildLöschen.Location = new System.Drawing.Point(864, 269);
            this.llBildLöschen.Name = "llBildLöschen";
            this.llBildLöschen.Size = new System.Drawing.Size(94, 20);
            this.llBildLöschen.TabIndex = 87;
            this.llBildLöschen.TabStop = true;
            this.llBildLöschen.Text = "Bild löschen";
            this.llBildLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBildLöschen_LinkClicked);
            // 
            // llBildSetzen
            // 
            this.llBildSetzen.AutoSize = true;
            this.llBildSetzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llBildSetzen.Location = new System.Drawing.Point(864, 225);
            this.llBildSetzen.Name = "llBildSetzen";
            this.llBildSetzen.Size = new System.Drawing.Size(87, 20);
            this.llBildSetzen.TabIndex = 86;
            this.llBildSetzen.TabStop = true;
            this.llBildSetzen.Text = "Bild setzen";
            this.llBildSetzen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBildSetzen_LinkClicked);
            // 
            // pbPersonBild
            // 
            this.pbPersonBild.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbPersonBild.Image = global::Kliniken.Properties.Resources.Male_512;
            this.pbPersonBild.Location = new System.Drawing.Point(868, 27);
            this.pbPersonBild.Name = "pbPersonBild";
            this.pbPersonBild.Size = new System.Drawing.Size(192, 172);
            this.pbPersonBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonBild.TabIndex = 85;
            this.pbPersonBild.TabStop = false;
            // 
            // cbLandName
            // 
            this.cbLandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLandName.FormattingEnabled = true;
            this.cbLandName.Location = new System.Drawing.Point(585, 129);
            this.cbLandName.Name = "cbLandName";
            this.cbLandName.Size = new System.Drawing.Size(233, 28);
            this.cbLandName.TabIndex = 81;
            // 
            // txtTelefonNummer
            // 
            this.txtTelefonNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonNummer.Location = new System.Drawing.Point(585, 272);
            this.txtTelefonNummer.Name = "txtTelefonNummer";
            this.txtTelefonNummer.Size = new System.Drawing.Size(233, 29);
            this.txtTelefonNummer.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(127, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 29);
            this.txtEmail.TabIndex = 86;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtHausNummer
            // 
            this.txtHausNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHausNummer.Location = new System.Drawing.Point(585, 225);
            this.txtHausNummer.Name = "txtHausNummer";
            this.txtHausNummer.Size = new System.Drawing.Size(233, 29);
            this.txtHausNummer.TabIndex = 85;
            // 
            // txtStraße
            // 
            this.txtStraße.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStraße.Location = new System.Drawing.Point(124, 225);
            this.txtStraße.Name = "txtStraße";
            this.txtStraße.Size = new System.Drawing.Size(233, 29);
            this.txtStraße.TabIndex = 84;
            // 
            // txtPostleitzahl
            // 
            this.txtPostleitzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostleitzahl.Location = new System.Drawing.Point(585, 172);
            this.txtPostleitzahl.Name = "txtPostleitzahl";
            this.txtPostleitzahl.Size = new System.Drawing.Size(233, 29);
            this.txtPostleitzahl.TabIndex = 83;
            // 
            // txtStadt
            // 
            this.txtStadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStadt.Location = new System.Drawing.Point(124, 172);
            this.txtStadt.Name = "txtStadt";
            this.txtStadt.Size = new System.Drawing.Size(233, 29);
            this.txtStadt.TabIndex = 82;
            // 
            // txtAusweisID
            // 
            this.txtAusweisID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAusweisID.Location = new System.Drawing.Point(124, 83);
            this.txtAusweisID.Name = "txtAusweisID";
            this.txtAusweisID.Size = new System.Drawing.Size(233, 29);
            this.txtAusweisID.TabIndex = 77;
            this.txtAusweisID.Validating += new System.ComponentModel.CancelEventHandler(this.txtAusweisID_Validating_1);
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(585, 32);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(233, 29);
            this.txtNachname.TabIndex = 76;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(124, 32);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(233, 29);
            this.txtVorname.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Vorname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Stadt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Geschlecht:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nachname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "GeburtsTag:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Postleitzahl:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(441, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 74;
            this.label12.Text = "Telefonnummer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "AusweisID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 73;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "LandName:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(455, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Hausnummer:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "Straße:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctrNeuPersonHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNeuePersonHinzufügen);
            this.Name = "ctrNeuPersonHinzufügen";
            this.Size = new System.Drawing.Size(1115, 388);
            this.Load += new System.EventHandler(this.ctrNeuPersonHinzufügen_Load);
            this.gbNeuePersonHinzufügen.ResumeLayout(false);
            this.gbNeuePersonHinzufügen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbNeuePersonHinzufügen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpGeburtsTag;
        private System.Windows.Forms.RadioButton rbWeiblich;
        private System.Windows.Forms.RadioButton rbMänlich;
        private System.Windows.Forms.LinkLabel llBildLöschen;
        private System.Windows.Forms.LinkLabel llBildSetzen;
        private System.Windows.Forms.PictureBox pbPersonBild;
        private System.Windows.Forms.ComboBox cbLandName;
        private System.Windows.Forms.TextBox txtTelefonNummer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHausNummer;
        private System.Windows.Forms.TextBox txtStraße;
        private System.Windows.Forms.TextBox txtPostleitzahl;
        private System.Windows.Forms.TextBox txtStadt;
        private System.Windows.Forms.TextBox txtAusweisID;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpRegistrierungsDatum;
        private System.Windows.Forms.Label label1;
    }
}
