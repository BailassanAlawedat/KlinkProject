namespace Kliniken
{
    partial class frmÄrzteListeAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArztHinzufügen = new System.Windows.Forms.Button();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvÄrzte = new System.Windows.Forms.DataGridView();
            this.cmsArzt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arztDatenAnziegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arztDatenAkualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arztDatenLöshenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZurückZurTerminListe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvÄrzte)).BeginInit();
            this.cmsArzt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(107, 586);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 17;
            this.lblRecord.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "#Record:";
            // 
            // btnArztHinzufügen
            // 
            this.btnArztHinzufügen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnArztHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArztHinzufügen.Location = new System.Drawing.Point(862, 201);
            this.btnArztHinzufügen.Name = "btnArztHinzufügen";
            this.btnArztHinzufügen.Size = new System.Drawing.Size(304, 36);
            this.btnArztHinzufügen.TabIndex = 15;
            this.btnArztHinzufügen.Text = "Neuer Arzt hinzufügen";
            this.btnArztHinzufügen.UseVisualStyleBackColor = false;
            this.btnArztHinzufügen.Click += new System.EventHandler(this.btnArztHinzufügen_Click);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(318, 209);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(226, 29);
            this.txtFilterWert.TabIndex = 14;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Keine",
            "ArztID",
            "PersonID",
            "AusweisID",
            "Vollname"});
            this.cbFilterBei.Location = new System.Drawing.Point(111, 209);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(201, 28);
            this.cbFilterBei.TabIndex = 13;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter bei:";
            // 
            // dgvÄrzte
            // 
            this.dgvÄrzte.AllowUserToAddRows = false;
            this.dgvÄrzte.AllowUserToDeleteRows = false;
            this.dgvÄrzte.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvÄrzte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvÄrzte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvÄrzte.ContextMenuStrip = this.cmsArzt;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvÄrzte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvÄrzte.Location = new System.Drawing.Point(25, 243);
            this.dgvÄrzte.Name = "dgvÄrzte";
            this.dgvÄrzte.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvÄrzte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvÄrzte.RowHeadersWidth = 51;
            this.dgvÄrzte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvÄrzte.Size = new System.Drawing.Size(1141, 331);
            this.dgvÄrzte.TabIndex = 11;
            // 
            // cmsArzt
            // 
            this.cmsArzt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsArzt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arztDatenAnziegenToolStripMenuItem,
            this.arztDatenAkualisierenToolStripMenuItem,
            this.arztDatenLöshenToolStripMenuItem});
            this.cmsArzt.Name = "cmsArzt";
            this.cmsArzt.Size = new System.Drawing.Size(254, 118);
            // 
            // arztDatenAnziegenToolStripMenuItem
            // 
            this.arztDatenAnziegenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arztDatenAnziegenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.arztDatenAnziegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arztDatenAnziegenToolStripMenuItem.Name = "arztDatenAnziegenToolStripMenuItem";
            this.arztDatenAnziegenToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.arztDatenAnziegenToolStripMenuItem.Text = "Arzt Daten anziegen";
            this.arztDatenAnziegenToolStripMenuItem.Click += new System.EventHandler(this.arztDatenAnziegenToolStripMenuItem_Click);
            // 
            // arztDatenAkualisierenToolStripMenuItem
            // 
            this.arztDatenAkualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arztDatenAkualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.edit_32;
            this.arztDatenAkualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arztDatenAkualisierenToolStripMenuItem.Name = "arztDatenAkualisierenToolStripMenuItem";
            this.arztDatenAkualisierenToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.arztDatenAkualisierenToolStripMenuItem.Text = "Arzt Daten akualisieren";
            this.arztDatenAkualisierenToolStripMenuItem.Click += new System.EventHandler(this.arztDatenAkualisierenToolStripMenuItem_Click);
            // 
            // arztDatenLöshenToolStripMenuItem
            // 
            this.arztDatenLöshenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arztDatenLöshenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32;
            this.arztDatenLöshenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arztDatenLöshenToolStripMenuItem.Name = "arztDatenLöshenToolStripMenuItem";
            this.arztDatenLöshenToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.arztDatenLöshenToolStripMenuItem.Text = "Arzt Daten löshen";
            this.arztDatenLöshenToolStripMenuItem.Click += new System.EventHandler(this.arztDatenLöshenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ärzte Liste";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.doctor_patient;
            this.pictureBox1.Location = new System.Drawing.Point(484, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnZurückZurTerminListe
            // 
            this.btnZurückZurTerminListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnZurückZurTerminListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurückZurTerminListe.Location = new System.Drawing.Point(550, 201);
            this.btnZurückZurTerminListe.Name = "btnZurückZurTerminListe";
            this.btnZurückZurTerminListe.Size = new System.Drawing.Size(304, 36);
            this.btnZurückZurTerminListe.TabIndex = 18;
            this.btnZurückZurTerminListe.Text = "zur TerminListe";
            this.btnZurückZurTerminListe.UseVisualStyleBackColor = false;
            this.btnZurückZurTerminListe.Click += new System.EventHandler(this.btnZurückZurTerminListe_Click);
            // 
            // frmÄrzteListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 614);
            this.Controls.Add(this.btnZurückZurTerminListe);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArztHinzufügen);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvÄrzte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmÄrzteListeAnzeigen";
            this.Text = "frmÄrzteListeAnzeigen";
            this.Load += new System.EventHandler(this.frmÄrzteListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvÄrzte)).EndInit();
            this.cmsArzt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArztHinzufügen;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvÄrzte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsArzt;
        private System.Windows.Forms.ToolStripMenuItem arztDatenAnziegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arztDatenAkualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arztDatenLöshenToolStripMenuItem;
        private System.Windows.Forms.Button btnZurückZurTerminListe;
    }
}