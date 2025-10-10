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
    public partial class FrmPedidosEmFalta1 : Form
    {
        public FrmPedidosEmFalta1()
        {
            InitializeComponent();
        }

        private void btnMeia_Click(object sender, EventArgs e)
        {
            FrmPedidosEmFalta2 FrmPedidosEmFalta2 = new FrmPedidosEmFalta2();
            FrmPedidosEmFalta2.Show();
        }
    }
}
