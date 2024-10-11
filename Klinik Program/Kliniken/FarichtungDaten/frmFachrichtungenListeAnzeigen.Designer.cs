namespace Kliniken
{
    partial class frmFachrichtungenListeAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFachrichtung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFachrichtungHinzufügen = new System.Windows.Forms.Button();
            this.btnFachrichtungAktualisieren = new System.Windows.Forms.Button();
            this.cbFachrichtungen = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFachrichtung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecord.Location = new System.Drawing.Point(99, 578);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(29, 20);
            this.lblRecord.TabIndex = 9;
            this.lblRecord.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "#Record:";
            // 
            // dgvFachrichtung
            // 
            this.dgvFachrichtung.AllowUserToAddRows = false;
            this.dgvFachrichtung.AllowUserToDeleteRows = false;
            this.dgvFachrichtung.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFachrichtung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFachrichtung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFachrichtung.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFachrichtung.Location = new System.Drawing.Point(26, 245);
            this.dgvFachrichtung.Name = "dgvFachrichtung";
            this.dgvFachrichtung.ReadOnly = true;
            this.dgvFachrichtung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFachrichtung.Size = new System.Drawing.Size(710, 330);
            this.dgvFachrichtung.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(246, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fachrichtungen Liste";
            // 
            // btnFachrichtungHinzufügen
            // 
            this.btnFachrichtungHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFachrichtungHinzufügen.Location = new System.Drawing.Point(499, 204);
            this.btnFachrichtungHinzufügen.Name = "btnFachrichtungHinzufügen";
            this.btnFachrichtungHinzufügen.Size = new System.Drawing.Size(237, 35);
            this.btnFachrichtungHinzufügen.TabIndex = 10;
            this.btnFachrichtungHinzufügen.Text = "Neue Fachrichtung hinzufügen";
            this.btnFachrichtungHinzufügen.UseVisualStyleBackColor = true;
            this.btnFachrichtungHinzufügen.Click += new System.EventHandler(this.btnFachrichtungHinzufügen_Click);
            // 
            // btnFachrichtungAktualisieren
            // 
            this.btnFachrichtungAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFachrichtungAktualisieren.Location = new System.Drawing.Point(252, 204);
            this.btnFachrichtungAktualisieren.Name = "btnFachrichtungAktualisieren";
            this.btnFachrichtungAktualisieren.Size = new System.Drawing.Size(237, 35);
            this.btnFachrichtungAktualisieren.TabIndex = 11;
            this.btnFachrichtungAktualisieren.Text = "Fachrichtung aktualisieren";
            this.btnFachrichtungAktualisieren.UseVisualStyleBackColor = true;
            this.btnFachrichtungAktualisieren.Click += new System.EventHandler(this.btnFachrichtungAktualisieren_Click);
            // 
            // cbFachrichtungen
            // 
            this.cbFachrichtungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFachrichtungen.FormattingEnabled = true;
            this.cbFachrichtungen.Location = new System.Drawing.Point(26, 204);
            this.cbFachrichtungen.Name = "cbFachrichtungen";
            this.cbFachrichtungen.Size = new System.Drawing.Size(220, 28);
            this.cbFachrichtungen.TabIndex = 12;
            this.cbFachrichtungen.SelectedIndexChanged += new System.EventHandler(this.cbFachrichtungen_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.doctor_patient;
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmFachrichtungenListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 607);
            this.Controls.Add(this.cbFachrichtungen);
            this.Controls.Add(this.btnFachrichtungAktualisieren);
            this.Controls.Add(this.btnFachrichtungHinzufügen);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvFachrichtung);
            this.Controls.Add(this.label1);
            this.Name = "frmFachrichtungenListeAnzeigen";
            this.Text = "frmFachrichtungenListeAnzeigen";
            this.Load += new System.EventHandler(this.frmFachrichtungenListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFachrichtung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvFachrichtung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFachrichtungHinzufügen;
        private System.Windows.Forms.Button btnFachrichtungAktualisieren;
        private System.Windows.Forms.ComboBox cbFachrichtungen;
    }
}