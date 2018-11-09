namespace Juros_Comopostos
{
    partial class Form1
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
            this.lblTilte = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblMontante = new System.Windows.Forms.Label();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.tbxTaxa = new System.Windows.Forms.TextBox();
            this.tbxTempo = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.Location = new System.Drawing.Point(356, 71);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(117, 17);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "Juros Compostos";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(289, 150);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(98, 17);
            this.lblCapital.TabIndex = 1;
            this.lblCapital.Text = "Capital Inicial: ";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Location = new System.Drawing.Point(268, 208);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(115, 17);
            this.lblTaxa.TabIndex = 2;
            this.lblTaxa.Text = "Taxa de Juros(i):";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(289, 261);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(56, 17);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "Tempo:";
            // 
            // lblMontante
            // 
            this.lblMontante.AutoSize = true;
            this.lblMontante.Location = new System.Drawing.Point(323, 340);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(101, 17);
            this.lblMontante.TabIndex = 4;
            this.lblMontante.Text = "Montante Final";
            this.lblMontante.Click += new System.EventHandler(this.lblMontante_Click);
            // 
            // tbxCapital
            // 
            this.tbxCapital.Location = new System.Drawing.Point(414, 150);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.Size = new System.Drawing.Size(100, 22);
            this.tbxCapital.TabIndex = 5;
            // 
            // tbxTaxa
            // 
            this.tbxTaxa.Location = new System.Drawing.Point(414, 205);
            this.tbxTaxa.Name = "tbxTaxa";
            this.tbxTaxa.Size = new System.Drawing.Size(100, 22);
            this.tbxTaxa.TabIndex = 6;
            // 
            // tbxTempo
            // 
            this.tbxTempo.Location = new System.Drawing.Point(414, 256);
            this.tbxTempo.Name = "tbxTempo";
            this.tbxTempo.Size = new System.Drawing.Size(100, 22);
            this.tbxTempo.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(356, 371);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(24, 17);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "00";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(330, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbxTempo);
            this.Controls.Add(this.tbxTaxa);
            this.Controls.Add(this.tbxCapital);
            this.Controls.Add(this.lblMontante);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblTilte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblMontante;
        private System.Windows.Forms.TextBox tbxCapital;
        private System.Windows.Forms.TextBox tbxTaxa;
        private System.Windows.Forms.TextBox tbxTempo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

