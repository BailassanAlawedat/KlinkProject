namespace Kliniken
{
    partial class frmPersonenListeAnziegen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personDatenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personDatenAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personDatenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.personZuPatientAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personZuArztAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.btnPersonHinzufügen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upDownPersonenSeite = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPersonenSeite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personen Liste";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.ContextMenuStrip = this.cmsPerson;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerson.Location = new System.Drawing.Point(34, 252);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerson.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(1130, 511);
            this.dgvPerson.TabIndex = 2;
            // 
            // cmsPerson
            // 
            this.cmsPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personDatenAnzeigenToolStripMenuItem,
            this.personDatenAktualisierenToolStripMenuItem,
            this.personDatenLöschenToolStripMenuItem,
            this.toolStripSeparator1,
            this.personZuPatientAktualisierenToolStripMenuItem,
            this.personZuArztAktualisierenToolStripMenuItem});
            this.cmsPerson.Name = "cmsPerson";
            this.cmsPerson.Size = new System.Drawing.Size(356, 200);
            // 
            // personDatenAnzeigenToolStripMenuItem
            // 
            this.personDatenAnzeigenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDatenAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.personDatenAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personDatenAnzeigenToolStripMenuItem.Name = "personDatenAnzeigenToolStripMenuItem";
            this.personDatenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(355, 38);
            this.personDatenAnzeigenToolStripMenuItem.Text = "Person Daten anzeigen";
            this.personDatenAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.personDatenAnzeigenToolStripMenuItem_Click);
            // 
            // personDatenAktualisierenToolStripMenuItem
            // 
            this.personDatenAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDatenAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.edit_32;
            this.personDatenAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personDatenAktualisierenToolStripMenuItem.Name = "personDatenAktualisierenToolStripMenuItem";
            this.personDatenAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(355, 38);
            this.personDatenAktualisierenToolStripMenuItem.Text = "Person Daten aktualisieren";
            this.personDatenAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.personDatenAktualisierenToolStripMenuItem_Click);
            // 
            // personDatenLöschenToolStripMenuItem
            // 
            this.personDatenLöschenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDatenLöschenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32;
            this.personDatenLöschenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personDatenLöschenToolStripMenuItem.Name = "personDatenLöschenToolStripMenuItem";
            this.personDatenLöschenToolStripMenuItem.Size = new System.Drawing.Size(355, 38);
            this.personDatenLöschenToolStripMenuItem.Text = "Person Daten löschen";
            this.personDatenLöschenToolStripMenuItem.Click += new System.EventHandler(this.personDatenLöschenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(352, 6);
            // 
            // personZuPatientAktualisierenToolStripMenuItem
            // 
            this.personZuPatientAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personZuPatientAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Sign_Out_32;
            this.personZuPatientAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personZuPatientAktualisierenToolStripMenuItem.Name = "personZuPatientAktualisierenToolStripMenuItem";
            this.personZuPatientAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(355, 38);
            this.personZuPatientAktualisierenToolStripMenuItem.Text = "Person zu Patient aktualisieren";
            this.personZuPatientAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.personZuPatientAktualisierenToolStripMenuItem_Click);
            // 
            // personZuArztAktualisierenToolStripMenuItem
            // 
            this.personZuArztAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personZuArztAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Sign_Out_32;
            this.personZuArztAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personZuArztAktualisierenToolStripMenuItem.Name = "personZuArztAktualisierenToolStripMenuItem";
            this.personZuArztAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(355, 38);
            this.personZuArztAktualisierenToolStripMenuItem.Text = "Person zu Arzt aktualisieren";
            this.personZuArztAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.personZuArztAktualisierenToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter bei:";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Keine",
            "PersonID",
            "AusweisID",
            "Vorname",
            "Nachname",
            "Stadt",
            "Postleitzahl",
            "Straße",
            "Geschlecht"});
            this.cbFilterBei.Location = new System.Drawing.Point(136, 218);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(201, 32);
            this.cbFilterBei.TabIndex = 4;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(343, 218);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(367, 31);
            this.txtFilterWert.TabIndex = 5;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // btnPersonHinzufügen
            // 
            this.btnPersonHinzufügen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonHinzufügen.BackColor = System.Drawing.Color.Blue;
            this.btnPersonHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonHinzufügen.ForeColor = System.Drawing.Color.White;
            this.btnPersonHinzufügen.Location = new System.Drawing.Point(860, 200);
            this.btnPersonHinzufügen.Name = "btnPersonHinzufügen";
            this.btnPersonHinzufügen.Size = new System.Drawing.Size(304, 50);
            this.btnPersonHinzufügen.TabIndex = 6;
            this.btnPersonHinzufügen.Text = "Neue Person hinzufügen";
            this.btnPersonHinzufügen.UseVisualStyleBackColor = false;
            this.btnPersonHinzufügen.Click += new System.EventHandler(this.btnPersonHinzufügen_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 766);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "#Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(120, 766);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(43, 24);
            this.lblRecord.TabIndex = 8;
            this.lblRecord.Text = "???";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(646, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // upDownPersonenSeite
            // 
            this.upDownPersonenSeite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownPersonenSeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownPersonenSeite.Location = new System.Drawing.Point(1044, 163);
            this.upDownPersonenSeite.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.upDownPersonenSeite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownPersonenSeite.Name = "upDownPersonenSeite";
            this.upDownPersonenSeite.Size = new System.Drawing.Size(120, 31);
            this.upDownPersonenSeite.TabIndex = 10;
            this.upDownPersonenSeite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownPersonenSeite.ValueChanged += new System.EventHandler(this.upDownPersonenSeite_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1032, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personen Seite";
            // 
            // frmPersonenListeAnziegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 791);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDownPersonenSeite);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPersonHinzufügen);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPersonenListeAnziegen";
            this.Text = "frmPersonenListeAnziegen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonenListeAnziegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPersonenSeite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.Button btnPersonHinzufügen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem personDatenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personDatenAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personDatenLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem personZuPatientAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personZuArztAktualisierenToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown upDownPersonenSeite;
        private System.Windows.Forms.Label label4;
    }
}