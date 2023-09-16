using cls_dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SITEMA_ACADEMICO
{
    public partial class FrmCadastroCursos : Form
    {
        public FrmCadastroCursos()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmCadastroCursos_Load);
        }
        private void FrmCadastroCursos_Load(object sender, EventArgs e)
        {
            try
            {
                clsPeriodosDal getPeriodos = new clsPeriodosDal();
                DataTable dataTable = getPeriodos.getPeriodos();
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "pernome";
                comboBox1.ValueMember = "perid";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
