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
    public partial class FrmPedidosCancelados2 : Form
    {
        public FrmPedidosCancelados2()
        {
            InitializeComponent();
        }

        private void lblMeiaCanoAlto_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPedidosCancelados3 FrmPedidosCancelados3 = new FrmPedidosCancelados3();  
            FrmPedidosCancelados3.Show();
        }
    }
}
