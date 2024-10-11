namespace Kliniken
{
    partial class frmFachrictungHinzufügenOderAkualisieren
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
            this.txtFachrichtung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFachrichtungID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFachrichtung
            // 
            this.txtFachrichtung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFachrichtung.Location = new System.Drawing.Point(182, 106);
            this.txtFachrichtung.Multiline = true;
            this.txtFachrichtung.Name = "txtFachrichtung";
            this.txtFachrichtung.Size = new System.Drawing.Size(419, 28);
            this.txtFachrichtung.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fachrichung Name:";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(182, 168);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(178, 36);
            this.btnAbbrechen.TabIndex = 2;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügen.Location = new System.Drawing.Point(423, 168);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(178, 36);
            this.btnHinzufügen.TabIndex = 3;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitel.Location = new System.Drawing.Point(140, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(331, 31);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Fachrichung Hinzufügen";
            this.lblTitel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fachrichung ID:";
            // 
            // lblFachrichtungID
            // 
            this.lblFachrichtungID.AutoSize = true;
            this.lblFachrichtungID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFachrichtungID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFachrichtungID.Location = new System.Drawing.Point(155, 73);
            this.lblFachrichtungID.Name = "lblFachrichtungID";
            this.lblFachrichtungID.Size = new System.Drawing.Size(29, 20);
            this.lblFachrichtungID.TabIndex = 6;
            this.lblFachrichtungID.Text = "??";
            // 
            // frmFachrictungHinzufügenOderAkualisieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 223);
            this.Controls.Add(this.lblFachrichtungID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFachrichtung);
            this.Name = "frmFachrictungHinzufügenOderAkualisieren";
            this.Text = "frmFachrictungHinzufügenOderAkualisieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFachrichtung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFachrichtungID;
    }
}