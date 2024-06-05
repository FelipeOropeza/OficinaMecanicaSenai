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
    public partial class frmTurma : Form
    {
        DataTable dt = new DataTable();

        public frmTurma()
        {
            InitializeComponent();
            MontarComboBox();
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

        private void btnAddTurma_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && cbProf.SelectedIndex != -1)
                {
                    string combo = cbProf.SelectedItem.ToString();
                    Turma turFunc = new Turma();
                    turFunc.Nm_tur = txtNome.Text;
                    if (turFunc.insertTurma(combo))
                    {
                        MessageBox.Show($"A Turma {turFunc.Nm_tur} foi cadastrada e vinculada!");
                        txtNome.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar a turma!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma: " + ex.Message);
            }
        }
    }
}
