namespace CalcularFacil
{
    partial class FrmHome
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
            this.lbValorA = new System.Windows.Forms.Label();
            this.lbOperador = new System.Windows.Forms.Label();
            this.lbValorB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultDigitado = new System.Windows.Forms.TextBox();
            this.lbErros = new System.Windows.Forms.Label();
            this.lbAcertos = new System.Windows.Forms.Label();
            this.lbQtdErros = new System.Windows.Forms.Label();
            this.lbQtdAcertos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbValorA
            // 
            this.lbValorA.AutoSize = true;
            this.lbValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorA.Location = new System.Drawing.Point(82, 72);
            this.lbValorA.Name = "lbValorA";
            this.lbValorA.Size = new System.Drawing.Size(70, 76);
            this.lbValorA.TabIndex = 0;
            this.lbValorA.Text = "1";
            this.lbValorA.Click += new System.EventHandler(this.lbValorA_Click);
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(184, 72);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(72, 76);
            this.lbOperador.TabIndex = 1;
            this.lbOperador.Text = "+";
            this.lbOperador.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbValorB
            // 
            this.lbValorB.AutoSize = true;
            this.lbValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorB.Location = new System.Drawing.Point(258, 72);
            this.lbValorB.Name = "lbValorB";
            this.lbValorB.Size = new System.Drawing.Size(70, 76);
            this.lbValorB.TabIndex = 2;
            this.lbValorB.Text = "1";
            this.lbValorB.Click += new System.EventHandler(this.lbValorB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 76);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtResultDigitado
            // 
            this.txtResultDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDigitado.Location = new System.Drawing.Point(406, 69);
            this.txtResultDigitado.MaxLength = 3;
            this.txtResultDigitado.Name = "txtResultDigitado";
            this.txtResultDigitado.Size = new System.Drawing.Size(126, 83);
            this.txtResultDigitado.TabIndex = 4;
            this.txtResultDigitado.TextChanged += new System.EventHandler(this.txtResultDigitado_TextChanged);
            this.txtResultDigitado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResultDigitado_KeyDown);
            this.txtResultDigitado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultDigitado_KeyPress);
            this.txtResultDigitado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtResultDigitado_KeyUp);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.ForeColor = System.Drawing.Color.Red;
            this.lbErros.Location = new System.Drawing.Point(153, 223);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(87, 31);
            this.lbErros.TabIndex = 12;
            this.lbErros.Text = "Erros:";
            // 
            // lbAcertos
            // 
            this.lbAcertos.AutoSize = true;
            this.lbAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbAcertos.Location = new System.Drawing.Point(295, 223);
            this.lbAcertos.Name = "lbAcertos";
            this.lbAcertos.Size = new System.Drawing.Size(115, 31);
            this.lbAcertos.TabIndex = 13;
            this.lbAcertos.Text = "Acertos:";
            // 
            // lbQtdErros
            // 
            this.lbQtdErros.AutoSize = true;
            this.lbQtdErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdErros.ForeColor = System.Drawing.Color.Red;
            this.lbQtdErros.Location = new System.Drawing.Point(230, 223);
            this.lbQtdErros.Name = "lbQtdErros";
            this.lbQtdErros.Size = new System.Drawing.Size(38, 31);
            this.lbQtdErros.TabIndex = 14;
            this.lbQtdErros.Text = "...";
            // 
            // lbQtdAcertos
            // 
            this.lbQtdAcertos.AutoSize = true;
            this.lbQtdAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdAcertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbQtdAcertos.Location = new System.Drawing.Point(400, 223);
            this.lbQtdAcertos.Name = "lbQtdAcertos";
            this.lbQtdAcertos.Size = new System.Drawing.Size(38, 31);
            this.lbQtdAcertos.TabIndex = 15;
            this.lbQtdAcertos.Text = "...";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(595, 263);
            this.Controls.Add(this.lbQtdAcertos);
            this.Controls.Add(this.lbQtdErros);
            this.Controls.Add(this.lbAcertos);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.txtResultDigitado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbValorB);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.lbValorA);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste v1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValorA;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label lbValorB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultDigitado;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbAcertos;
        private System.Windows.Forms.Label lbQtdErros;
        private System.Windows.Forms.Label lbQtdAcertos;
    }
}

