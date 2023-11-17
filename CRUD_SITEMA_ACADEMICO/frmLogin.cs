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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nomeUser = txtName.Text;
            string passwordUser = txtPassword.Text;

            try
            {
                loginModel loginModel = new loginModel(nomeUser, passwordUser);
                cls_login loginDal = new cls_login();

                if (loginDal.UsuarioExiste(loginModel) && loginDal.SenhaCorreta(loginModel))
                {
                    FrmPrincipal principalForm = new FrmPrincipal();
                    principalForm.Show();

                    frmLogin login = new frmLogin();

                    login.Close();
                }
                else
                {
                    throw new Exception("Usuário ou senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeUser = txtName.Text;
            string passwordUser = txtPassword.Text;

            try
            {
                loginModel loginModel = new loginModel(nomeUser, passwordUser);
                cls_login loginDal = new cls_login();

                loginDal.InserirUsuario(loginModel);


                FrmPrincipal principalForm = new FrmPrincipal();
                principalForm.Show();



                frmLogin login = new frmLogin();

                login.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
