using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms03_entra21
{
    public partial class Deposito : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-R77MK71E;Initial Catalog=tempdb;Integrated Security=True");
        public Deposito()
        {
            InitializeComponent();
        }

        private void btnSairDeposito_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Conta Set Saldo = Saldo + {txtQtdDeposito.Text} WHERE NumeroConta = {txtContaDeposito.Text}";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtQtdDeposito.Clear();
            txtContaDeposito.Clear();
        }

        
    }
}
