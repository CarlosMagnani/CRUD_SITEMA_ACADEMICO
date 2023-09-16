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
using cls_dal;
using cls_model;

namespace CRUD_SITEMA_ACADEMICO
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void connectionDatabase_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = cls_dal.Connection.connection();
                connection.Close();

                MessageBox.Show("Conexão bem sucedida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroPeriodo_Click(object sender, EventArgs e)
        {
            FrmCadastroPeriodos frmCadastroPeriodos = new FrmCadastroPeriodos();
            frmCadastroPeriodos.ShowDialog();
        }
    }
}