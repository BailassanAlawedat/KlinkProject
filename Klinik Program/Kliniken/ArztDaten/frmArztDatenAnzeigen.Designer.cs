namespace Kliniken
{
    partial class frmArztDatenAnzeigen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArztID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFachrichtung = new System.Windows.Forms.Label();
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arzt Infos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arzt ID:";
            // 
            // lblArztID
            // 
            this.lblArztID.AutoSize = true;
            this.lblArztID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArztID.ForeColor = System.Drawing.Color.Maroon;
            this.lblArztID.Location = new System.Drawing.Point(142, 79);
            this.lblArztID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArztID.Name = "lblArztID";
            this.lblArztID.Size = new System.Drawing.Size(49, 20);
            this.lblArztID.TabIndex = 4;
            this.lblArztID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fachrichtung:";
            // 
            // lblFachrichtung
            // 
            this.lblFachrichtung.AutoSize = true;
            this.lblFachrichtung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFachrichtung.ForeColor = System.Drawing.Color.Maroon;
            this.lblFachrichtung.Location = new System.Drawing.Point(524, 79);
            this.lblFachrichtung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFachrichtung.Name = "lblFachrichtung";
            this.lblFachrichtung.Size = new System.Drawing.Size(79, 20);
            this.lblFachrichtung.TabIndex = 6;
            this.lblFachrichtung.Text = "[??????]";
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Location = new System.Drawing.Point(10, 102);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(933, 318);
            this.ctrPersonDaten1.TabIndex = 0;
            // 
            // frmArztDatenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 427);
            this.Controls.Add(this.lblFachrichtung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArztID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonDaten1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArztDatenAnzeigen";
            this.Text = "frmArztDatenAnzeigen";
            this.Load += new System.EventHandler(this.frmArztDatenAnzeigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPersonDaten ctrPersonDaten1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArztID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFachrichtung;
    }
}