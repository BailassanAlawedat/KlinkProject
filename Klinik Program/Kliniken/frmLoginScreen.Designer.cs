namespace Kliniken
{
    partial class frmLoginScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbBenutzername = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.cbDatenSpeichern = new System.Windows.Forms.CheckBox();
            this.btnAnmelden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.medical_team;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 621);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passwort: ";
            // 
            // txtbBenutzername
            // 
            this.txtbBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBenutzername.Location = new System.Drawing.Point(711, 286);
            this.txtbBenutzername.Name = "txtbBenutzername";
            this.txtbBenutzername.Size = new System.Drawing.Size(265, 35);
            this.txtbBenutzername.TabIndex = 3;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.Location = new System.Drawing.Point(711, 358);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(265, 35);
            this.txtbPassword.TabIndex = 4;
            // 
            // cbDatenSpeichern
            // 
            this.cbDatenSpeichern.AutoSize = true;
            this.cbDatenSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatenSpeichern.Location = new System.Drawing.Point(711, 427);
            this.cbDatenSpeichern.Name = "cbDatenSpeichern";
            this.cbDatenSpeichern.Size = new System.Drawing.Size(167, 28);
            this.cbDatenSpeichern.TabIndex = 5;
            this.cbDatenSpeichern.Text = "Daten speichern";
            this.cbDatenSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAnmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnmelden.ForeColor = System.Drawing.Color.White;
            this.btnAnmelden.Location = new System.Drawing.Point(711, 508);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(265, 42);
            this.btnAnmelden.TabIndex = 6;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = false;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(988, 621);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.cbDatenSpeichern);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbBenutzername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginScreen";
            this.Text = "frmLoginScreen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbBenutzername;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.CheckBox cbDatenSpeichern;
        private System.Windows.Forms.Button btnAnmelden;
    }
}