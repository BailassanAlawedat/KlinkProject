namespace Kliniken
{
    partial class frmBenutzerDatenAnzeigen
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
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRollenname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIstAktive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLetzterLogin = new System.Windows.Forms.Label();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Location = new System.Drawing.Point(15, 79);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(933, 318);
            this.ctrPersonDaten1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzer Infos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rollenname:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblLetzterLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblIstAktive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblRollenname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benutzer Daten";
            // 
            // lblRollenname
            // 
            this.lblRollenname.AutoSize = true;
            this.lblRollenname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollenname.ForeColor = System.Drawing.Color.Maroon;
            this.lblRollenname.Location = new System.Drawing.Point(132, 43);
            this.lblRollenname.Name = "lblRollenname";
            this.lblRollenname.Size = new System.Drawing.Size(89, 20);
            this.lblRollenname.TabIndex = 3;
            this.lblRollenname.Text = "[???????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IstAktive: ";
            // 
            // lblIstAktive
            // 
            this.lblIstAktive.AutoSize = true;
            this.lblIstAktive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstAktive.ForeColor = System.Drawing.Color.Maroon;
            this.lblIstAktive.Location = new System.Drawing.Point(408, 43);
            this.lblIstAktive.Name = "lblIstAktive";
            this.lblIstAktive.Size = new System.Drawing.Size(49, 20);
            this.lblIstAktive.TabIndex = 5;
            this.lblIstAktive.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Letzter Login:";
            // 
            // lblLetzterLogin
            // 
            this.lblLetzterLogin.AutoSize = true;
            this.lblLetzterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetzterLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblLetzterLogin.Location = new System.Drawing.Point(684, 43);
            this.lblLetzterLogin.Name = "lblLetzterLogin";
            this.lblLetzterLogin.Size = new System.Drawing.Size(109, 20);
            this.lblLetzterLogin.TabIndex = 7;
            this.lblLetzterLogin.Text = "[??/??/????]";
            // 
            // btnSchließen
            // 
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.Location = new System.Drawing.Point(25, 509);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(236, 50);
            this.btnSchließen.TabIndex = 4;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // frmBenutzerDatenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonDaten1);
            this.Name = "frmBenutzerDatenAnzeigen";
            this.Text = "frmBenutzerDatenAnzeigen";
            this.Load += new System.EventHandler(this.frmBenutzerDatenAnzeigen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPersonDaten ctrPersonDaten1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLetzterLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIstAktive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRollenname;
        private System.Windows.Forms.Button btnSchließen;
    }
}