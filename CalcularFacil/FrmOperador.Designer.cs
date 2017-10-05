namespace CalcularFacil
{
    partial class FrmOperador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSomar = new System.Windows.Forms.ToolStripMenuItem();
            this.msSubtrair = new System.Windows.Forms.ToolStripMenuItem();
            this.msMultiplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.msDividir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 33F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSomar,
            this.msSubtrair,
            this.msMultiplicar,
            this.msDividir});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(79, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 265);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSomar
            // 
            this.msSomar.Name = "msSomar";
            this.msSomar.Size = new System.Drawing.Size(356, 64);
            this.msSomar.Text = "Soma (+)";
            this.msSomar.Click += new System.EventHandler(this.msSomar_Click);
            // 
            // msSubtrair
            // 
            this.msSubtrair.Name = "msSubtrair";
            this.msSubtrair.Size = new System.Drawing.Size(501, 64);
            this.msSubtrair.Text = "Subtração (-)";
            this.msSubtrair.Click += new System.EventHandler(this.msSubtrair_Click);
            // 
            // msMultiplicar
            // 
            this.msMultiplicar.Name = "msMultiplicar";
            this.msMultiplicar.Size = new System.Drawing.Size(501, 64);
            this.msMultiplicar.Text = "Multiplicação (*)";
            this.msMultiplicar.Click += new System.EventHandler(this.msMultiplicar_Click);
            // 
            // msDividir
            // 
            this.msDividir.Name = "msDividir";
            this.msDividir.Size = new System.Drawing.Size(501, 64);
            this.msDividir.Text = "Divisão (/)";
            this.msDividir.Click += new System.EventHandler(this.msDividir_Click);
            // 
            // FrmOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(532, 349);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSomar;
        private System.Windows.Forms.ToolStripMenuItem msSubtrair;
        private System.Windows.Forms.ToolStripMenuItem msMultiplicar;
        private System.Windows.Forms.ToolStripMenuItem msDividir;
    }
}