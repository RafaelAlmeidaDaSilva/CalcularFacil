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
    public partial class FrmOperador : Form
    {
        public FrmOperador()
        {
            InitializeComponent();
        }

        private void msSomar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmDificuldade frm = new FrmDificuldade("+");
            frm.ShowDialog();
            
        }

        private void msSubtrair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmDificuldade frm = new FrmDificuldade("-");
            frm.ShowDialog();
            
        }

        private void msMultiplicar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmDificuldade frm = new FrmDificuldade("*");
            frm.ShowDialog();
            
        }

        private void msDividir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmDificuldade frm = new FrmDificuldade("/");
            frm.ShowDialog();
            
        }
    }
}
