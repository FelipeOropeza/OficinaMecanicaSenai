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
    public partial class frmMaterial : Form
    {   
        DataTable dt = new DataTable();
        public frmMaterial()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            dt = Material.selectMaterial(true);
            dgvMat.DataSource = dt;
            dgvMat.Columns["id_mat"].Visible = false;

            dgvMat.Columns["cod_sap"].HeaderText = "Codigo Sap";
            dgvMat.Columns["desc_mat"].HeaderText = "Descrição";
            dgvMat.Columns["uni_mat"].HeaderText = "Unidade";

            foreach (DataGridViewColumn column in dgvMat.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodSap.Text = "";
            txtDesc.Text = "";
            txtUni.Text = "";
            txtCodSap.Focus();
            dt = Material.selectMaterial(true);
            dgvMat.DataSource = dt;
            dgvMat.Columns["cod_sap"].Width = 120;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodSap.Text.Equals("") && !txtDesc.Text.Equals("") && !txtUni.Text.Equals(""))
                {
                    Material matFunc = new Material();
                    matFunc.Cod_sap = txtCodSap.Text;
                    matFunc.Desc_mat = txtDesc.Text;
                    matFunc.Uni_mat = txtUni.Text;
                    if (matFunc.insertMaterial())
                    {
                        MessageBox.Show($"A Material {matFunc.Cod_sap} foi cadastrado!");
                        Inicializar();
                        txtCodSap.Clear();
                        txtDesc.Clear();
                        txtUni.Clear();
                        txtCodSap.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar o material!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtCodSap.Clear();
                    txtDesc.Clear();
                    txtUni.Clear();
                    txtCodSap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar material: " + ex.Message);
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvMat.Rows[dgvMat.CurrentCell.RowIndex].Cells["id_mat"].Value);
            var frm = new frmMatExcluir(id);
            frm.ShowDialog();
            Inicializar();
        }
    }
}
