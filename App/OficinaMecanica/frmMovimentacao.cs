using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OficinaMecanica
{
    public partial class frmMovimentacao : Form
    {
        DataTable dt = new DataTable();
        int[] idsArm;
        string[] nomesArm;
        int[] idsPos;
        string[] nomesPos;

        public frmMovimentacao()
        {
            InitializeComponent();
            MontarComboBox();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesq.Text.Equals(""))
            {
                dt = Material.selectPesquisaDesc(txtPesq.Text);
                dgvLoc.DataSource = dt;

                dgvLoc.Columns["cod_sap"].HeaderText = "Codigo Sap";
                dgvLoc.Columns["cod_sap"].Width = 120; 
                dgvLoc.Columns["desc_mat"].HeaderText = "Descrição";
                dgvLoc.Columns["desc_arm"].HeaderText = "Armazem";
                dgvLoc.Columns["nm_pos"].HeaderText = "Posição";
                dgvLoc.Columns["nm_pos"].Width = 80;
                dgvLoc.Columns["qtd_est"].HeaderText = "Quantidade";
                dgvLoc.Columns["qtd_est"].Width = 100;

                foreach (DataGridViewColumn column in dgvLoc.Columns)
                {
                    column.Resizable = DataGridViewTriState.False;
                }
            }
            else
            {
                dgvLoc.DataSource = null;
            }
        }

        public void MontarComboBoxPos(string pesq, string cod)
        {
            cbPos.Items.Clear();
            dt = Posicao.pesquisaPosicao(pesq, cod);

            if (dt.Rows.Count > 0)
            {
                idsPos = new int[dt.Rows.Count];
                nomesPos = new string[dt.Rows.Count];

                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["id_pos"]);
                    string nome = row["nm_pos"].ToString();

                    idsPos[cbPos.Items.Count] = id;
                    nomesPos[cbPos.Items.Count] = nome;

                    cbPos.Items.Add(nome);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma posição encontrada.");
            }
        }

        public void MontarComboBoxArm(string pesq, string cod)
        {
            cbArm.Items.Clear();
            dt = Armazem.pesquisaArmazem(pesq, cod);

            if (dt.Rows.Count > 0)
            {
                idsArm = new int[dt.Rows.Count];
                nomesArm = new string[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    idsArm[i] = Convert.ToInt32(dt.Rows[i]["id_arm"]);
                    nomesArm[i] = dt.Rows[i]["desc_arm"].ToString();

                    cbArm.Items.Add(nomesArm[i]);
                }
            }
            else
            {
                MessageBox.Show("Nenhum armazém encontrado.");
            }
        }

        public void MontarComboBox()
        {
            cbProf.Items.Clear();
            dt = Professor.selectProf();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string nome = row["sn_prof"].ToString();

                    cbProf.Items.Add(nome);
                }
            }
            else
            {
                MessageBox.Show("Nenhum professor encontrado.");
            }
        }

        private void dgvLoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLoc.Columns["cod_sap"].Index && e.RowIndex >= 0)
            {
                object cellValue = dgvLoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string codSap = cellValue.ToString();
                    MontarComboBoxPos(txtPesq.Text, codSap);
                    MontarComboBoxArm(txtPesq.Text, codSap);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtQtd.Text.Equals("") && cbProf.SelectedIndex != -1 && cbPos.SelectedIndex != -1 && cbArm.SelectedIndex != -1)
                {
                    bool isChecked = chbTipo.Checked;
                    int indexPos = cbPos.SelectedIndex;
                    int idPos = idsPos[indexPos];
                    int indexArm = cbArm.SelectedIndex;
                    int idArm = idsArm[indexArm];
                    int qtd = Convert.ToInt32(txtQtd.Text);
                    string idProf = cbProf.SelectedItem.ToString();
                    string codSap = dgvLoc.Rows[dgvLoc.CurrentCell.RowIndex].Cells["cod_sap"].Value.ToString();

                    if (isChecked == false)
                    {
                        Material matFunc = new Material();
                        matFunc.Cod_sap = codSap;

                        if (matFunc.insertMovimentacao(false, qtd, idPos, idArm, 1, 1))
                        {
                            MessageBox.Show($"A movimentação de entrada foi feita!");
                            ApagarDados();
                            txtPesq.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel fazer a movimentação!");
                        }
                    }
                    else
                    {
                        var frm = new frmEscolhaTurma(true, qtd, idPos, idArm, idProf, codSap);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer a movimentação do estoque: " + ex.Message);
            }
        }

        public void ApagarDados()
        {
            txtPesq.Clear();
            txtQtd.Clear();
            dgvLoc.DataSource = null;
            cbArm.Items.Clear();
            cbPos.Items.Clear();
        }
    }
}
