using System.Collections.Generic;
using System.Data.SqlClient;

namespace Forms03_entra21
{
    public static class DBConnection
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=LAPTOP-R77MK71E;Initial Catalog=tempdb;Integrated Security=True");

        public static void Execute(string comando)
        {
            SqlCommand cmd = new SqlCommand(comando, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

        }
        /// <summary>
        /// This function returns all elements selected in the table. The table already has the dbo. element.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectedElements</returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());

            }
            dr.Close();
            Connection.Close();

            return returnElements;
        }
        /// <summary>
        /// Select all values from all table's elements. Already have dbo. before our table.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();

            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }

            dr.Close();
            Connection.Close();
            return lista;

        }
    }
}
