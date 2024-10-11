namespace Kliniken
{
    partial class frmBenutzerListeAnzeigen
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
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsBenutzer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.benutzerDetailsAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.benutzerDatenAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerDatenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.benutzerDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerAktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.dgvBenutzer = new System.Windows.Forms.DataGridView();
            this.cmsBenutzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(140, 680);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(43, 24);
            this.lblRecord.TabIndex = 25;
            this.lblRecord.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 680);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "#Record:";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Keine",
            "BenutzerID",
            "PersonID",
            "Rollenname",
            "Status"});
            this.cbFilterBei.Location = new System.Drawing.Point(144, 246);
            this.cbFilterBei.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(263, 33);
            this.cbFilterBei.TabIndex = 22;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter bei:";
            // 
            // cmsBenutzer
            // 
            this.cmsBenutzer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerDetailsAnzeigenToolStripMenuItem,
            this.toolStripSeparator1,
            this.benutzerDatenAktualisierenToolStripMenuItem,
            this.benutzerDatenLöschenToolStripMenuItem,
            this.toolStripSeparator2,
            this.benutzerDeaktivierenToolStripMenuItem,
            this.benutzerAktivierenToolStripMenuItem});
            this.cmsBenutzer.Name = "cmsBenutzer";
            this.cmsBenutzer.Size = new System.Drawing.Size(338, 206);
            // 
            // benutzerDetailsAnzeigenToolStripMenuItem
            // 
            this.benutzerDetailsAnzeigenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzerDetailsAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Man_32;
            this.benutzerDetailsAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerDetailsAnzeigenToolStripMenuItem.Name = "benutzerDetailsAnzeigenToolStripMenuItem";
            this.benutzerDetailsAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(337, 38);
            this.benutzerDetailsAnzeigenToolStripMenuItem.Text = "Benutzer Details anzeigen";
            this.benutzerDetailsAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.benutzerDetailsAnzeigenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(334, 6);
            // 
            // benutzerDatenAktualisierenToolStripMenuItem
            // 
            this.benutzerDatenAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzerDatenAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Edit_User_32;
            this.benutzerDatenAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerDatenAktualisierenToolStripMenuItem.Name = "benutzerDatenAktualisierenToolStripMenuItem";
            this.benutzerDatenAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(337, 38);
            this.benutzerDatenAktualisierenToolStripMenuItem.Text = "Benutzer Daten aktualisieren";
            this.benutzerDatenAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.benutzerDatenAktualisierenToolStripMenuItem_Click);
            // 
            // benutzerDatenLöschenToolStripMenuItem
            // 
            this.benutzerDatenLöschenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzerDatenLöschenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_User_32;
            this.benutzerDatenLöschenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerDatenLöschenToolStripMenuItem.Name = "benutzerDatenLöschenToolStripMenuItem";
            this.benutzerDatenLöschenToolStripMenuItem.Size = new System.Drawing.Size(337, 38);
            this.benutzerDatenLöschenToolStripMenuItem.Text = "Benutzer Daten löschen";
            this.benutzerDatenLöschenToolStripMenuItem.Click += new System.EventHandler(this.benutzerDatenLöschenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(334, 6);
            // 
            // benutzerDeaktivierenToolStripMenuItem
            // 
            this.benutzerDeaktivierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzerDeaktivierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.sign_out_32__2;
            this.benutzerDeaktivierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerDeaktivierenToolStripMenuItem.Name = "benutzerDeaktivierenToolStripMenuItem";
            this.benutzerDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(337, 38);
            this.benutzerDeaktivierenToolStripMenuItem.Text = "Benutzer deaktivieren";
            this.benutzerDeaktivierenToolStripMenuItem.Click += new System.EventHandler(this.benutzerDeaktivierenToolStripMenuItem_Click);
            // 
            // benutzerAktivierenToolStripMenuItem
            // 
            this.benutzerAktivierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzerAktivierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.sign_in_32;
            this.benutzerAktivierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerAktivierenToolStripMenuItem.Name = "benutzerAktivierenToolStripMenuItem";
            this.benutzerAktivierenToolStripMenuItem.Size = new System.Drawing.Size(337, 38);
            this.benutzerAktivierenToolStripMenuItem.Text = "Benutzer aktivieren";
            this.benutzerAktivierenToolStripMenuItem.Click += new System.EventHandler(this.benutzerAktivierenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Benutzer Liste";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Alle ",
            "Aktive",
            "Nicht Aktive"});
            this.cbStatus.Location = new System.Drawing.Point(415, 246);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(162, 33);
            this.cbStatus.TabIndex = 26;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(415, 246);
            this.txtFilterWert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(306, 35);
            this.txtFilterWert.TabIndex = 27;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(554, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(972, 235);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(362, 46);
            this.btnAddNewUser.TabIndex = 28;
            this.btnAddNewUser.Text = "Neuen Benutzer hinzufügen";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // dgvBenutzer
            // 
            this.dgvBenutzer.AllowUserToAddRows = false;
            this.dgvBenutzer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBenutzer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenutzer.BackgroundColor = System.Drawing.Color.White;
            this.dgvBenutzer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenutzer.ContextMenuStrip = this.cmsBenutzer;
            this.dgvBenutzer.Location = new System.Drawing.Point(44, 287);
            this.dgvBenutzer.MultiSelect = false;
            this.dgvBenutzer.Name = "dgvBenutzer";
            this.dgvBenutzer.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBenutzer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenutzer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenutzer.Size = new System.Drawing.Size(1297, 390);
            this.dgvBenutzer.TabIndex = 29;
            // 
            // frmBenutzerListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1372, 708);
            this.Controls.Add(this.dgvBenutzer);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBenutzerListeAnzeigen";
            this.Text = "frmBenutzerListeAnzeigen";
            this.Load += new System.EventHandler(this.frmBenutzerListeAnzeigen_Load);
            this.cmsBenutzer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.ContextMenuStrip cmsBenutzer;
        private System.Windows.Forms.ToolStripMenuItem benutzerDetailsAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerDatenAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerDatenLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.DataGridView dgvBenutzer;
    }
}