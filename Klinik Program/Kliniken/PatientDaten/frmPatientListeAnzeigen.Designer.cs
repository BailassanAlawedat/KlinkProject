namespace Kliniken
{
    partial class frmPatientListeAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPatientHinzufügen = new System.Windows.Forms.Button();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.cmsPatienten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTerminVereinbaren = new System.Windows.Forms.ToolStripMenuItem();
            this.TerminListeAnzeigentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDatenAnseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDatenAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDatenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZurückZurTerminListe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.cmsPatienten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(114, 680);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 17;
            this.lblRecord.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 680);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "#Record:";
            // 
            // btnPatientHinzufügen
            // 
            this.btnPatientHinzufügen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPatientHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientHinzufügen.Location = new System.Drawing.Point(1003, 233);
            this.btnPatientHinzufügen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPatientHinzufügen.Name = "btnPatientHinzufügen";
            this.btnPatientHinzufügen.Size = new System.Drawing.Size(355, 47);
            this.btnPatientHinzufügen.TabIndex = 15;
            this.btnPatientHinzufügen.Text = "Neue Patient hinzufügen";
            this.btnPatientHinzufügen.UseVisualStyleBackColor = false;
            this.btnPatientHinzufügen.Click += new System.EventHandler(this.btnPatientHinzufügen_Click);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(360, 245);
            this.txtFilterWert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(263, 31);
            this.txtFilterWert.TabIndex = 14;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Keine",
            "PatientID",
            "PersonID",
            "AusweisID",
            "Vollname",
            "Email"});
            this.cbFilterBei.Location = new System.Drawing.Point(119, 245);
            this.cbFilterBei.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(234, 32);
            this.cbFilterBei.TabIndex = 13;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.ContextMenuStrip = this.cmsPatienten;
            this.dgvPatient.Location = new System.Drawing.Point(19, 284);
            this.dgvPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatient.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(1339, 382);
            this.dgvPatient.TabIndex = 11;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            // 
            // cmsPatienten
            // 
            this.cmsPatienten.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPatienten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTerminVereinbaren,
            this.TerminListeAnzeigentoolStripMenuItem1,
            this.patientDatenAnseToolStripMenuItem,
            this.patientDatenAktualisierenToolStripMenuItem,
            this.patientDatenLöschenToolStripMenuItem});
            this.cmsPatienten.Name = "cmsPatienten";
            this.cmsPatienten.Size = new System.Drawing.Size(321, 194);
            // 
            // tsmiTerminVereinbaren
            // 
            this.tsmiTerminVereinbaren.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTerminVereinbaren.Image = global::Kliniken.Properties.Resources.AddAppointment_32;
            this.tsmiTerminVereinbaren.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTerminVereinbaren.Name = "tsmiTerminVereinbaren";
            this.tsmiTerminVereinbaren.Size = new System.Drawing.Size(320, 38);
            this.tsmiTerminVereinbaren.Text = "Termin vereinbaren";
            this.tsmiTerminVereinbaren.Click += new System.EventHandler(this.tsmiTerminVereinbaren_Click);
            // 
            // TerminListeAnzeigentoolStripMenuItem1
            // 
            this.TerminListeAnzeigentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminListeAnzeigentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.List_32;
            this.TerminListeAnzeigentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TerminListeAnzeigentoolStripMenuItem1.Name = "TerminListeAnzeigentoolStripMenuItem1";
            this.TerminListeAnzeigentoolStripMenuItem1.Size = new System.Drawing.Size(320, 38);
            this.TerminListeAnzeigentoolStripMenuItem1.Text = "Termin Liste anzeigen";
            this.TerminListeAnzeigentoolStripMenuItem1.Click += new System.EventHandler(this.TerminListeAnzeigentoolStripMenuItem1_Click);
            // 
            // patientDatenAnseToolStripMenuItem
            // 
            this.patientDatenAnseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDatenAnseToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.patientDatenAnseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientDatenAnseToolStripMenuItem.Name = "patientDatenAnseToolStripMenuItem";
            this.patientDatenAnseToolStripMenuItem.Size = new System.Drawing.Size(320, 38);
            this.patientDatenAnseToolStripMenuItem.Text = "Patient Daten anzeigen";
            this.patientDatenAnseToolStripMenuItem.Click += new System.EventHandler(this.patientDatenAnseToolStripMenuItem_Click);
            // 
            // patientDatenAktualisierenToolStripMenuItem
            // 
            this.patientDatenAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDatenAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.edit_32;
            this.patientDatenAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientDatenAktualisierenToolStripMenuItem.Name = "patientDatenAktualisierenToolStripMenuItem";
            this.patientDatenAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(320, 38);
            this.patientDatenAktualisierenToolStripMenuItem.Text = "Patient Daten aktualisieren";
            this.patientDatenAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.patientDatenAktualisierenToolStripMenuItem_Click);
            // 
            // patientDatenLöschenToolStripMenuItem
            // 
            this.patientDatenLöschenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDatenLöschenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32_2;
            this.patientDatenLöschenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientDatenLöschenToolStripMenuItem.Name = "patientDatenLöschenToolStripMenuItem";
            this.patientDatenLöschenToolStripMenuItem.Size = new System.Drawing.Size(320, 38);
            this.patientDatenLöschenToolStripMenuItem.Text = "Patient Daten löschen";
            this.patientDatenLöschenToolStripMenuItem.Click += new System.EventHandler(this.patientDatenLöschenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patienten Liste";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.patient__1_;
            this.pictureBox1.Location = new System.Drawing.Point(510, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnZurückZurTerminListe
            // 
            this.btnZurückZurTerminListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnZurückZurTerminListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurückZurTerminListe.Location = new System.Drawing.Point(642, 233);
            this.btnZurückZurTerminListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZurückZurTerminListe.Name = "btnZurückZurTerminListe";
            this.btnZurückZurTerminListe.Size = new System.Drawing.Size(355, 47);
            this.btnZurückZurTerminListe.TabIndex = 19;
            this.btnZurückZurTerminListe.Text = "zur TerminListe";
            this.btnZurückZurTerminListe.UseVisualStyleBackColor = false;
            this.btnZurückZurTerminListe.Click += new System.EventHandler(this.btnZurückZurTerminListe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter bei:";
            // 
            // frmPatientListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1372, 713);
            this.Controls.Add(this.btnZurückZurTerminListe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPatientHinzufügen);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPatientListeAnzeigen";
            this.Text = "frmAktualisierenUndNeuPatientHinzufügen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPatientListeAnzeigen_FormClosed);
            this.Load += new System.EventHandler(this.frmPatientListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.cmsPatienten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPatientHinzufügen;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsPatienten;
        private System.Windows.Forms.ToolStripMenuItem patientDatenAnseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDatenAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDatenLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTerminVereinbaren;
        private System.Windows.Forms.ToolStripMenuItem TerminListeAnzeigentoolStripMenuItem1;
        private System.Windows.Forms.Button btnZurückZurTerminListe;
        private System.Windows.Forms.Label label2;
    }
}