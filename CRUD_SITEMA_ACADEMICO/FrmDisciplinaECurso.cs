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
    public partial class FrmDisciplinaECurso : Form
    {
        public FrmDisciplinaECurso()
        {
            InitializeComponent();
        }
        private void FrmDisciplinaECurso_Load(object sender, EventArgs e)
        {
            clsDisciplinaDal getDisciplinas = new clsDisciplinaDal();
            DataTable infoDisciplinas = getDisciplinas.getDisciplinas();
            clsCursosDal getCursos = new clsCursosDal();
            DataTable infoCursos = getCursos.getCursos();
            clsDisciplinaECursoDal getDisciplinaECurso =  new clsDisciplinaECursoDal();
            DataTable infoDisECurso = getDisciplinaECurso.getDisciplinaECurso();

            dataGridView1.DataSource = infoDisECurso;
            cursoSelect.DataSource = infoCursos;
            cursoSelect.DisplayMember = "cursoSigla";
            cursoSelect.ValueMember = "cursoId";


            discipinaSelect.DataSource = infoDisciplinas;
            discipinaSelect.DisplayMember = "disSigla";
            discipinaSelect.ValueMember = "disid";
        }

        private void adicionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                int curid = (int)cursoSelect.SelectedValue;
                int disid = (int)discipinaSelect.SelectedValue;

                clsDisECursoModel disECursoModel = new clsDisECursoModel(disid, curid);
                clsDisciplinaECursoDal disciplinaECursoDal = new clsDisciplinaECursoDal();
                disciplinaECursoDal.Inserir(disECursoModel);

                clsDisciplinaECursoDal getDisciplinaECurso = new clsDisciplinaECursoDal();
                DataTable infoDisECurso = getDisciplinaECurso.getDisciplinaECurso();

                dataGridView1.DataSource = infoDisECurso;
                MessageBox.Show("Disciplina Adicionada com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex.Message);
            }

        }
    }
}
