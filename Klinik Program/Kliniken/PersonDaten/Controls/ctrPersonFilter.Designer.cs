namespace Kliniken
{
    partial class ctrPersonFilter
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonSuchen = new System.Windows.Forms.Button();
            this.btnNeuePersonHinzufügen = new System.Windows.Forms.Button();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonFilter = new System.Windows.Forms.GroupBox();
            this.gbPersonFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonSuchen
            // 
            this.btnPersonSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonSuchen.Image = global::Kliniken.Properties.Resources.SearchPerson;
            this.btnPersonSuchen.Location = new System.Drawing.Point(739, 20);
            this.btnPersonSuchen.Name = "btnPersonSuchen";
            this.btnPersonSuchen.Size = new System.Drawing.Size(84, 44);
            this.btnPersonSuchen.TabIndex = 9;
            this.btnPersonSuchen.UseVisualStyleBackColor = true;
            this.btnPersonSuchen.Click += new System.EventHandler(this.btnPersonSuchen_Click);
            // 
            // btnNeuePersonHinzufügen
            // 
            this.btnNeuePersonHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuePersonHinzufügen.Image = global::Kliniken.Properties.Resources.Add_Person_40;
            this.btnNeuePersonHinzufügen.Location = new System.Drawing.Point(829, 20);
            this.btnNeuePersonHinzufügen.Name = "btnNeuePersonHinzufügen";
            this.btnNeuePersonHinzufügen.Size = new System.Drawing.Size(84, 44);
            this.btnNeuePersonHinzufügen.TabIndex = 8;
            this.btnNeuePersonHinzufügen.UseVisualStyleBackColor = true;
            this.btnNeuePersonHinzufügen.Click += new System.EventHandler(this.btnNeuePersonHinzufügen_Click);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "PersonID",
            "AusweisID",
            "Email"});
            this.cbFilterBei.Location = new System.Drawing.Point(110, 30);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(196, 32);
            this.cbFilterBei.TabIndex = 7;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(312, 29);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(421, 31);
            this.txtbFilterWert.TabIndex = 6;
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter Bei:";
            // 
            // gbPersonFilter
            // 
            this.gbPersonFilter.Controls.Add(this.label1);
            this.gbPersonFilter.Controls.Add(this.btnPersonSuchen);
            this.gbPersonFilter.Controls.Add(this.txtbFilterWert);
            this.gbPersonFilter.Controls.Add(this.btnNeuePersonHinzufügen);
            this.gbPersonFilter.Controls.Add(this.cbFilterBei);
            this.gbPersonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonFilter.Location = new System.Drawing.Point(15, 12);
            this.gbPersonFilter.Name = "gbPersonFilter";
            this.gbPersonFilter.Size = new System.Drawing.Size(935, 78);
            this.gbPersonFilter.TabIndex = 10;
            this.gbPersonFilter.TabStop = false;
            this.gbPersonFilter.Text = "Person Filter";
            // 
            // ctrPersonFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonFilter);
            this.Name = "ctrPersonFilter";
            this.Size = new System.Drawing.Size(955, 98);
            this.Load += new System.EventHandler(this.ctrPersonFilter_Load);
            this.gbPersonFilter.ResumeLayout(false);
            this.gbPersonFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonSuchen;
        private System.Windows.Forms.Button btnNeuePersonHinzufügen;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonFilter;
    }
}
