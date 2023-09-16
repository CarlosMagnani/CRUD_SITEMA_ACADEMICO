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
    public partial class FrmCadastroDisciplinas : Form
    {
        public FrmCadastroDisciplinas()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            clsDisciplinaDal getData =  new clsDisciplinaDal();
            DataTable disciplinaDataTable = getData.getDisciplinas();
            dataGridView1.DataSource = disciplinaDataTable;
        }
        private void saveDisciplina_Click(object sender, EventArgs e)
        {
            string nomeDis =  disciplinaNome.Text;
            string siglaDis =  disciplinaSigla.Text;
            string observacaoDisc =  disciplinaObservacao.Text;
            try
            {
                clsDisciplinasModel disciplinasModel = new clsDisciplinasModel(nomeDis, siglaDis, observacaoDisc);
                clsDisciplinaDal disciplinaDal = new clsDisciplinaDal();
                disciplinaDal.Insert(disciplinasModel);

                clsDisciplinaDal getData = new clsDisciplinaDal();
                DataTable disciplinaDataTable = getData.getDisciplinas();
                dataGridView1.DataSource = disciplinaDataTable;
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch(Exception ex) {
                MessageBox.Show("Error " + ex);
            }

        }
    }
}
