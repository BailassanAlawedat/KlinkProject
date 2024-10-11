namespace Kliniken
{
    partial class frmAktualisierenUndNeuenTerminHinzufügen
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblTerminID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFachrichtung = new System.Windows.Forms.ComboBox();
            this.dgvArzt = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbErledigt = new System.Windows.Forms.CheckBox();
            this.cbNichtErledigt = new System.Windows.Forms.CheckBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnTerminHinzugüfgen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArztID = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVersicherungen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTerminDatum = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnZurTabelle = new System.Windows.Forms.Button();
            this.txtTerminZeit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArzt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termin ID:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitel.Location = new System.Drawing.Point(228, 34);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(348, 31);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Neuen Termin hinzufügen";
            // 
            // lblTerminID
            // 
            this.lblTerminID.AutoSize = true;
            this.lblTerminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminID.ForeColor = System.Drawing.Color.Maroon;
            this.lblTerminID.Location = new System.Drawing.Point(692, 118);
            this.lblTerminID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerminID.Name = "lblTerminID";
            this.lblTerminID.Size = new System.Drawing.Size(29, 20);
            this.lblTerminID.TabIndex = 2;
            this.lblTerminID.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fachrichtung Name: ";
            // 
            // cbFachrichtung
            // 
            this.cbFachrichtung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFachrichtung.FormattingEnabled = true;
            this.cbFachrichtung.Location = new System.Drawing.Point(199, 306);
            this.cbFachrichtung.Margin = new System.Windows.Forms.Padding(2);
            this.cbFachrichtung.Name = "cbFachrichtung";
            this.cbFachrichtung.Size = new System.Drawing.Size(275, 28);
            this.cbFachrichtung.TabIndex = 4;
            this.cbFachrichtung.SelectedIndexChanged += new System.EventHandler(this.cbFachrichtung_SelectedIndexChanged);
            // 
            // dgvArzt
            // 
            this.dgvArzt.AllowUserToAddRows = false;
            this.dgvArzt.AllowUserToDeleteRows = false;
            this.dgvArzt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArzt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArzt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArzt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArzt.Location = new System.Drawing.Point(21, 353);
            this.dgvArzt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArzt.MultiSelect = false;
            this.dgvArzt.Name = "dgvArzt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArzt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArzt.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArzt.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArzt.RowTemplate.Height = 24;
            this.dgvArzt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArzt.Size = new System.Drawing.Size(815, 290);
            this.dgvArzt.TabIndex = 5;
            this.dgvArzt.SelectionChanged += new System.EventHandler(this.dgvArzt_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Termin Zeit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Termin Status:";
            // 
            // cbErledigt
            // 
            this.cbErledigt.AutoSize = true;
            this.cbErledigt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbErledigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbErledigt.ForeColor = System.Drawing.Color.Black;
            this.cbErledigt.Location = new System.Drawing.Point(544, 308);
            this.cbErledigt.Margin = new System.Windows.Forms.Padding(2);
            this.cbErledigt.Name = "cbErledigt";
            this.cbErledigt.Size = new System.Drawing.Size(101, 28);
            this.cbErledigt.TabIndex = 15;
            this.cbErledigt.Text = "Erledigt";
            this.cbErledigt.UseVisualStyleBackColor = false;
            this.cbErledigt.Click += new System.EventHandler(this.cbErledigt_Click);
            // 
            // cbNichtErledigt
            // 
            this.cbNichtErledigt.AutoSize = true;
            this.cbNichtErledigt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbNichtErledigt.Checked = true;
            this.cbNichtErledigt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNichtErledigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNichtErledigt.ForeColor = System.Drawing.Color.Black;
            this.cbNichtErledigt.Location = new System.Drawing.Point(664, 308);
            this.cbNichtErledigt.Margin = new System.Windows.Forms.Padding(2);
            this.cbNichtErledigt.Name = "cbNichtErledigt";
            this.cbNichtErledigt.Size = new System.Drawing.Size(155, 28);
            this.cbNichtErledigt.TabIndex = 16;
            this.cbNichtErledigt.Text = "Nicht Erledigt";
            this.cbNichtErledigt.UseVisualStyleBackColor = false;
            this.cbNichtErledigt.Click += new System.EventHandler(this.cbNichtErledigt_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(21, 657);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(373, 38);
            this.btnAbbrechen.TabIndex = 17;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnTerminHinzugüfgen
            // 
            this.btnTerminHinzugüfgen.BackColor = System.Drawing.SystemColors.Window;
            this.btnTerminHinzugüfgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminHinzugüfgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminHinzugüfgen.Location = new System.Drawing.Point(441, 659);
            this.btnTerminHinzugüfgen.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerminHinzugüfgen.Name = "btnTerminHinzugüfgen";
            this.btnTerminHinzugüfgen.Size = new System.Drawing.Size(393, 38);
            this.btnTerminHinzugüfgen.TabIndex = 18;
            this.btnTerminHinzugüfgen.Text = "Termin hinzufügen";
            this.btnTerminHinzugüfgen.UseVisualStyleBackColor = false;
            this.btnTerminHinzugüfgen.Click += new System.EventHandler(this.btnTerminHinzugüfgen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(617, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Arzt ID:";
            // 
            // lblArztID
            // 
            this.lblArztID.AutoSize = true;
            this.lblArztID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArztID.ForeColor = System.Drawing.Color.Maroon;
            this.lblArztID.Location = new System.Drawing.Point(692, 168);
            this.lblArztID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArztID.Name = "lblArztID";
            this.lblArztID.Size = new System.Drawing.Size(29, 20);
            this.lblArztID.TabIndex = 20;
            this.lblArztID.Text = "??";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(593, 217);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(95, 20);
            this.lable.TabIndex = 21;
            this.lable.Text = "Patient ID:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Maroon;
            this.lblPatientID.Location = new System.Drawing.Point(692, 217);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(29, 20);
            this.lblPatientID.TabIndex = 22;
            this.lblPatientID.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Versicherung Name:";
            // 
            // cbVersicherungen
            // 
            this.cbVersicherungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVersicherungen.FormattingEnabled = true;
            this.cbVersicherungen.Location = new System.Drawing.Point(199, 267);
            this.cbVersicherungen.Margin = new System.Windows.Forms.Padding(2);
            this.cbVersicherungen.Name = "cbVersicherungen";
            this.cbVersicherungen.Size = new System.Drawing.Size(275, 28);
            this.cbVersicherungen.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Termin Datum:";
            // 
            // dtpTerminDatum
            // 
            this.dtpTerminDatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTerminDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTerminDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTerminDatum.Location = new System.Drawing.Point(199, 154);
            this.dtpTerminDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTerminDatum.Name = "dtpTerminDatum";
            this.dtpTerminDatum.Size = new System.Drawing.Size(174, 29);
            this.dtpTerminDatum.TabIndex = 28;
            this.dtpTerminDatum.Value = new System.DateTime(2024, 8, 12, 0, 0, 0, 0);
            // 
            // btnZurTabelle
            // 
            this.btnZurTabelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZurTabelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnZurTabelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurTabelle.ForeColor = System.Drawing.Color.White;
            this.btnZurTabelle.Location = new System.Drawing.Point(199, 98);
            this.btnZurTabelle.Name = "btnZurTabelle";
            this.btnZurTabelle.Size = new System.Drawing.Size(174, 40);
            this.btnZurTabelle.TabIndex = 29;
            this.btnZurTabelle.Text = "zur Tabelle";
            this.btnZurTabelle.UseVisualStyleBackColor = false;
            this.btnZurTabelle.Click += new System.EventHandler(this.btnZurTabelle_Click);
            // 
            // txtTerminZeit
            // 
            this.txtTerminZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminZeit.Location = new System.Drawing.Point(199, 209);
            this.txtTerminZeit.Name = "txtTerminZeit";
            this.txtTerminZeit.Size = new System.Drawing.Size(174, 29);
            this.txtTerminZeit.TabIndex = 30;
            // 
            // frmAktualisierenUndNeuenTerminHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 708);
            this.Controls.Add(this.txtTerminZeit);
            this.Controls.Add(this.btnZurTabelle);
            this.Controls.Add(this.dtpTerminDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbVersicherungen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.lblArztID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTerminHinzugüfgen);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.cbNichtErledigt);
            this.Controls.Add(this.cbErledigt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvArzt);
            this.Controls.Add(this.cbFachrichtung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTerminID);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAktualisierenUndNeuenTerminHinzufügen";
            this.Text = "frmAktualisierenUndNeuenTerminHinzufügen";
            this.Load += new System.EventHandler(this.frmAktualisierenUndNeuenTerminHinzufügen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArzt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblTerminID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFachrichtung;
        private System.Windows.Forms.DataGridView dgvArzt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbErledigt;
        private System.Windows.Forms.CheckBox cbNichtErledigt;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnTerminHinzugüfgen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblArztID;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVersicherungen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTerminDatum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnZurTabelle;
        private System.Windows.Forms.TextBox txtTerminZeit;
    }
}