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
    class Professor
    {
        public int Id_prof { get; set; }
        public string Nm_prof { get; set; }
        public string Sn_prof { get; set; }

        public static DataTable selectProf()
        {
            var dt = new DataTable();

            var sql = "select * from tbl_professor;";

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

        public void GetProfessor(int id)
        {
            var sql = $"select * from tbl_professor where id_prof = {id}";

            try
            {
                using (var cn = new MySqlConnection(Conexao.conexao))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    this.Id_prof = Convert.ToInt32(dr["id_prof"]);
                                    this.Nm_prof = dr["nm_prof"].ToString();
                                    this.Sn_prof = dr["sn_prof"].ToString();
                                }
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable GetProfessorSN(string Sn)
        {
            var dt = new DataTable();

            var sql = $"select id_prof from tbl_professor where sn_prof = '{Sn}';";

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

        public bool insertProfessor()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertProfessor('{Nm_prof}', '{Sn_prof}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertProfessor: " + ex.Message);
                return false;
            }
        }

        public bool deleteProfessor()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string delete = $"delete from tbl_professor where id_prof = '{Id_prof}';";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método deleteProfessor: " + ex.Message);
                return false;
            }
        }
    }
}
