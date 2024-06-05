using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Data;

namespace OficinaMecanica
{
    class Posicao
    {
        public int Id_pos { get; set; }
        public string Nm_pos { get; set; }


        public static DataTable selectPos()
        {
            var dt = new DataTable();

            var sql = "select * from tbl_posicao;";

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

        public bool insertPosicao()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertPosicao('{Nm_pos}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertPosicao: " + ex.Message);
                return false;
            }
        }

        public static DataTable pesquisaPosicao(string pesq, string codsap)
        {
            var dt = new DataTable();

            var sql = $"select distinct id_pos, nm_pos from vwMatLocaliza where desc_mat like '%{pesq}%' and cod_sap = '{codsap}'";

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
