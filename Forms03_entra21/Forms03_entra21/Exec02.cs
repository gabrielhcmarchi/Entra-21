using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms03_entra21
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void Exec02_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            Form1 f1 = new Form1();
            this.FindForm().Hide();
            f1.Show();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            Saque f = new Saque();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Deposito f = new Deposito();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
