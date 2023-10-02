namespace artApp.clientes
{
    partial class EditarCliente
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
            this.textnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textnumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textnome.Location = new System.Drawing.Point(65, 48);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(241, 26);
            this.textnome.TabIndex = 11;
            this.textnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(65, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Novo nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textendereco
            // 
            this.textendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textendereco.Location = new System.Drawing.Point(65, 108);
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(241, 26);
            this.textendereco.TabIndex = 14;
            this.textendereco.TextChanged += new System.EventHandler(this.textendereco_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(60, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Novo endereco";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textemail
            // 
            this.textemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textemail.Location = new System.Drawing.Point(65, 173);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(241, 26);
            this.textemail.TabIndex = 16;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(60, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Novo email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textnumero
            // 
            this.textnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textnumero.Location = new System.Drawing.Point(65, 243);
            this.textnumero.Name = "textnumero";
            this.textnumero.Size = new System.Drawing.Size(241, 26);
            this.textnumero.TabIndex = 18;
            this.textnumero.TextChanged += new System.EventHandler(this.textnumero_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(60, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Novo numero";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(370, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textendereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textnome);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnumero;
        private System.Windows.Forms.Label label5;
    }
}