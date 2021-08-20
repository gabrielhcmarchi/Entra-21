using System;
using System.Data.SqlClient;
namespace DBAula
{
    class Program
    {
        static void Main(string[] args)
        {



            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o cliente: ", i + 1);
            //    string nome = Console.ReadLine();
            //    string cpf = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    string insert = $"INSERT into dbo.Pessoa(Nome, CPF, IDADE) values ('{nome}' , '{cpf}' ,'{idade}' )";
            //    cmd = new SqlCommand(insert, conn);//prepação insert
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();


            //}

            //// update

            //string update = "UPDATE dbo.Pessoa Set Nome = 'Joao', Idade = 25 WHERE idPessoa = 1";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            ////delete

            //string delete = "DELETE from dbo.Pessoa WHERE Nome = 'Carlos'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            ////select

            //string select = "SELECT * FROM dbo.Pessoa";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idPessoa"]);
            //    Console.WriteLine(dr[0]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine("---------------------");
            //}
            //dr.Close();
            //conn.Close();

            //delete = "DELETE * from dbo.Pessoa";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //exec 02

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o {0}º cachorro: ", i + 1);
            //    string nome = Console.ReadLine();
            //    string nomeDoDono = Console.ReadLine();
            //    string telefone = Console.ReadLine();
            //    string insert = $"INSERT into dbo.Cachorro (Nome, NomeDoDono, TelefoneDoDono) values ('{nome}', '{nomeDoDono}' , '{telefone}') ";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //string select = "SELECT * from dbo.Cachorro";
            ////string select = "SElECT * from dbo.Empresa WHERE Salario LIKE > 3000";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idCachorro"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr["TelefoneDoDono"]);
            //    Console.WriteLine("-------------------");
            //}

            //dr.Close();
            //conn.Close();

            //exec03

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o {0}º funcionario: ", i + 1);
            //    string nome = Console.ReadLine();
            //    string cargo = Console.ReadLine();
            //    int salario = int.Parse(Console.ReadLine());
            //    string insert = $"INSERT into dbo.Empresa (NomeDoFuncionario, Cargo, Salario) values ('{nome}', '{cargo}' , '{salario}')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //exec03/05
            //string update = "UPDATE dbo.Empresa Set Salario = 3000 WHERE Salario < 3000 ";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string select = "SElECT * from dbo.Empresa WHERE Salario >= 3000";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idFuncionario"]);
            //    Console.WriteLine(dr["NomeDoFuncionario"]);
            //    Console.WriteLine(dr["Cargo"]);
            //    Console.WriteLine(dr["Salario"]);
            //    Console.WriteLine("-------------------");
            //}

            //dr.Close();
            //conn.Close();



            //exec04


            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o email: ", i + 1);
            //    string email = Console.ReadLine();
            //    string insert = $"INSERT into dbo.Emails(EnderecoEmail) values ('{email}')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();

            //}

            //exec 06
            //string delete = "DELETE from dbo.Emails WHERE EnderecoEmail NOT LIKE '%outlook%'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string select = "SELECT * from dbo.Emails WHERE EnderecoEmail LIKE '%@outlook.com%'";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["EnderecoEmail"]);
            //    Console.WriteLine("-------------------");
            //}

            //dr.Close();
            //conn.Close();

            //lista 02 exec 01a

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-R77MK71E;Initial Catalog=tempdb;Integrated Security=True");
            SqlCommand cmd;
            //while ()
            //{

            //}

            while (true)
            {
                Console.WriteLine("  *****Menu***** ");
                Console.WriteLine("|1 - Adicionar  |");
                Console.WriteLine("|2 - Remover    |");
                Console.WriteLine("|3 - Atualizar  |");
                Console.WriteLine("|4 - Mostrar    |");
                Console.WriteLine("|5 - Encerrar   |");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("Qual o nome?");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Qual o preço?");
                    int preco = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a quantidade em estoque?");
                    int qtd = int.Parse(Console.ReadLine());

                    string insert = $"INSERT into dbo.Produto (Nome, Preco, QtdEstoque) values ('{nome}',{preco},{qtd})";
                    cmd = new SqlCommand(insert, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.Clear();
                }
                else if (escolha == 2)
                {
                    string select = "SELECT Nome from dbo.Produto ";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0]);
                    }
                    dr.Close();
                    conn.Close();

                    Console.WriteLine("\n");
                    Console.WriteLine("Qual produto deseja remover?");
                    string produtoParaExcluir = Console.ReadLine();

                    string delete = $"DELETE from dbo.Produto WHERE Nome = '{produtoParaExcluir}'";
                    cmd = new SqlCommand(delete, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.Clear();
                }
                else if (escolha == 3)
                {
                    string select = "SELECT * from dbo.Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Nome            :      " + dr[1]);
                        Console.WriteLine("Preço           :      " + dr[2]);
                        Console.WriteLine("Quantidade      :      " + dr[3]);
                        Console.WriteLine("------------------------");
                    }
                    dr.Close();
                    conn.Close();

                    Console.WriteLine("\nQual produto deseja atualizar?");
                    string produto = Console.ReadLine();
                    Console.WriteLine("Nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço");
                    int preco = int.Parse(Console.ReadLine());
                    Console.WriteLine("QtdEstoque");
                    int qtd = int.Parse(Console.ReadLine());

                    string update = $"UPDATE dbo.Produto Set Nome = '{nome}', Preco = {preco}, QtdEstoque = {qtd} WHERE Nome = '{produto}'";
                    cmd = new SqlCommand(update, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Tecle qualquer coisa para voltar");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (escolha == 4)
                {
                    Console.Write("id");
                    Console.Write("  Nome");
                    Console.Write("  Preco");
                    Console.WriteLine("  QtdEstoque");
                    string select = "SELECT * from dbo.Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.Write(dr[0]);
                        Console.Write("  " + dr["Nome"]);
                        Console.Write("   " + dr["Preco"]);
                        Console.WriteLine("    " + dr[3]);
                    }
                    dr.Close();
                    conn.Close();
                    Console.WriteLine("Tecle qualquer coisa para voltar...");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (escolha == 5)
                {
                    Console.WriteLine("valeu");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
                //função de update do db pra parte B do exercicio
            }
        }
    }
}

