using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atron
{
    public partial class FrmVendaPrincipal : Form
    {
        public FrmVendaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVendaPrincipal_Load(object sender, EventArgs e)
        {
            frmMenuAbrirCaixa frmMenuAbrirCaixa = new frmMenuAbrirCaixa();
            frmMenuAbrirCaixa.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
