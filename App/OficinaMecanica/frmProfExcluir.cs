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
    public partial class frmProfExcluir : Form
    {
        Professor profFunc = new Professor();
        int id;

        public frmProfExcluir(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                profFunc.GetProfessor(this.id);
                txtId.Text = profFunc.Id_prof.ToString();
                txtNomeProf.Text = profFunc.Nm_prof;
                txtSN.Text = profFunc.Sn_prof;
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                profFunc.Id_prof = int.Parse(txtId.Text);

                if (profFunc.deleteProfessor())
                {
                    MessageBox.Show("o professor foi excluido com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir professor!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor: " + ex.Message);
                Close();
            }
        }
    }
}
