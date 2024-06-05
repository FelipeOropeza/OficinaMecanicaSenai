using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    class Armazem
    {
        public int Id_arm { get; set; }
        public string Des_arm { get; set; }

        public static DataTable selectArm()
        {
            var dt = new DataTable();

            var sql = "select * from tbl_armazem;";

            try
            {
                using (var cn = new MySqlConnection(Conexao.conexao))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public bool insertArmazem()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertArmazem('{Des_arm}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertArmazem: " + ex.Message);
                return false;
            }
        }

        public static DataTable pesquisaArmazem(string pesq, string codsap)
        {
            var dt = new DataTable();

            var sql = $"select distinct id_arm, desc_arm from vwMatLocaliza where desc_mat like '%{pesq}%' and cod_sap = '{codsap}'";

            try
            {
                using (var cn = new MySqlConnection(Conexao.conexao))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
    }
}
