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
    public partial class frmEscolhaTurma : Form
    {
        DataTable dt = new DataTable();
        int[] idsTurs;
        string[] nomesTurs;
        bool ativo;
        int qtd;
        int idpos;
        int idarm;
        string idprof;
        string codsap;

        public frmEscolhaTurma(bool ativo, int qtd, int idpos, int idarm, string idprof, string codsap)
        {
            InitializeComponent();
            this.ativo = ativo;
            this.qtd = qtd;
            this.idpos = idpos;
            this.idarm = idarm;
            this.idprof = idprof;
            this.codsap = codsap;

            txtSN.Text = idprof;
            MontarComboBoxTurma(idprof);
        }

        public void MontarComboBoxTurma(string sn)
        {
            cbTur.Items.Clear();
            dt = Turma.pesquisaTurma(sn);

            if (dt.Rows.Count > 0)
            {
                idsTurs = new int[dt.Rows.Count];
                nomesTurs = new string[dt.Rows.Count];

                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["id_tur"]);
                    string nome = row["nm_tur"].ToString();

                    idsTurs[cbTur.Items.Count] = id;
                    nomesTurs[cbTur.Items.Count] = nome;

                    cbTur.Items.Add(nome);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma turma encontrada.");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int indexTur = cbTur.SelectedIndex;
            int idTur = idsTurs[indexTur];
            Material matFunc = new Material();
            matFunc.Cod_sap = this.codsap;
            dt = Professor.GetProfessorSN(this.idprof);
            int idProf = Convert.ToInt32(dt.Rows[0]["id_prof"]);


            if (matFunc.insertMovimentacao(true, this.qtd, this.idpos, this.idarm, idProf, idTur))
            {
                MessageBox.Show($"A movimentação de saida foi feita!");
                var formMovimentacao = Application.OpenForms.OfType<frmMovimentacao>().FirstOrDefault();
                if (formMovimentacao != null)
                {
                    formMovimentacao.ApagarDados();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Não foi possivel fazer a movimentação!");
                Close();
            }
        }
    }
}
