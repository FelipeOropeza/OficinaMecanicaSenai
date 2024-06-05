using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class frmLocalizacao : Form
    {
        DataTable dt = new DataTable();
        int[] idsArm;
        string[] nomesArm;
        int[] idsPos;
        string[] nomesPos;

        public frmLocalizacao()
        {
            InitializeComponent();
            Inicializar();
            MontarComboBoxPos();
            MontarComboBoxArm();
        }

        public void Inicializar()
        {
            dt = Material.GetMateriais(true);
            dgvLoc.DataSource = dt;
            dgvLoc.Columns["cod_sap"].HeaderText = "Codigo Sap";
            dgvLoc.Columns["desc_arm"].HeaderText = "Armazem";
            dgvLoc.Columns["nm_pos"].HeaderText = "Posição";
            dgvLoc.Columns["qtd_est"].HeaderText = "Quantidade";

            foreach (DataGridViewColumn column in dgvLoc.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        public void MontarComboBoxPos()
        {
            cbPos.Items.Clear();
            dt = Posicao.selectPos();

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

        public void MontarComboBoxArm()
        {
            cbArm.Items.Clear();
            dt = Armazem.selectArm();

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodSap.Clear();
            txtQtd.Clear();
            MontarComboBoxArm();
            MontarComboBoxPos();
            txtCodSap.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodSap.Text.Equals("") && !txtQtd.Text.Equals("") && cbPos.SelectedIndex != -1 && cbArm.SelectedIndex != -1)
                {
                    int indexPos = cbPos.SelectedIndex;
                    int idPos = idsPos[indexPos];
                    int indexArm = cbArm.SelectedIndex;
                    int idArm = idsArm[indexArm];
                    int qtd = Convert.ToInt32(txtQtd.Text);
                    Material matFunc = new Material();
                    matFunc.Cod_sap = txtCodSap.Text;
                    if (matFunc.insertLocaliza(idArm, idPos, qtd))
                    {
                        MessageBox.Show($"O material {matFunc.Cod_sap} foi vinculado a uma localização!");
                        txtCodSap.Clear();
                        txtQtd.Clear();
                        MontarComboBoxArm();
                        MontarComboBoxPos();
                        txtCodSap.Focus();
                        Inicializar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel vincular o material a uma localização!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtCodSap.Clear();
                    txtQtd.Clear();
                    MontarComboBoxArm();
                    MontarComboBoxPos();
                    txtCodSap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a localização do material: " + ex.Message);
            }
        }

        private void dgvLoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLoc.Columns["cod_sap"].Index && e.RowIndex >= 0)
            {
                object cellValue = dgvLoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    txtCodSap.Text = cellValue.ToString();
                }
            }
        }
    }

}
