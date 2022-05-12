namespace AppLista3
{
    partial class FrmExercicio1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblVlrCompra = new System.Windows.Forms.Label();
            this.lblVlrEntrada = new System.Windows.Forms.Label();
            this.lblNumParcelas = new System.Windows.Forms.Label();
            this.txtNparcelas = new System.Windows.Forms.TextBox();
            this.txtVlrEntrada = new System.Windows.Forms.TextBox();
            this.txtVlrCompra = new System.Windows.Forms.TextBox();
            this.pnlTopo.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(62)))), ((int)(((byte)(3)))));
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(849, 80);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(571, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA DE PARCELAS";
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
            this.pnlBase.Controls.Add(this.lblResultado);
            this.pnlBase.Location = new System.Drawing.Point(0, 312);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(542, 74);
            this.pnlBase.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(6, 23);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(176, 29);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado Aqui";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnCalcular);
            this.pnlBotoes.Location = new System.Drawing.Point(498, 312);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(351, 71);
            this.pnlBotoes.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnLimpar.Location = new System.Drawing.Point(182, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 44);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnCalcular.Location = new System.Drawing.Point(18, 15);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(148, 44);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblVlrCompra
            // 
            this.lblVlrCompra.AutoSize = true;
            this.lblVlrCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblVlrCompra.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVlrCompra.Location = new System.Drawing.Point(130, 141);
            this.lblVlrCompra.Name = "lblVlrCompra";
            this.lblVlrCompra.Size = new System.Drawing.Size(189, 29);
            this.lblVlrCompra.TabIndex = 1;
            this.lblVlrCompra.Text = "Valor da compra";
            // 
            // lblVlrEntrada
            // 
            this.lblVlrEntrada.AutoSize = true;
            this.lblVlrEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblVlrEntrada.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVlrEntrada.Location = new System.Drawing.Point(130, 186);
            this.lblVlrEntrada.Name = "lblVlrEntrada";
            this.lblVlrEntrada.Size = new System.Drawing.Size(189, 29);
            this.lblVlrEntrada.TabIndex = 3;
            this.lblVlrEntrada.Text = "Valor da entrada";
            // 
            // lblNumParcelas
            // 
            this.lblNumParcelas.AutoSize = true;
            this.lblNumParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblNumParcelas.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNumParcelas.Location = new System.Drawing.Point(87, 226);
            this.lblNumParcelas.Name = "lblNumParcelas";
            this.lblNumParcelas.Size = new System.Drawing.Size(232, 29);
            this.lblNumParcelas.TabIndex = 4;
            this.lblNumParcelas.Text = "Número de parcelas";
            // 
            // txtNparcelas
            // 
            this.txtNparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtNparcelas.Location = new System.Drawing.Point(325, 226);
            this.txtNparcelas.Name = "txtNparcelas";
            this.txtNparcelas.Size = new System.Drawing.Size(217, 34);
            this.txtNparcelas.TabIndex = 5;
            // 
            // txtVlrEntrada
            // 
            this.txtVlrEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtVlrEntrada.Location = new System.Drawing.Point(325, 181);
            this.txtVlrEntrada.Name = "txtVlrEntrada";
            this.txtVlrEntrada.Size = new System.Drawing.Size(217, 34);
            this.txtVlrEntrada.TabIndex = 6;
            // 
            // txtVlrCompra
            // 
            this.txtVlrCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtVlrCompra.Location = new System.Drawing.Point(325, 136);
            this.txtVlrCompra.Name = "txtVlrCompra";
            this.txtVlrCompra.Size = new System.Drawing.Size(217, 34);
            this.txtVlrCompra.TabIndex = 7;
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 383);
            this.Controls.Add(this.txtVlrCompra);
            this.Controls.Add(this.txtVlrEntrada);
            this.Controls.Add(this.txtNparcelas);
            this.Controls.Add(this.lblNumParcelas);
            this.Controls.Add(this.lblVlrEntrada);
            this.Controls.Add(this.lblVlrCompra);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FrmExercicio1";
            this.Text = "Exercicio1";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVlrCompra;
        private System.Windows.Forms.Label lblVlrEntrada;
        private System.Windows.Forms.Label lblNumParcelas;
        private System.Windows.Forms.TextBox txtNparcelas;
        private System.Windows.Forms.TextBox txtVlrEntrada;
        private System.Windows.Forms.TextBox txtVlrCompra;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

