namespace AgendaConForm
{
    partial class Form2
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCognome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtIndirizzo = new System.Windows.Forms.TextBox();
            this.TxtCodiceFis = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtTariffa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtOrarioApp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNome.Location = new System.Drawing.Point(12, 35);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // TxtCognome
            // 
            this.TxtCognome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtCognome.Location = new System.Drawing.Point(118, 35);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.Size = new System.Drawing.Size(100, 20);
            this.TxtCognome.TabIndex = 3;
            this.TxtCognome.Text = "Rossi";
            this.TxtCognome.Click += new System.EventHandler(this.TxtCognome_Click);
            this.TxtCognome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCognome_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(885, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtIndirizzo
            // 
            this.TxtIndirizzo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtIndirizzo.Location = new System.Drawing.Point(224, 35);
            this.TxtIndirizzo.Name = "TxtIndirizzo";
            this.TxtIndirizzo.Size = new System.Drawing.Size(162, 20);
            this.TxtIndirizzo.TabIndex = 5;
            this.TxtIndirizzo.Text = "Via Milano, 15";
            this.TxtIndirizzo.Click += new System.EventHandler(this.TxtIndirizzo_Click);
            this.TxtIndirizzo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIndirizzo_KeyDown);
            // 
            // TxtCodiceFis
            // 
            this.TxtCodiceFis.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtCodiceFis.Location = new System.Drawing.Point(392, 35);
            this.TxtCodiceFis.Name = "TxtCodiceFis";
            this.TxtCodiceFis.Size = new System.Drawing.Size(112, 20);
            this.TxtCodiceFis.TabIndex = 6;
            this.TxtCodiceFis.Text = "PPTRFJBFY5885JJ";
            this.TxtCodiceFis.Click += new System.EventHandler(this.TxtCodiceFis_Click);
            this.TxtCodiceFis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodiceFis_KeyDown);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtTelefono.Location = new System.Drawing.Point(510, 35);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.Text = "45464434525";
            this.TxtTelefono.Click += new System.EventHandler(this.TxtTelefono_Click);
            this.TxtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefono_KeyDown);
            // 
            // TxtTariffa
            // 
            this.TxtTariffa.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtTariffa.Location = new System.Drawing.Point(616, 35);
            this.TxtTariffa.Name = "TxtTariffa";
            this.TxtTariffa.Size = new System.Drawing.Size(100, 20);
            this.TxtTariffa.TabIndex = 8;
            this.TxtTariffa.Text = "0";
            this.TxtTariffa.Click += new System.EventHandler(this.TxtTariffa_Click);
            this.TxtTariffa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTariffa_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Indirizzo Civico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codice Fiscale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tariffa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Orario Appuntamento:";
            // 
            // TxtOrarioApp
            // 
            this.TxtOrarioApp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtOrarioApp.Location = new System.Drawing.Point(723, 34);
            this.TxtOrarioApp.Name = "TxtOrarioApp";
            this.TxtOrarioApp.Size = new System.Drawing.Size(174, 20);
            this.TxtOrarioApp.TabIndex = 14;
            this.TxtOrarioApp.Text = "10/10/2000 12:30";
            this.TxtOrarioApp.Click += new System.EventHandler(this.TxtOrarioApp_Click);
            this.TxtOrarioApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOrarioApp_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 108);
            this.Controls.Add(this.TxtOrarioApp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTariffa);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCodiceFis);
            this.Controls.Add(this.TxtIndirizzo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Aggiungi Appuntamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCognome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtIndirizzo;
        private System.Windows.Forms.TextBox TxtCodiceFis;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtTariffa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtOrarioApp;
    }
}