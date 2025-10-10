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
    public partial class FrmGerenciamentodeHistorico : Form
    {
        public FrmGerenciamentodeHistorico()
        {
            InitializeComponent();
        }

        private void btnHistoricoPedidos_Click(object sender, EventArgs e)
        {
            FrmHistoricodePedidos frmHistoricodePedidos = new FrmHistoricodePedidos();
            frmHistoricodePedidos.Show();
        }

        private void btnHistoricoEntradaSaida_Click(object sender, EventArgs e)
        {
            FrmHistoricoEntradaeSaida frmHistoricoEntradaeSaida = new FrmHistoricoEntradaeSaida();  
            frmHistoricoEntradaeSaida.Show();
        }
    }
}
