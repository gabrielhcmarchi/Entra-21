using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms03_entra21
{
    public partial class FM : Form
    {
        public FM()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        private void FM_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        private void AtualizaDG()
        {
            List<string[]> lista = DBConnection.GenericSelectAll("Historico");
            dgHistorico.Rows.Clear();
            foreach (var item in lista)
            {
                dgHistorico.Rows.Add(item);
            }
            for (int i = 0; i < dgHistorico.Rows.Count; i++)
            {
                if (Convert.ToDouble(dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Value.ToString()) < 0)
                {
                    dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Style.ForeColor = Color.Red;
                }
            }
        }


        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double valorLiquido = 0, novoSaldo = 0, despesas = 0, ganhos = 0;
            bool lucrou = true;

            double valor = Convert.ToDouble(dgHistorico.Rows[dgHistorico.Rows.Count - 1].Cells[1].Value);
            despesas = Convert.ToDouble(txtDespesas.Text);
            ganhos = Convert.ToDouble(txtGanhos.Text);

            CalculaMes(valor, despesas, ganhos, out valorLiquido, out novoSaldo, out lucrou);
            //System.Globalization.TextInfo 
            string insert = $"INSERT into dbo.Historico (ValorEmCaixa,DespesasDoMes,GanhosDoMes,ValorLiquido,SeLucrou) values ({novoSaldo.ToString(CultureInfo.InvariantCulture)},{despesas.ToString(CultureInfo.InvariantCulture)},{ganhos.ToString(CultureInfo.InvariantCulture)},{valorLiquido.ToString(CultureInfo.InvariantCulture)},{Convert.ToInt32(lucrou)})";

            DBConnection.Execute(insert);
            AtualizaDG();
        }

      
        private void CalculaMes(double saldoAtual, double despesas, double ganhos, out double valorLiquido, out double novoSaldo, out bool deuLucro)
        {
            valorLiquido = ganhos - despesas;
            novoSaldo = saldoAtual + valorLiquido;
            if (valorLiquido > 0)
            {
                deuLucro = true;
            }
            else
            {
                deuLucro = false;
            }
        }
    }
}
