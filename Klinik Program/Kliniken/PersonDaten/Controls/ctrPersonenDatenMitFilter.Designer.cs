namespace Kliniken
{
    partial class ctrPersonenDatenMitFilter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonenFilter = new System.Windows.Forms.GroupBox();
            this.btnPersonSuchen = new System.Windows.Forms.Button();
            this.btnNeuePersonHinzufügen = new System.Windows.Forms.Button();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ctrPersonDaten1 = new Kliniken.ctrPersonDaten();
            this.gbPersonenFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Bei:";
            // 
            // gbPersonenFilter
            // 
            this.gbPersonenFilter.Controls.Add(this.btnPersonSuchen);
            this.gbPersonenFilter.Controls.Add(this.btnNeuePersonHinzufügen);
            this.gbPersonenFilter.Controls.Add(this.cbFilterBei);
            this.gbPersonenFilter.Controls.Add(this.txtbFilterWert);
            this.gbPersonenFilter.Controls.Add(this.label1);
            this.gbPersonenFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonenFilter.Location = new System.Drawing.Point(3, 3);
            this.gbPersonenFilter.Name = "gbPersonenFilter";
            this.gbPersonenFilter.Size = new System.Drawing.Size(907, 105);
            this.gbPersonenFilter.TabIndex = 1;
            this.gbPersonenFilter.TabStop = false;
            this.gbPersonenFilter.Text = "Bitte geben Sie die Person , die zu Benutzer wird, ein.";
            // 
            // btnPersonSuchen
            // 
            this.btnPersonSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonSuchen.Image = global::Kliniken.Properties.Resources.SearchPerson;
            this.btnPersonSuchen.Location = new System.Drawing.Point(727, 36);
            this.btnPersonSuchen.Name = "btnPersonSuchen";
            this.btnPersonSuchen.Size = new System.Drawing.Size(84, 44);
            this.btnPersonSuchen.TabIndex = 4;
            this.btnPersonSuchen.UseVisualStyleBackColor = true;
            this.btnPersonSuchen.Click += new System.EventHandler(this.btnPersonSuchen_Click);
            // 
            // btnNeuePersonHinzufügen
            // 
            this.btnNeuePersonHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuePersonHinzufügen.Image = global::Kliniken.Properties.Resources.Add_Person_40;
            this.btnNeuePersonHinzufügen.Location = new System.Drawing.Point(817, 36);
            this.btnNeuePersonHinzufügen.Name = "btnNeuePersonHinzufügen";
            this.btnNeuePersonHinzufügen.Size = new System.Drawing.Size(84, 44);
            this.btnNeuePersonHinzufügen.TabIndex = 3;
            this.btnNeuePersonHinzufügen.UseVisualStyleBackColor = true;
            this.btnNeuePersonHinzufügen.Click += new System.EventHandler(this.btnNeuePersonHinzufügen_Click);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "PersonID",
            "AusweisID",
            "Email"});
            this.cbFilterBei.Location = new System.Drawing.Point(98, 46);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBei.TabIndex = 2;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(300, 45);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(421, 29);
            this.txtbFilterWert.TabIndex = 1;
            this.txtbFilterWert.TextChanged += new System.EventHandler(this.txtbFilterWert_TextChanged);
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ctrPersonDaten1
            // 
            this.ctrPersonDaten1.Location = new System.Drawing.Point(-2, 114);
            this.ctrPersonDaten1.Name = "ctrPersonDaten1";
            this.ctrPersonDaten1.Size = new System.Drawing.Size(933, 318);
            this.ctrPersonDaten1.TabIndex = 3;
            // 
            // ctrPersonenFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrPersonDaten1);
            this.Controls.Add(this.gbPersonenFilter);
            this.Name = "ctrPersonenFilter";
            this.Size = new System.Drawing.Size(934, 451);
            this.Load += new System.EventHandler(this.ctrPersonenFilter_Load);
            this.gbPersonenFilter.ResumeLayout(false);
            this.gbPersonenFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonenFilter;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPersonSuchen;
        private System.Windows.Forms.Button btnNeuePersonHinzufügen;
        private ctrPersonDaten ctrPersonDaten1;
    }
}
