namespace Kliniken
{
    partial class frmPasswortÄndern
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.txtAltesPaasswort = new System.Windows.Forms.TextBox();
            this.txtNeuesPasswort = new System.Windows.Forms.TextBox();
            this.txtPasswortBestätigung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(75, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altes Passwort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(61, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neues Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(24, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passwort bestätigen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(170, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passwort ändern";
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.BackColor = System.Drawing.Color.White;
            this.btnBestätigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestätigen.ForeColor = System.Drawing.Color.Black;
            this.btnBestätigen.Location = new System.Drawing.Point(323, 338);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(288, 40);
            this.btnBestätigen.TabIndex = 4;
            this.btnBestätigen.Text = "Änderung Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = false;
            this.btnBestätigen.Click += new System.EventHandler(this.btnBestätigen_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.White;
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.Black;
            this.btnAbbrechen.Location = new System.Drawing.Point(29, 338);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(288, 40);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // txtAltesPaasswort
            // 
            this.txtAltesPaasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltesPaasswort.Location = new System.Drawing.Point(256, 152);
            this.txtAltesPaasswort.Name = "txtAltesPaasswort";
            this.txtAltesPaasswort.PasswordChar = '*';
            this.txtAltesPaasswort.Size = new System.Drawing.Size(355, 31);
            this.txtAltesPaasswort.TabIndex = 6;
            // 
            // txtNeuesPasswort
            // 
            this.txtNeuesPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeuesPasswort.Location = new System.Drawing.Point(256, 208);
            this.txtNeuesPasswort.Name = "txtNeuesPasswort";
            this.txtNeuesPasswort.PasswordChar = '*';
            this.txtNeuesPasswort.Size = new System.Drawing.Size(355, 31);
            this.txtNeuesPasswort.TabIndex = 7;
            // 
            // txtPasswortBestätigung
            // 
            this.txtPasswortBestätigung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswortBestätigung.Location = new System.Drawing.Point(256, 264);
            this.txtPasswortBestätigung.Name = "txtPasswortBestätigung";
            this.txtPasswortBestätigung.PasswordChar = '*';
            this.txtPasswortBestätigung.Size = new System.Drawing.Size(355, 31);
            this.txtPasswortBestätigung.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(75, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Benutzername:";
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenutzername.Location = new System.Drawing.Point(256, 100);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(355, 31);
            this.txtBenutzername.TabIndex = 10;
            // 
            // frmPasswortÄndern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 395);
            this.Controls.Add(this.txtBenutzername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPasswortBestätigung);
            this.Controls.Add(this.txtNeuesPasswort);
            this.Controls.Add(this.txtAltesPaasswort);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnBestätigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPasswortÄndern";
            this.Text = "frmPasswortÄndern";
            this.Load += new System.EventHandler(this.frmPasswortÄndern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBestätigen;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox txtAltesPaasswort;
        private System.Windows.Forms.TextBox txtNeuesPasswort;
        private System.Windows.Forms.TextBox txtPasswortBestätigung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBenutzername;
    }
}