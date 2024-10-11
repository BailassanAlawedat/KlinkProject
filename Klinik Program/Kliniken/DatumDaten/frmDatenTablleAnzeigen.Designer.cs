namespace Kliniken
{
    partial class frmDatenTablleAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatenTabelle = new System.Windows.Forms.DataGridView();
            this.btnÜbernehmen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientenName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatenTabelle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatenTabelle
            // 
            this.dgvDatenTabelle.AllowUserToAddRows = false;
            this.dgvDatenTabelle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatenTabelle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatenTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatenTabelle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatenTabelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDatenTabelle.Location = new System.Drawing.Point(0, 0);
            this.dgvDatenTabelle.MultiSelect = false;
            this.dgvDatenTabelle.Name = "dgvDatenTabelle";
            this.dgvDatenTabelle.ReadOnly = true;
            this.dgvDatenTabelle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatenTabelle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatenTabelle.Size = new System.Drawing.Size(1056, 596);
            this.dgvDatenTabelle.TabIndex = 0;
            this.dgvDatenTabelle.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatenTabelle_CellMouseClick);
            // 
            // btnÜbernehmen
            // 
            this.btnÜbernehmen.BackColor = System.Drawing.Color.Blue;
            this.btnÜbernehmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÜbernehmen.ForeColor = System.Drawing.Color.White;
            this.btnÜbernehmen.Location = new System.Drawing.Point(250, 604);
            this.btnÜbernehmen.Name = "btnÜbernehmen";
            this.btnÜbernehmen.Size = new System.Drawing.Size(231, 53);
            this.btnÜbernehmen.TabIndex = 1;
            this.btnÜbernehmen.Text = "übernehmen";
            this.btnÜbernehmen.UseVisualStyleBackColor = false;
            this.btnÜbernehmen.Click += new System.EventHandler(this.btnÜbernehmen_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.Blue;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btnAbbrechen.Location = new System.Drawing.Point(487, 604);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(231, 53);
            this.btnAbbrechen.TabIndex = 2;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patienten Name:";
            // 
            // lblPatientenName
            // 
            this.lblPatientenName.AutoSize = true;
            this.lblPatientenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPatientenName.Location = new System.Drawing.Point(967, 619);
            this.lblPatientenName.Name = "lblPatientenName";
            this.lblPatientenName.Size = new System.Drawing.Size(77, 24);
            this.lblPatientenName.TabIndex = 4;
            this.lblPatientenName.Text = "[?????]";
            // 
            // frmDatenTablleAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 669);
            this.Controls.Add(this.lblPatientenName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnÜbernehmen);
            this.Controls.Add(this.dgvDatenTabelle);
            this.Name = "frmDatenTablleAnzeigen";
            this.Text = "frmDatenTablleAnzeigen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatenTablleAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatenTabelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatenTabelle;
        private System.Windows.Forms.Button btnÜbernehmen;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientenName;
    }
}