namespace artApp
{
    partial class CadastrarPedido
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
            this.textidcliente = new System.Windows.Forms.TextBox();
            this.textidproduto = new System.Windows.Forms.TextBox();
            this.textnomecliente = new System.Windows.Forms.TextBox();
            this.textnomeproduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textvalorpedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textidcliente
            // 
            this.textidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textidcliente.Location = new System.Drawing.Point(22, 44);
            this.textidcliente.Name = "textidcliente";
            this.textidcliente.Size = new System.Drawing.Size(101, 26);
            this.textidcliente.TabIndex = 0;
            this.textidcliente.TextChanged += new System.EventHandler(this.textidcliente_TextChanged);
            // 
            // textidproduto
            // 
            this.textidproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textidproduto.Location = new System.Drawing.Point(22, 121);
            this.textidproduto.Name = "textidproduto";
            this.textidproduto.Size = new System.Drawing.Size(115, 26);
            this.textidproduto.TabIndex = 1;
            this.textidproduto.Text = " ";
            this.textidproduto.TextChanged += new System.EventHandler(this.textidpedido_TextChanged);
            // 
            // textnomecliente
            // 
            this.textnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textnomecliente.Location = new System.Drawing.Point(174, 44);
            this.textnomecliente.Name = "textnomecliente";
            this.textnomecliente.Size = new System.Drawing.Size(231, 26);
            this.textnomecliente.TabIndex = 2;
            this.textnomecliente.TextChanged += new System.EventHandler(this.textnomecliente_TextChanged);
            // 
            // textnomeproduto
            // 
            this.textnomeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textnomeproduto.Location = new System.Drawing.Point(174, 121);
            this.textnomeproduto.Name = "textnomeproduto";
            this.textnomeproduto.Size = new System.Drawing.Size(231, 26);
            this.textnomeproduto.TabIndex = 3;
            this.textnomeproduto.TextChanged += new System.EventHandler(this.textnomeproduto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome do Produto";
            // 
            // textvalorpedido
            // 
            this.textvalorpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textvalorpedido.Location = new System.Drawing.Point(424, 121);
            this.textvalorpedido.Name = "textvalorpedido";
            this.textvalorpedido.Size = new System.Drawing.Size(108, 26);
            this.textvalorpedido.TabIndex = 4;
            this.textvalorpedido.Text = " ";
            this.textvalorpedido.TextChanged += new System.EventHandler(this.textvalorpedido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Validar pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(151, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cadastrar Pedido";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(555, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvalorpedido);
            this.Controls.Add(this.textnomeproduto);
            this.Controls.Add(this.textnomecliente);
            this.Controls.Add(this.textidproduto);
            this.Controls.Add(this.textidcliente);
            this.Name = "CadastrarPedido";
            this.Text = "CadastrarPedido";
            this.Load += new System.EventHandler(this.CadastrarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textidcliente;
        private System.Windows.Forms.TextBox textidproduto;
        private System.Windows.Forms.TextBox textnomecliente;
        private System.Windows.Forms.TextBox textnomeproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textvalorpedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}