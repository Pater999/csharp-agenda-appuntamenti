namespace AgendaConForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSalvaJson = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnApriJson = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAggiungi = new System.Windows.Forms.Button();
            this.BtnElimina = new System.Windows.Forms.Button();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.DgvAppuntamenti = new System.Windows.Forms.DataGridView();
            this.BtnVisualizzaTutto = new System.Windows.Forms.Button();
            this.BtnEliminaNome = new System.Windows.Forms.Button();
            this.TxtEliminaNome = new System.Windows.Forms.TextBox();
            this.TxtModificaNome = new System.Windows.Forms.TextBox();
            this.BtnModificaNome = new System.Windows.Forms.Button();
            this.BtnCercaNome = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtGiorno = new System.Windows.Forms.TextBox();
            this.BtnCercaGiorno = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalvaJson,
            this.toolStripSeparator2,
            this.BtnApriJson,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnSalvaJson
            // 
            this.BtnSalvaJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalvaJson.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvaJson.Image")));
            this.BtnSalvaJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalvaJson.Name = "BtnSalvaJson";
            this.BtnSalvaJson.Size = new System.Drawing.Size(23, 22);
            this.BtnSalvaJson.Text = "Salva";
            this.BtnSalvaJson.Click += new System.EventHandler(this.BtnSalvaJson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnApriJson
            // 
            this.BtnApriJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnApriJson.Image = ((System.Drawing.Image)(resources.GetObject("BtnApriJson.Image")));
            this.BtnApriJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnApriJson.Name = "BtnApriJson";
            this.BtnApriJson.Size = new System.Drawing.Size(23, 22);
            this.BtnApriJson.Text = "Apri";
            this.BtnApriJson.Click += new System.EventHandler(this.BtnApriJson_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.Location = new System.Drawing.Point(12, 59);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(99, 23);
            this.BtnAggiungi.TabIndex = 1;
            this.BtnAggiungi.Text = "Aggiungi";
            this.BtnAggiungi.UseVisualStyleBackColor = true;
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // BtnElimina
            // 
            this.BtnElimina.Location = new System.Drawing.Point(12, 88);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(99, 23);
            this.BtnElimina.TabIndex = 2;
            this.BtnElimina.Text = "Elimina";
            this.BtnElimina.UseVisualStyleBackColor = true;
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // BtnModifica
            // 
            this.BtnModifica.Location = new System.Drawing.Point(12, 117);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(99, 23);
            this.BtnModifica.TabIndex = 3;
            this.BtnModifica.Text = "Modifica";
            this.BtnModifica.UseVisualStyleBackColor = true;
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // DgvAppuntamenti
            // 
            this.DgvAppuntamenti.AllowDrop = true;
            this.DgvAppuntamenti.AllowUserToAddRows = false;
            this.DgvAppuntamenti.AllowUserToDeleteRows = false;
            this.DgvAppuntamenti.AllowUserToResizeColumns = false;
            this.DgvAppuntamenti.AllowUserToResizeRows = false;
            this.DgvAppuntamenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppuntamenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvAppuntamenti.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DgvAppuntamenti.Location = new System.Drawing.Point(119, 28);
            this.DgvAppuntamenti.MultiSelect = false;
            this.DgvAppuntamenti.Name = "DgvAppuntamenti";
            this.DgvAppuntamenti.ReadOnly = true;
            this.DgvAppuntamenti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvAppuntamenti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAppuntamenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvAppuntamenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAppuntamenti.Size = new System.Drawing.Size(807, 415);
            this.DgvAppuntamenti.TabIndex = 4;
            // 
            // BtnVisualizzaTutto
            // 
            this.BtnVisualizzaTutto.Location = new System.Drawing.Point(12, 30);
            this.BtnVisualizzaTutto.Name = "BtnVisualizzaTutto";
            this.BtnVisualizzaTutto.Size = new System.Drawing.Size(99, 23);
            this.BtnVisualizzaTutto.TabIndex = 5;
            this.BtnVisualizzaTutto.Text = "Visualizza Tutto";
            this.BtnVisualizzaTutto.UseVisualStyleBackColor = true;
            this.BtnVisualizzaTutto.Click += new System.EventHandler(this.BtnVisualizzaTutto_Click);
            // 
            // BtnEliminaNome
            // 
            this.BtnEliminaNome.Location = new System.Drawing.Point(13, 395);
            this.BtnEliminaNome.Name = "BtnEliminaNome";
            this.BtnEliminaNome.Size = new System.Drawing.Size(101, 23);
            this.BtnEliminaNome.TabIndex = 6;
            this.BtnEliminaNome.Text = "Elimina Cognome";
            this.BtnEliminaNome.UseVisualStyleBackColor = true;
            this.BtnEliminaNome.Click += new System.EventHandler(this.BtnEliminaNome_Click);
            // 
            // TxtEliminaNome
            // 
            this.TxtEliminaNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtEliminaNome.Location = new System.Drawing.Point(13, 424);
            this.TxtEliminaNome.Name = "TxtEliminaNome";
            this.TxtEliminaNome.Size = new System.Drawing.Size(100, 20);
            this.TxtEliminaNome.TabIndex = 7;
            this.TxtEliminaNome.Text = "Enter name...";
            this.TxtEliminaNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEliminaNome_KeyDown);
            // 
            // TxtModificaNome
            // 
            this.TxtModificaNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtModificaNome.Location = new System.Drawing.Point(13, 368);
            this.TxtModificaNome.Name = "TxtModificaNome";
            this.TxtModificaNome.Size = new System.Drawing.Size(99, 20);
            this.TxtModificaNome.TabIndex = 8;
            this.TxtModificaNome.Text = "Enter name...";
            this.TxtModificaNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtModificaNome_KeyDown);
            // 
            // BtnModificaNome
            // 
            this.BtnModificaNome.Location = new System.Drawing.Point(12, 339);
            this.BtnModificaNome.Name = "BtnModificaNome";
            this.BtnModificaNome.Size = new System.Drawing.Size(101, 23);
            this.BtnModificaNome.TabIndex = 9;
            this.BtnModificaNome.Text = "Modific Cognome";
            this.BtnModificaNome.UseVisualStyleBackColor = true;
            this.BtnModificaNome.Click += new System.EventHandler(this.BtnModificaNome_Click);
            // 
            // BtnCercaNome
            // 
            this.BtnCercaNome.Location = new System.Drawing.Point(12, 284);
            this.BtnCercaNome.Name = "BtnCercaNome";
            this.BtnCercaNome.Size = new System.Drawing.Size(99, 23);
            this.BtnCercaNome.TabIndex = 10;
            this.BtnCercaNome.Text = "Cerca Nome";
            this.BtnCercaNome.UseVisualStyleBackColor = true;
            this.BtnCercaNome.Click += new System.EventHandler(this.BtnCercaNome_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtNome.Location = new System.Drawing.Point(13, 313);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(98, 20);
            this.TxtNome.TabIndex = 11;
            this.TxtNome.Text = "Enter name...";
            this.TxtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            // 
            // TxtGiorno
            // 
            this.TxtGiorno.AccessibleDescription = "";
            this.TxtGiorno.AccessibleName = "";
            this.TxtGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiorno.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtGiorno.Location = new System.Drawing.Point(13, 258);
            this.TxtGiorno.Name = "TxtGiorno";
            this.TxtGiorno.Size = new System.Drawing.Size(98, 20);
            this.TxtGiorno.TabIndex = 12;
            this.TxtGiorno.Text = "GG/MM/AAAA";
            this.TxtGiorno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtGiorno_KeyDown);
            // 
            // BtnCercaGiorno
            // 
            this.BtnCercaGiorno.Location = new System.Drawing.Point(12, 229);
            this.BtnCercaGiorno.Name = "BtnCercaGiorno";
            this.BtnCercaGiorno.Size = new System.Drawing.Size(99, 23);
            this.BtnCercaGiorno.TabIndex = 13;
            this.BtnCercaGiorno.Text = "Cerca Giorno";
            this.BtnCercaGiorno.UseVisualStyleBackColor = true;
            this.BtnCercaGiorno.Click += new System.EventHandler(this.BtnCercaGiorno_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "Agenda";
            this.OpenFileDialog.Filter = "File Json|*.json|File csv|*.csv";
            this.OpenFileDialog.Title = "Apri Agenda.json";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Agenda";
            this.SaveFileDialog.Filter = "File Json|*.json|File csv|*csv";
            this.SaveFileDialog.Title = "Salva Json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 456);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtnCercaGiorno);
            this.Controls.Add(this.TxtGiorno);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnCercaNome);
            this.Controls.Add(this.BtnModificaNome);
            this.Controls.Add(this.TxtModificaNome);
            this.Controls.Add(this.TxtEliminaNome);
            this.Controls.Add(this.BtnEliminaNome);
            this.Controls.Add(this.BtnVisualizzaTutto);
            this.Controls.Add(this.DgvAppuntamenti);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.BtnElimina);
            this.Controls.Add(this.BtnAggiungi);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Agenda";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppuntamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSalvaJson;
        private System.Windows.Forms.Button BtnAggiungi;
        private System.Windows.Forms.Button BtnElimina;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.DataGridView DgvAppuntamenti;
        private System.Windows.Forms.Button BtnVisualizzaTutto;
        private System.Windows.Forms.ToolStripButton BtnApriJson;
        private System.Windows.Forms.Button BtnEliminaNome;
        private System.Windows.Forms.TextBox TxtEliminaNome;
        private System.Windows.Forms.TextBox TxtModificaNome;
        private System.Windows.Forms.Button BtnModificaNome;
        private System.Windows.Forms.Button BtnCercaNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtGiorno;
        private System.Windows.Forms.Button BtnCercaGiorno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

