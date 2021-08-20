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
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }

        private void TelaAdm_Load(object sender, EventArgs e)
        {
            listUsuarios.Items.Add("UserName\t\t\tPassword\t\t\tAccessLevel");
            string select = "SELECT * from dbo.Usuario";

            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);

            DBConnection.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string texto = "";
                for (int i = 1; i < 4; i++)
                {
                    texto += dr[i].ToString() + "\t\t\t\t";
                }
                listUsuarios.Items.Add(texto);
            }
            DBConnection.Connection.Close();
            dr.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Exec01().Show();
            this.Hide();
        }
    }
}
