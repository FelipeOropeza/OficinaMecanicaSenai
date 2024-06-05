using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    class Material
    {
        public int Id_mat { get; set; }
        public string Cod_sap { get; set; }
        public string Desc_mat { get; set; }
        public string Uni_mat { get; set; }

        public static DataTable GetMateriais(bool ativos)
        {
            var dt = new DataTable();
            
            var sql = "select cod_sap, desc_arm, nm_pos, qtd_est from vwMatLocaliza;";

            try
            {
                using(var cn = new MySqlConnection(Conexao.conexao))
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

        public void GetMaterial(int id)
        {
            var sql = $"select * from tbl_material where id_mat = {id}";

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
                                    this.Id_mat = Convert.ToInt32(dr["id_mat"]);
                                    this.Cod_sap = dr["cod_sap"].ToString();
                                    this.Desc_mat = dr["desc_mat"].ToString();
                                    this.Uni_mat = dr["uni_mat"].ToString();
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

        public static DataTable GetMateriaisCod(bool ativos, string cod)
        {
            var dt = new DataTable();

            var sql = $"select cod_sap, desc_arm, nm_pos, qtd_est from vwMatLocaliza where cod_sap = '{cod}';";

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

        public static DataTable selectPesquisaDesc(string pesq)
        {
            var dt = new DataTable();

            var sql = $"select cod_sap, desc_mat, desc_arm, nm_pos, qtd_est from vwMatLocaliza where desc_mat like '%{pesq}%';";

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

        public static DataTable selectMaterial(bool ativos)
        {
            var dt = new DataTable();

            var sql = $"select * from tbl_material;";

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

        public static DataTable selectMovimentacao(bool ativos)
        {
            var dt = new DataTable();

            var sql = "select * from vwMovimenta order by data_mov desc";

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

        public bool insertMaterial()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertMateiral('{Cod_sap}', '{Desc_mat}', '{Uni_mat}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertMaterial: " + ex.Message);
                return false;
            }
        }

        public bool deleteMaterial()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string delete = $"delete from tbl_material where id_mat = '{Id_mat}';";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método deleteMaterial: " + ex.Message);
                return false;
            }
        }

        public bool insertLocaliza(int codArm, int codPos, int qtdMat)
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertLocaliza('{Cod_sap}', '{codArm}', '{codPos}', '{qtdMat}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertLocaliza: " + ex.Message);
                return false;
            }
        }

        public bool insertMovimentacao(bool ativos, int qtdMat, int codPos, int codArm, int codprof, int codTur)
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                int valor = ativos ? 1 : 0;

                string procedure = $"call spInsertMovimentacao('{valor}', '{qtdMat}', '{Cod_sap}', '{codPos}', '{codArm}', '{codprof}', '{codTur}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertMovimentacao: " + ex.Message);
                return false;
            }
        }
    }
}
