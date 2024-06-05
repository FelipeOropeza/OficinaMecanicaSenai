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
    public partial class frmPosicao : Form
    {
        public frmPosicao()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    Posicao posFunc = new Posicao();
                    posFunc.Nm_pos = txtNome.Text;
                    if (posFunc.insertPosicao())
                    {
                        MessageBox.Show($"A posição {posFunc.Nm_pos} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtNome.Focus();

                        var formLocalizacao = Application.OpenForms.OfType<frmLocalizacao>().FirstOrDefault();
                        if (formLocalizacao != null)
                        {
                            formLocalizacao.MontarComboBoxPos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar uma posição!");
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
                MessageBox.Show("Erro ao cadastrar posição: " + ex.Message);
            }
        }
    }
}
