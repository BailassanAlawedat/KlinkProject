namespace Kliniken
{
    partial class frmTerminenListeAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.dgvTerminen = new System.Windows.Forms.DataGridView();
            this.cmsTerminen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.patienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArztDatenAnzeigen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TerminListeAnzeigentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTerminAktualisieren = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiTerminLöschen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NeuesRezeptHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezeptAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZurPatientenListe = new System.Windows.Forms.Button();
            this.cbFilterNachTerminStatus = new System.Windows.Forms.ComboBox();
            this.btnZurÄrztenListe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminen)).BeginInit();
            this.cmsTerminen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(454, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminen Liste ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter nach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Record: ";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(90, 612);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "###";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Alle",
            "TerminID",
            "VersicherungsName",
            "ArztVollname",
            "PatientenVollnam",
            "TerminStatus"});
            this.cbFilterBei.Location = new System.Drawing.Point(117, 267);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(239, 28);
            this.cbFilterBei.TabIndex = 4;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(362, 267);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(245, 29);
            this.txtbFilterWert.TabIndex = 5;
            this.txtbFilterWert.Visible = false;
            this.txtbFilterWert.TextChanged += new System.EventHandler(this.txtbFilterWert_TextChanged);
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            // 
            // dgvTerminen
            // 
            this.dgvTerminen.AllowUserToAddRows = false;
            this.dgvTerminen.AllowUserToDeleteRows = false;
            this.dgvTerminen.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerminen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTerminen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminen.ContextMenuStrip = this.cmsTerminen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerminen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerminen.Location = new System.Drawing.Point(16, 301);
            this.dgvTerminen.Name = "dgvTerminen";
            this.dgvTerminen.ReadOnly = true;
            this.dgvTerminen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerminen.Size = new System.Drawing.Size(1128, 305);
            this.dgvTerminen.TabIndex = 6;
            // 
            // cmsTerminen
            // 
            this.cmsTerminen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patienToolStripMenuItem,
            this.tsmiArztDatenAnzeigen,
            this.toolStripSeparator1,
            this.TerminListeAnzeigentoolStripMenuItem1,
            this.tsmiTerminAktualisieren,
            this.tmsiTerminLöschen,
            this.toolStripSeparator2,
            this.NeuesRezeptHinzufügenToolStripMenuItem,
            this.rezeptAktualisierenToolStripMenuItem});
            this.cmsTerminen.Name = "cmsTerminen";
            this.cmsTerminen.Size = new System.Drawing.Size(275, 282);
            this.cmsTerminen.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTerminen_Opening);
            // 
            // patienToolStripMenuItem
            // 
            this.patienToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patienToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.patienToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patienToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patienToolStripMenuItem.Name = "patienToolStripMenuItem";
            this.patienToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.patienToolStripMenuItem.Text = "Patienten Details anzeigen";
            this.patienToolStripMenuItem.Click += new System.EventHandler(this.patienToolStripMenuItem_Click);
            // 
            // tsmiArztDatenAnzeigen
            // 
            this.tsmiArztDatenAnzeigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiArztDatenAnzeigen.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.tsmiArztDatenAnzeigen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiArztDatenAnzeigen.Name = "tsmiArztDatenAnzeigen";
            this.tsmiArztDatenAnzeigen.Size = new System.Drawing.Size(274, 38);
            this.tsmiArztDatenAnzeigen.Text = "Arzt Details anzeigen";
            this.tsmiArztDatenAnzeigen.Click += new System.EventHandler(this.tsmiArztDatenAnzeigen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // TerminListeAnzeigentoolStripMenuItem1
            // 
            this.TerminListeAnzeigentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminListeAnzeigentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.List_32;
            this.TerminListeAnzeigentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TerminListeAnzeigentoolStripMenuItem1.Name = "TerminListeAnzeigentoolStripMenuItem1";
            this.TerminListeAnzeigentoolStripMenuItem1.Size = new System.Drawing.Size(274, 38);
            this.TerminListeAnzeigentoolStripMenuItem1.Text = "Termin Liste anzeigen";
            this.TerminListeAnzeigentoolStripMenuItem1.Click += new System.EventHandler(this.TerminListeAnzeigentoolStripMenuItem1_Click);
            // 
            // tsmiTerminAktualisieren
            // 
            this.tsmiTerminAktualisieren.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTerminAktualisieren.Image = global::Kliniken.Properties.Resources.edit_32;
            this.tsmiTerminAktualisieren.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTerminAktualisieren.Name = "tsmiTerminAktualisieren";
            this.tsmiTerminAktualisieren.Size = new System.Drawing.Size(274, 38);
            this.tsmiTerminAktualisieren.Text = "Termin aktualisieren";
            this.tsmiTerminAktualisieren.Click += new System.EventHandler(this.tsmiTerminAktualisieren_Click);
            // 
            // tmsiTerminLöschen
            // 
            this.tmsiTerminLöschen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiTerminLöschen.Image = global::Kliniken.Properties.Resources.Delete_32_2;
            this.tmsiTerminLöschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsiTerminLöschen.Name = "tmsiTerminLöschen";
            this.tmsiTerminLöschen.Size = new System.Drawing.Size(274, 38);
            this.tmsiTerminLöschen.Text = "Termin entfernen";
            this.tmsiTerminLöschen.Click += new System.EventHandler(this.tmsiTerminLöschen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // NeuesRezeptHinzufügenToolStripMenuItem
            // 
            this.NeuesRezeptHinzufügenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeuesRezeptHinzufügenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Detained_Driving_License_32;
            this.NeuesRezeptHinzufügenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NeuesRezeptHinzufügenToolStripMenuItem.Name = "NeuesRezeptHinzufügenToolStripMenuItem";
            this.NeuesRezeptHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.NeuesRezeptHinzufügenToolStripMenuItem.Text = "Neues Rezept hinzufügen";
            this.NeuesRezeptHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.NeuesRezeptHinzufügenToolStripMenuItem_Click);
            // 
            // rezeptAktualisierenToolStripMenuItem
            // 
            this.rezeptAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezeptAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Detained_Driving_License_32;
            this.rezeptAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rezeptAktualisierenToolStripMenuItem.Name = "rezeptAktualisierenToolStripMenuItem";
            this.rezeptAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.rezeptAktualisierenToolStripMenuItem.Text = "Rezept aktualisieren";
            this.rezeptAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.rezeptAktualisierenToolStripMenuItem_Click);
            // 
            // btnZurPatientenListe
            // 
            this.btnZurPatientenListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZurPatientenListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnZurPatientenListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurPatientenListe.Location = new System.Drawing.Point(857, 262);
            this.btnZurPatientenListe.Name = "btnZurPatientenListe";
            this.btnZurPatientenListe.Size = new System.Drawing.Size(287, 36);
            this.btnZurPatientenListe.TabIndex = 8;
            this.btnZurPatientenListe.Text = "Zur Patienten Liste";
            this.btnZurPatientenListe.UseVisualStyleBackColor = false;
            this.btnZurPatientenListe.Click += new System.EventHandler(this.btnZurPatientenListe_Click);
            // 
            // cbFilterNachTerminStatus
            // 
            this.cbFilterNachTerminStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterNachTerminStatus.FormattingEnabled = true;
            this.cbFilterNachTerminStatus.Items.AddRange(new object[] {
            "Alle ",
            "Erledigt",
            "Nicht Erledigt"});
            this.cbFilterNachTerminStatus.Location = new System.Drawing.Point(362, 267);
            this.cbFilterNachTerminStatus.Name = "cbFilterNachTerminStatus";
            this.cbFilterNachTerminStatus.Size = new System.Drawing.Size(163, 28);
            this.cbFilterNachTerminStatus.TabIndex = 10;
            this.cbFilterNachTerminStatus.Visible = false;
            this.cbFilterNachTerminStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterNachTerminStatus_SelectedIndexChanged);
            // 
            // btnZurÄrztenListe
            // 
            this.btnZurÄrztenListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZurÄrztenListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnZurÄrztenListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurÄrztenListe.Location = new System.Drawing.Point(857, 220);
            this.btnZurÄrztenListe.Name = "btnZurÄrztenListe";
            this.btnZurÄrztenListe.Size = new System.Drawing.Size(287, 36);
            this.btnZurÄrztenListe.TabIndex = 12;
            this.btnZurÄrztenListe.Text = "Zur Ärzten Liste";
            this.btnZurÄrztenListe.UseVisualStyleBackColor = false;
            this.btnZurÄrztenListe.Click += new System.EventHandler(this.btnZurÄrztenListe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.appointment;
            this.pictureBox1.Location = new System.Drawing.Point(446, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmTerminenListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 643);
            this.Controls.Add(this.btnZurÄrztenListe);
            this.Controls.Add(this.cbFilterNachTerminStatus);
            this.Controls.Add(this.btnZurPatientenListe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTerminen);
            this.Controls.Add(this.txtbFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTerminenListeAnzeigen";
            this.Text = "frmTerminenListeAnzeigen";
            this.Load += new System.EventHandler(this.frmTerminenListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminen)).EndInit();
            this.cmsTerminen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.DataGridView dgvTerminen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZurPatientenListe;
        private System.Windows.Forms.ComboBox cbFilterNachTerminStatus;
        private System.Windows.Forms.ContextMenuStrip cmsTerminen;
        private System.Windows.Forms.ToolStripMenuItem patienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTerminAktualisieren;
        private System.Windows.Forms.ToolStripMenuItem tsmiArztDatenAnzeigen;
        private System.Windows.Forms.ToolStripMenuItem tmsiTerminLöschen;
        private System.Windows.Forms.Button btnZurÄrztenListe;
        private System.Windows.Forms.ToolStripMenuItem NeuesRezeptHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezeptAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TerminListeAnzeigentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}