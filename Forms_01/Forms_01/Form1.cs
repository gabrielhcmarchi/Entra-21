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

namespace Forms_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-R77MK71E;Initial Catalog=tempdb;Integrated Security=True");
       

        

        private void btnLog_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Cadastro WHERE LoginUser = '{txtLog.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(txtPass.Text == dr["PasswordKey"].ToString())
                {
                    MessageBox.Show("Login efetuado");
                }
                else
                {
                    MessageBox.Show("Login fracassou");
                }
            }
            dr.Close();
            conn.Close();

        }
    }
}
