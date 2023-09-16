using cls_dal;
using cls_model;
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
                clsCursosDal getCursos = new clsCursosDal();
                DataTable infosToGrid = getCursos.getCursos();

                dataGridView1.DataSource = infosToGrid;
                periodosSelect.DataSource = dataTable;
                periodosSelect.DisplayMember = "pernome";
                periodosSelect.ValueMember = "perid";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void saveCurso_Click(object sender, EventArgs e)
        {
            string curso = cursoNome.Text;
            string sigla = cursoSigla.Text;
            string observervacao = cursoObservacao.Text;
            int perid = (int)periodosSelect.SelectedValue;
            try
            {
                clsCursosModel cursoModel = new clsCursosModel(curso, sigla, observervacao, perid);
                clsCursosDal clsCursosDal = new clsCursosDal();
                clsCursosDal.Insert(cursoModel);

                clsCursosDal getCursos = new clsCursosDal();
                DataTable infosToGrid = getCursos.getCursos();

                dataGridView1.DataSource = infosToGrid;
                MessageBox.Show("Curso cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void limparRegistro_Click(object sender, EventArgs e)
        {
            cursoNome.Clear();
            cursoSigla.Clear();
            cursoObservacao.Clear();
            cursoNome.Focus();
        }

        private void voltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();


            FrmPrincipal frmPrincipal = Application.OpenForms["FrmPrincipal"] as FrmPrincipal;


            if (frmPrincipal != null)
            {
                frmPrincipal.BringToFront();
            }
            else
            {

                frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
            }

        }
    }
}
