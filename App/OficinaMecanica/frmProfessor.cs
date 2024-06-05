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
    public partial class frmProfessor : Form
    {   
        DataTable dt = new DataTable();
        public frmProfessor()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            dt = Professor.selectProf();
            dgvProf.DataSource = dt;
            dgvProf.Columns["id_prof"].Visible = false;
            dgvProf.Columns["nm_prof"].HeaderText = "Nome do Professor";
            dgvProf.Columns["sn_prof"].HeaderText = "SN";

            foreach (DataGridViewColumn column in dgvProf.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtSN.Text.Equals(""))
                {
                    Professor profFunc = new Professor();
                    profFunc.Nm_prof = txtNome.Text;
                    profFunc.Sn_prof = txtSN.Text;
                    if (profFunc.insertProfessor())
                    {
                        MessageBox.Show($"A professor {profFunc.Nm_prof} foi cadastrado com sucesso!");
                        Inicializar();
                        txtNome.Clear();
                        txtSN.Clear();
                        txtSN.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar o professor!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtSN.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar professor: " + ex.Message);
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSN.Clear();
            txtSN.Focus();
            Inicializar();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvProf.Rows[dgvProf.CurrentCell.RowIndex].Cells["id_prof"].Value);
            var frm = new frmProfExcluir(id);
            frm.ShowDialog();
            Inicializar();
        }
    }
}
