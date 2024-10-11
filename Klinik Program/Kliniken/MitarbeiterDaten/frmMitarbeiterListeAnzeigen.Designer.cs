namespace Kliniken
{
    partial class frmMitarbeiterListeAnzeigen
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
            this.dgvMitarbeiter = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReinigungsPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küchenPersonInfosAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecod = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cbSelecetBy = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mitarbeiterdatenAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterdatenEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMitarbeiter
            // 
            this.dgvMitarbeiter.AllowUserToAddRows = false;
            this.dgvMitarbeiter.AllowUserToDeleteRows = false;
            this.dgvMitarbeiter.BackgroundColor = System.Drawing.Color.White;
            this.dgvMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMitarbeiter.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMitarbeiter.EnableHeadersVisualStyles = false;
            this.dgvMitarbeiter.Location = new System.Drawing.Point(35, 277);
            this.dgvMitarbeiter.MultiSelect = false;
            this.dgvMitarbeiter.Name = "dgvMitarbeiter";
            this.dgvMitarbeiter.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMitarbeiter.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMitarbeiter.Size = new System.Drawing.Size(1332, 447);
            this.dgvMitarbeiter.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem,
            this.ReinigungsPersonInfoToolStripMenuItem,
            this.küchenPersonInfosAnzeigenToolStripMenuItem,
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem,
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem,
            this.toolStripSeparator1,
            this.mitarbeiterdatenAktualisierenToolStripMenuItem,
            this.mitarbeiterdatenEntfernenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(471, 298);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem
            // 
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Name = "mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem";
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Text = "Mitarbeiter Infos bei MitarbeiterID anzeigen";
            this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem_Click);
            // 
            // ReinigungsPersonInfoToolStripMenuItem
            // 
            this.ReinigungsPersonInfoToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.ReinigungsPersonInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReinigungsPersonInfoToolStripMenuItem.Name = "ReinigungsPersonInfoToolStripMenuItem";
            this.ReinigungsPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.ReinigungsPersonInfoToolStripMenuItem.Text = "ReinigungsPerson Infos anzeigen";
            this.ReinigungsPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.ReinigungsPersonInfoToolStripMenuItem_Click);
            // 
            // küchenPersonInfosAnzeigenToolStripMenuItem
            // 
            this.küchenPersonInfosAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.küchenPersonInfosAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.küchenPersonInfosAnzeigenToolStripMenuItem.Name = "küchenPersonInfosAnzeigenToolStripMenuItem";
            this.küchenPersonInfosAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.küchenPersonInfosAnzeigenToolStripMenuItem.Text = "KüchenPerson Infos anzeigen";
            this.küchenPersonInfosAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.küchenPersonInfosAnzeigenToolStripMenuItem_Click);
            // 
            // transportdienstPersonInfosAnzeigenToolStripMenuItem
            // 
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.Name = "transportdienstPersonInfosAnzeigenToolStripMenuItem";
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.Text = "TransportdienstPerson Infos anzeigen";
            this.transportdienstPersonInfosAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.transportdienstPersonInfosAnzeigenToolStripMenuItem_Click);
            // 
            // sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem
            // 
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Name = "sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem";
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Text = "SicherheitsdienstPerson Infos anzeigen";
            this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter bei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // lblRecod
            // 
            this.lblRecod.AutoSize = true;
            this.lblRecod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecod.Location = new System.Drawing.Point(122, 739);
            this.lblRecod.Name = "lblRecod";
            this.lblRecod.Size = new System.Drawing.Size(43, 24);
            this.lblRecod.TabIndex = 4;
            this.lblRecod.Text = "###";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Allgemeine Mitarbeiter",
            "ReinigungsPersonal",
            "KüchenPersonal",
            "Transportdienst",
            "Sicherheitsdienst"});
            this.cbFilterBei.Location = new System.Drawing.Point(135, 242);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(305, 32);
            this.cbFilterBei.TabIndex = 5;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(700, 243);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(402, 31);
            this.txtFilterWert.TabIndex = 6;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitel.Location = new System.Drawing.Point(539, 199);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(375, 31);
            this.lblTitel.TabIndex = 8;
            this.lblTitel.Text = "Allgemeine Mitarbeiter Liste";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbSelecetBy
            // 
            this.cbSelecetBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecetBy.FormattingEnabled = true;
            this.cbSelecetBy.Items.AddRange(new object[] {
            "Keine",
            "MitarbeiterID",
            "PersonID",
            "EingestelltBeiUser",
            "SteuerID"});
            this.cbSelecetBy.Location = new System.Drawing.Point(446, 242);
            this.cbSelecetBy.Name = "cbSelecetBy";
            this.cbSelecetBy.Size = new System.Drawing.Size(248, 32);
            this.cbSelecetBy.TabIndex = 9;
            this.cbSelecetBy.SelectedIndexChanged += new System.EventHandler(this.cbSelecetBy_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kliniken.Properties.Resources.mitarbeiter__2_;
            this.pictureBox1.Location = new System.Drawing.Point(469, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mitarbeiterdatenAktualisierenToolStripMenuItem
            // 
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.ApplicationTitle;
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.Name = "mitarbeiterdatenAktualisierenToolStripMenuItem";
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.Text = "Mitarbeiterdaten aktualisieren";
            this.mitarbeiterdatenAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterdatenAktualisierenToolStripMenuItem_Click);
            // 
            // mitarbeiterdatenEntfernenToolStripMenuItem
            // 
            this.mitarbeiterdatenEntfernenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32_2;
            this.mitarbeiterdatenEntfernenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterdatenEntfernenToolStripMenuItem.Name = "mitarbeiterdatenEntfernenToolStripMenuItem";
            this.mitarbeiterdatenEntfernenToolStripMenuItem.Size = new System.Drawing.Size(470, 38);
            this.mitarbeiterdatenEntfernenToolStripMenuItem.Text = "Mitarbeiterdaten entfernen";
            this.mitarbeiterdatenEntfernenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterdatenEntfernenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(467, 6);
            // 
            // frmMitarbeiterListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 774);
            this.Controls.Add(this.cbSelecetBy);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.lblRecod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMitarbeiter);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMitarbeiterListeAnzeigen";
            this.Text = "frmMitarbeiterListeAnzeigen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMitarbeiterListeAnzeigen_FormClosing);
            this.Load += new System.EventHandler(this.frmMitarbeiterListeAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMitarbeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecod;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cbSelecetBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReinigungsPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küchenPersonInfosAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportdienstPersonInfosAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterdatenAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterdatenEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}