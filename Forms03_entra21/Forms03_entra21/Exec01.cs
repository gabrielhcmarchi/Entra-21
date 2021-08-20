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
    public partial class Exec01 : Form
    {

        public Exec01()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            new Form1().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                bool admin = false;
                string select = $"SELECT AccessLevel from dbo.Usuario WHERE UserName = '{txtUserName.Text}' and PasswordKey = '{txtPassword.Text}'";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (Convert.ToInt32(dr[0]) > 4)
                    {
                        admin = true;
                        MessageBox.Show("Login");
                    }
                    else
                    {
                        MessageBox.Show("Login Efetuado");
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado");
                }
                dr.Close();
                DBConnection.Connection.Close();
                if (admin)
                {
                    //carregar a tela
                    new TelaAdm().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username is empty.");
            }
            txtPassword.Clear();
        }

        private void Exec01_Load(object sender, EventArgs e)
        {

        }
    }
}
