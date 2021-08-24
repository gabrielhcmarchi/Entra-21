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
    public partial class frmExec03 : Form
    {
        public frmExec03()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        private void frmExec03_Load(object sender, EventArgs e)
        {
            dgProduto.Columns.Add("FornecedorCol", "Fornecedor");
            dgProduto.Columns["FornecedorCol"].Width = 223;
            AtualizaDG();
        }

        private void AtualizaDG()
        {
            dgProduto.Rows.Clear(); //limpa data grid view (linha)

            string select = $"SELECT * FROM dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string[] linha1 = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()};
                dgProduto.Rows.Add(linha1);
            }

            dr.Close();
            DBConnection.Connection.Close();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                string insert = $"INSERT into dbo.Produto (Nome, Preco, Fornecedor) values ('{txtNome.Text}', {txtPreco.Text}, '{txtFornecedor.Text}')";
                DBConnection.Execute(insert);
                AtualizaDG();
            }
            else if (checkRemove.Checked)
            {
                string remove = $"DELETE from dbo.Produto WHERE idProduto = '{txtNome.Text}'";
                DBConnection.Execute(remove);
                AtualizaDG();
            }
            else
            {
                MessageBox.Show("Marque uma opção.");
            }
            txtNome.Clear();
            txtPreco.Clear();
            txtFornecedor.Clear();
        }

        private void checkAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                checkRemove.Checked = false;
                lblNome.Text = "Nome";
                txtPreco.Visible = true;
                txtFornecedor.Visible = true;
                lblPreco.Visible = true;
                lblFornecedor.Visible = true;
            }
        }

        private void checkRemove_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkRemove.Checked)
            {
                checkAdd.Checked = false;
                lblNome.Text = "ID";
                txtPreco.Visible = false;
                txtFornecedor.Visible = false;
                lblPreco.Visible = false;
                lblFornecedor.Visible = false;
            }
        }
    }
}
