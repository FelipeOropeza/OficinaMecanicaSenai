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
    public partial class frmSaidaMat : Form
    {
        DataTable dt = new DataTable();
        public frmSaidaMat()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            dt = Material.selectMovimentacao(true);
            dgvSaidaMat.DataSource = dt;

            dgvSaidaMat.Columns["cod_sap"].HeaderText = "Codigo Sap";
            dgvSaidaMat.Columns["nm_prof"].HeaderText = "Professor";
            dgvSaidaMat.Columns["nm_tur"].HeaderText = "Turma";
            dgvSaidaMat.Columns["data_mov"].HeaderText = "Data/Hora";
            dgvSaidaMat.Columns["qtd_mov"].HeaderText = "Quantidade";

            foreach (DataGridViewColumn column in dgvSaidaMat.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

        }
    }
}
