using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFacil
{
    public partial class FrmDificuldade : Form
    {
        String Operador;
        
        public FrmDificuldade(String Ope)
        {
            Operador = Ope;
            InitializeComponent();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmHome frm = new FrmHome("Facil",Operador);
            frm.ShowDialog();
            
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmHome frm = new FrmHome("Medio", Operador);
            frm.ShowDialog();
           
           
        }

        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmHome frm = new FrmHome("Dificil", Operador);
            frm.ShowDialog();
            
        }

        private void superDificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmHome frm = new FrmHome("SuperDificil", Operador);
            frm.ShowDialog();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
