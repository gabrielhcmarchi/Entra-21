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
    public partial class frmExec04 : Form
    {
        public frmExec04()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        private void frmExec04_Load(object sender, EventArgs e)
        {
            cbNomes.Items.Clear();
            List<string> elements = DBConnection.GenericUnitSelect("Nome", "Pessoa");
            foreach (var item in elements)
            {
                cbNomes.Items.Add(item);
            }

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dgNome.Rows.Clear();
            string select = $"SELECT * from dbo.Pessoa WHERE Nome= '{cbNomes.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string[] elements = { dr[0].ToString(), dr[1].ToString(), $@"{Convert.ToInt64(dr[2].ToString()):000\.000\.000\-00}", dr[3].ToString()};
                dgNome.Rows.Add(elements);

            }
            dr.Close();
            DBConnection.Connection.Close();


        }
        //private void AtualizaDGPessoa()
        //{
        //    dgPessoa.Rows.Clear(); //limpa data grid view (linha)

        //    string select = $"SELECT * FROM dbo.Produto";
        //    SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
        //    DBConnection.Connection.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        string[] linha1 = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
        //        dgPessoa.Rows.Add(linha1);
        //    }

        //    dr.Close();
        //    DBConnection.Connection.Close();
        //}
    }
}
