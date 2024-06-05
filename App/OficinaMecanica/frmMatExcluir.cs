using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class frmMatExcluir : Form
    {
        Material matFunc = new Material();
        int id;

        public frmMatExcluir(int id)
        {
            InitializeComponent();
            this.id = id;

            if(this.id > 0)
            {
                matFunc.GetMaterial(this.id);
                txtId.Text = matFunc.Id_mat.ToString();
                txtCodSap.Text = matFunc.Cod_sap;
                txtDesc.Text = matFunc.Desc_mat;
                txtUni.Text = matFunc.Uni_mat;
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                matFunc.Id_mat = int.Parse(txtId.Text);

                if (matFunc.deleteMaterial())
                {
                    MessageBox.Show("o material foi excluido com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir material!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir material: " + ex.Message);
                Close();
            }
        }
    }
}
