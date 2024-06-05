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
    class Turma
    {
        public int Id_tur { get; set; }
        public string Nm_tur { get; set; }
        public int Fk_prof { get; set; }

        public bool insertTurma(string SN)
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertTurmaProf('{Nm_tur}', '{SN}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertTurma: " + ex.Message);
                return false;
            }
        }

        public static DataTable pesquisaTurma(string pesq)
        {
            var dt = new DataTable();

            var sql = $"select id_tur, nm_tur from vwProfTurma where sn_prof = '{pesq}';";

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
