namespace Kliniken
{
    partial class frmAktualisierenUndNeueBezahlungHinzufügen
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblBezahlungsID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBezahlungsDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBezahlungsBetrag = new System.Windows.Forms.TextBox();
            this.lblAbbrechen = new System.Windows.Forms.Button();
            this.lblSpeichern = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbBezahlungsMethode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitel.Location = new System.Drawing.Point(192, 34);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(398, 32);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Neue Bezahlung hinzufügen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bezahlung ID:";
            // 
            // lblBezahlungsID
            // 
            this.lblBezahlungsID.AutoSize = true;
            this.lblBezahlungsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBezahlungsID.ForeColor = System.Drawing.Color.Maroon;
            this.lblBezahlungsID.Location = new System.Drawing.Point(179, 126);
            this.lblBezahlungsID.Name = "lblBezahlungsID";
            this.lblBezahlungsID.Size = new System.Drawing.Size(36, 25);
            this.lblBezahlungsID.TabIndex = 2;
            this.lblBezahlungsID.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bezahlung Methode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bezahlung Datum:";
            // 
            // dtpBezahlungsDatum
            // 
            this.dtpBezahlungsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBezahlungsDatum.Location = new System.Drawing.Point(315, 242);
            this.dtpBezahlungsDatum.Name = "dtpBezahlungsDatum";
            this.dtpBezahlungsDatum.Size = new System.Drawing.Size(355, 30);
            this.dtpBezahlungsDatum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zum bezahlenden Betrag:";
            // 
            // txtBezahlungsBetrag
            // 
            this.txtBezahlungsBetrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBezahlungsBetrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBezahlungsBetrag.Location = new System.Drawing.Point(315, 307);
            this.txtBezahlungsBetrag.Name = "txtBezahlungsBetrag";
            this.txtBezahlungsBetrag.Size = new System.Drawing.Size(355, 30);
            this.txtBezahlungsBetrag.TabIndex = 10;
            this.txtBezahlungsBetrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBezahlungsBetrag_KeyPress);
            // 
            // lblAbbrechen
            // 
            this.lblAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbbrechen.Location = new System.Drawing.Point(295, 378);
            this.lblAbbrechen.Name = "lblAbbrechen";
            this.lblAbbrechen.Size = new System.Drawing.Size(165, 42);
            this.lblAbbrechen.TabIndex = 11;
            this.lblAbbrechen.Text = "Abbrechen";
            this.lblAbbrechen.UseVisualStyleBackColor = true;
            this.lblAbbrechen.Click += new System.EventHandler(this.lblAbbrechen_Click);
            // 
            // lblSpeichern
            // 
            this.lblSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeichern.Location = new System.Drawing.Point(505, 378);
            this.lblSpeichern.Name = "lblSpeichern";
            this.lblSpeichern.Size = new System.Drawing.Size(165, 42);
            this.lblSpeichern.TabIndex = 12;
            this.lblSpeichern.Text = "Speichern";
            this.lblSpeichern.UseVisualStyleBackColor = true;
            this.lblSpeichern.Click += new System.EventHandler(this.lblSpeichern_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbBezahlungsMethode
            // 
            this.cbBezahlungsMethode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBezahlungsMethode.FormattingEnabled = true;
            this.cbBezahlungsMethode.Items.AddRange(new object[] {
            "Klarna",
            "Paybal",
            "Überweisen"});
            this.cbBezahlungsMethode.Location = new System.Drawing.Point(315, 183);
            this.cbBezahlungsMethode.Name = "cbBezahlungsMethode";
            this.cbBezahlungsMethode.Size = new System.Drawing.Size(355, 33);
            this.cbBezahlungsMethode.TabIndex = 13;
            // 
            // frmAktualisierenUndNeueBezahlungHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 432);
            this.Controls.Add(this.cbBezahlungsMethode);
            this.Controls.Add(this.lblSpeichern);
            this.Controls.Add(this.lblAbbrechen);
            this.Controls.Add(this.txtBezahlungsBetrag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBezahlungsDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBezahlungsID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmAktualisierenUndNeueBezahlungHinzufügen";
            this.Text = "frmAktualisierenUndNeueBezahlungHinzufügen";
            this.Load += new System.EventHandler(this.frmAktualisierenUndNeuenTerminHinzufügen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBezahlungsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBezahlungsDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBezahlungsBetrag;
        private System.Windows.Forms.Button lblAbbrechen;
        private System.Windows.Forms.Button lblSpeichern;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbBezahlungsMethode;
    }
}