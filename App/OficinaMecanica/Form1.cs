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
    public partial class frm_est : Form
    {
        DataTable dt = new DataTable();
        private Form frmAtivo;

        public frm_est()
        {
            InitializeComponent();
            Inicializar();
            dgvMaterial.CellDoubleClick += dgvMaterial_CellContentClick;
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        public void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMaterial);
            FormShow(new frmMaterial());
        }


        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProfessor);
            FormShow(new frmProfessor());
        }


        private void btnLoca_Click(object sender, EventArgs e)
        {
            ActiveButton(btnLoca);
            FormShow(new frmLocalizacao());
        }

        private void btnMov_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMov);
            FormShow(new frmMovimentacao());
        }

        private void btnSaiMat_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSaiMat);
            FormShow(new frmSaidaMat());
        }

        public void Inicializar()
        {
            dt = Material.GetMateriais(true);
            dgvMaterial.DataSource = dt;
            dgvMaterial.Columns["cod_sap"].HeaderText = "Codigo Sap";
            dgvMaterial.Columns["desc_arm"].HeaderText = "Armazem";
            dgvMaterial.Columns["nm_pos"].HeaderText = "Posição";
            dgvMaterial.Columns["qtd_est"].HeaderText = "Quantidade";

            foreach (DataGridViewColumn column in dgvMaterial.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodSap.Text.Equals(""))
                {
                    dt = Material.GetMateriaisCod(true, txtCodSap.Text);
                    if (dt.Rows.Count > 0)
                    {
                        dgvMaterial.DataSource = dt;
                        foreach (DataGridViewColumn column in dgvMaterial.Columns)
                        {
                            column.Resizable = DataGridViewTriState.False;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum material foi encontrado com esse codigo");
                    }
                }
                else
                {
                    dt = Material.GetMateriais(true);
                    dgvMaterial.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao fazer a pesquisa : " + ex.Message);
            }
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMaterial.Columns["cod_sap"].Index && e.RowIndex >= 0)
            {
                object cellValue = dgvMaterial.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    txtCodSap.Text = cellValue.ToString();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodSap.Text = "";
            dt = Material.GetMateriais(true);
            dgvMaterial.DataSource = dt;
        }

        private void btnAddEstoque_Click(object sender, EventArgs e)
        {
            var frm = new frmEstoque();
            frm.ShowDialog();
        }

        private void btnAddTurma_Click(object sender, EventArgs e)
        {
            var frm = new frmTurma();
            frm.ShowDialog();
        }

        private void btnAddPosicao_Click(object sender, EventArgs e)
        {
            var frm = new frmPosicao();
            frm.ShowDialog();
        }
    }
}
