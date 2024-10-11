namespace Kliniken
{
    partial class frmAktualisierenUndNeuenBenutzerHinzufügen
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
            this.components = new System.ComponentModel.Container();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnZuBenutzerSeite = new System.Windows.Forms.Button();
            this.tbPersonInfo = new System.Windows.Forms.TabControl();
            this.tabPage1PersonInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonenFilter1 = new Kliniken.ctrPersonenDatenMitFilter();
            this.tabPage2BenutzerInfo = new System.Windows.Forms.TabPage();
            this.cbIstAktive = new System.Windows.Forms.CheckBox();
            this.btnBenutzerDatenSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.dtpLetzterLogin = new System.Windows.Forms.DateTimePicker();
            this.dtpAktualisiertAm = new System.Windows.Forms.DateTimePicker();
            this.dtpErstelltAm = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbBenutzerPasswort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbRolle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBenutzerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZurPersonInfoSeite = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPersonInfo.SuspendLayout();
            this.tabPage1PersonInfo.SuspendLayout();
            this.tabPage2BenutzerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitel.Location = new System.Drawing.Point(315, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(179, 31);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Person Infos";
            // 
            // btnZuBenutzerSeite
            // 
            this.btnZuBenutzerSeite.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZuBenutzerSeite.Enabled = false;
            this.btnZuBenutzerSeite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZuBenutzerSeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZuBenutzerSeite.ForeColor = System.Drawing.Color.Black;
            this.btnZuBenutzerSeite.Image = global::Kliniken.Properties.Resources.Next_32;
            this.btnZuBenutzerSeite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZuBenutzerSeite.Location = new System.Drawing.Point(596, 582);
            this.btnZuBenutzerSeite.Name = "btnZuBenutzerSeite";
            this.btnZuBenutzerSeite.Size = new System.Drawing.Size(349, 50);
            this.btnZuBenutzerSeite.TabIndex = 4;
            this.btnZuBenutzerSeite.Text = "zum Anmelden";
            this.btnZuBenutzerSeite.UseVisualStyleBackColor = false;
            this.btnZuBenutzerSeite.Click += new System.EventHandler(this.btnZuBenutzerSeite_Click);
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.tabPage1PersonInfo);
            this.tbPersonInfo.Controls.Add(this.tabPage2BenutzerInfo);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonInfo.Location = new System.Drawing.Point(12, 51);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.SelectedIndex = 0;
            this.tbPersonInfo.Size = new System.Drawing.Size(965, 529);
            this.tbPersonInfo.TabIndex = 5;
            // 
            // tabPage1PersonInfo
            // 
            this.tabPage1PersonInfo.Controls.Add(this.ctrPersonenFilter1);
            this.tabPage1PersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1PersonInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPage1PersonInfo.Name = "tabPage1PersonInfo";
            this.tabPage1PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1PersonInfo.Size = new System.Drawing.Size(957, 498);
            this.tabPage1PersonInfo.TabIndex = 0;
            this.tabPage1PersonInfo.Tag = "1";
            this.tabPage1PersonInfo.Text = "PersonInfo";
            this.tabPage1PersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrPersonenFilter1
            // 
            this.ctrPersonenFilter1.FilterEnabled = true;
            this.ctrPersonenFilter1.Location = new System.Drawing.Point(6, 48);
            this.ctrPersonenFilter1.Name = "ctrPersonenFilter1";
            this.ctrPersonenFilter1.Size = new System.Drawing.Size(934, 428);
            this.ctrPersonenFilter1.TabIndex = 0;
            this.ctrPersonenFilter1.OnPersonSelected += new System.Action<int>(this.ctrPersonenFilter1_OnPersonSelected);
            // 
            // tabPage2BenutzerInfo
            // 
            this.tabPage2BenutzerInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2BenutzerInfo.Controls.Add(this.cbIstAktive);
            this.tabPage2BenutzerInfo.Controls.Add(this.btnBenutzerDatenSpeichern);
            this.tabPage2BenutzerInfo.Controls.Add(this.btnAbbrechen);
            this.tabPage2BenutzerInfo.Controls.Add(this.dtpLetzterLogin);
            this.tabPage2BenutzerInfo.Controls.Add(this.dtpAktualisiertAm);
            this.tabPage2BenutzerInfo.Controls.Add(this.dtpErstelltAm);
            this.tabPage2BenutzerInfo.Controls.Add(this.label9);
            this.tabPage2BenutzerInfo.Controls.Add(this.label8);
            this.tabPage2BenutzerInfo.Controls.Add(this.label7);
            this.tabPage2BenutzerInfo.Controls.Add(this.label6);
            this.tabPage2BenutzerInfo.Controls.Add(this.txtbBenutzerPasswort);
            this.tabPage2BenutzerInfo.Controls.Add(this.label5);
            this.tabPage2BenutzerInfo.Controls.Add(this.txtbRolle);
            this.tabPage2BenutzerInfo.Controls.Add(this.label4);
            this.tabPage2BenutzerInfo.Controls.Add(this.lblBenutzerID);
            this.tabPage2BenutzerInfo.Controls.Add(this.label3);
            this.tabPage2BenutzerInfo.Controls.Add(this.lblPersonID);
            this.tabPage2BenutzerInfo.Controls.Add(this.label2);
            this.tabPage2BenutzerInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPage2BenutzerInfo.Name = "tabPage2BenutzerInfo";
            this.tabPage2BenutzerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2BenutzerInfo.Size = new System.Drawing.Size(957, 498);
            this.tabPage2BenutzerInfo.TabIndex = 1;
            this.tabPage2BenutzerInfo.Tag = "2";
            this.tabPage2BenutzerInfo.Text = "BenutzerInfo";
            // 
            // cbIstAktive
            // 
            this.cbIstAktive.AutoSize = true;
            this.cbIstAktive.Location = new System.Drawing.Point(198, 200);
            this.cbIstAktive.Name = "cbIstAktive";
            this.cbIstAktive.Size = new System.Drawing.Size(15, 14);
            this.cbIstAktive.TabIndex = 18;
            this.cbIstAktive.UseVisualStyleBackColor = true;
            // 
            // btnBenutzerDatenSpeichern
            // 
            this.btnBenutzerDatenSpeichern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBenutzerDatenSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenutzerDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenutzerDatenSpeichern.Location = new System.Drawing.Point(493, 423);
            this.btnBenutzerDatenSpeichern.Name = "btnBenutzerDatenSpeichern";
            this.btnBenutzerDatenSpeichern.Size = new System.Drawing.Size(253, 42);
            this.btnBenutzerDatenSpeichern.TabIndex = 17;
            this.btnBenutzerDatenSpeichern.Text = "Benutzerdaten Speichern";
            this.btnBenutzerDatenSpeichern.UseVisualStyleBackColor = false;
            this.btnBenutzerDatenSpeichern.Click += new System.EventHandler(this.btnBenutzerDatenSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(198, 423);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(253, 42);
            this.btnAbbrechen.TabIndex = 16;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // dtpLetzterLogin
            // 
            this.dtpLetzterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLetzterLogin.Location = new System.Drawing.Point(607, 226);
            this.dtpLetzterLogin.Name = "dtpLetzterLogin";
            this.dtpLetzterLogin.Size = new System.Drawing.Size(246, 29);
            this.dtpLetzterLogin.TabIndex = 15;
            // 
            // dtpAktualisiertAm
            // 
            this.dtpAktualisiertAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAktualisiertAm.Location = new System.Drawing.Point(607, 160);
            this.dtpAktualisiertAm.Name = "dtpAktualisiertAm";
            this.dtpAktualisiertAm.Size = new System.Drawing.Size(246, 29);
            this.dtpAktualisiertAm.TabIndex = 14;
            // 
            // dtpErstelltAm
            // 
            this.dtpErstelltAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpErstelltAm.Location = new System.Drawing.Point(607, 98);
            this.dtpErstelltAm.Name = "dtpErstelltAm";
            this.dtpErstelltAm.Size = new System.Drawing.Size(246, 29);
            this.dtpErstelltAm.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ist Aktive:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Letzter Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Aktualisiert Am:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Erstellt Am:";
            // 
            // txtbBenutzerPasswort
            // 
            this.txtbBenutzerPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBenutzerPasswort.Location = new System.Drawing.Point(198, 314);
            this.txtbBenutzerPasswort.Name = "txtbBenutzerPasswort";
            this.txtbBenutzerPasswort.PasswordChar = '*';
            this.txtbBenutzerPasswort.Size = new System.Drawing.Size(207, 29);
            this.txtbBenutzerPasswort.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Benutzer Passwort:";
            // 
            // txtbRolle
            // 
            this.txtbRolle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRolle.Location = new System.Drawing.Point(198, 256);
            this.txtbRolle.Name = "txtbRolle";
            this.txtbRolle.Size = new System.Drawing.Size(207, 29);
            this.txtbRolle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rolle:";
            // 
            // lblBenutzerID
            // 
            this.lblBenutzerID.AutoSize = true;
            this.lblBenutzerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBenutzerID.Location = new System.Drawing.Point(194, 149);
            this.lblBenutzerID.Name = "lblBenutzerID";
            this.lblBenutzerID.Size = new System.Drawing.Size(39, 20);
            this.lblBenutzerID.TabIndex = 3;
            this.lblBenutzerID.Text = "???";
            this.lblBenutzerID.Click += new System.EventHandler(this.lblBenutzerID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BenutzerID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPersonID.Location = new System.Drawing.Point(194, 98);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(39, 20);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonID: ";
            // 
            // btnZurPersonInfoSeite
            // 
            this.btnZurPersonInfoSeite.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZurPersonInfoSeite.Enabled = false;
            this.btnZurPersonInfoSeite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZurPersonInfoSeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurPersonInfoSeite.ForeColor = System.Drawing.Color.Black;
            this.btnZurPersonInfoSeite.Image = global::Kliniken.Properties.Resources.Prev_32;
            this.btnZurPersonInfoSeite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZurPersonInfoSeite.Location = new System.Drawing.Point(33, 582);
            this.btnZurPersonInfoSeite.Name = "btnZurPersonInfoSeite";
            this.btnZurPersonInfoSeite.Size = new System.Drawing.Size(349, 50);
            this.btnZurPersonInfoSeite.TabIndex = 6;
            this.btnZurPersonInfoSeite.Text = "zurück zur PersonInfo Seite";
            this.btnZurPersonInfoSeite.UseVisualStyleBackColor = false;
            this.btnZurPersonInfoSeite.Click += new System.EventHandler(this.btnZurPersonInfoSeite_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAktualisierenUndNeuenBenutzerHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 666);
            this.Controls.Add(this.btnZurPersonInfoSeite);
            this.Controls.Add(this.tbPersonInfo);
            this.Controls.Add(this.btnZuBenutzerSeite);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmAktualisierenUndNeuenBenutzerHinzufügen";
            this.Text = "frmNachPersonSuchen";
            this.Load += new System.EventHandler(this.frmNachPersonSuchen_Load);
            this.tbPersonInfo.ResumeLayout(false);
            this.tabPage1PersonInfo.ResumeLayout(false);
            this.tabPage2BenutzerInfo.ResumeLayout(false);
            this.tabPage2BenutzerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPersonenDatenMitFilter ctrPersonenFilter1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnZuBenutzerSeite;
        private System.Windows.Forms.TabControl tbPersonInfo;
        private System.Windows.Forms.TabPage tabPage1PersonInfo;
        private System.Windows.Forms.TabPage tabPage2BenutzerInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbRolle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBenutzerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpLetzterLogin;
        private System.Windows.Forms.DateTimePicker dtpAktualisiertAm;
        private System.Windows.Forms.DateTimePicker dtpErstelltAm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbBenutzerPasswort;
        private System.Windows.Forms.Button btnBenutzerDatenSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnZurPersonInfoSeite;
        private System.Windows.Forms.CheckBox cbIstAktive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}