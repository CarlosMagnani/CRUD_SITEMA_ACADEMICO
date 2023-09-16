using cls_dal;
using cls_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SITEMA_ACADEMICO
{
    public partial class FrmCadastroPeriodos : Form
    {
        public FrmCadastroPeriodos()
        {
            InitializeComponent();
        }
        private void salvarPeriodo_Click(object sender, EventArgs e)
        {
            string periodoNome = perNome.Text;
            string periodoSigla = perSigla.Text;
            try
            {
                clsPeriodosModel perModel = new clsPeriodosModel(periodoNome, periodoSigla);
                clsPeriodosDal clsPeriodosDal = new clsPeriodosDal();
                clsPeriodosDal.insert(perModel);
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void cadastrarCurso_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmCadastroCursos frmCursos = new FrmCadastroCursos();
            frmCursos.ShowDialog();
        }

        private void Voltar_Click(object sender, EventArgs e)
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
