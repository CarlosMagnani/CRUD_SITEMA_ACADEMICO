namespace CRUD_SITEMA_ACADEMICO
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(47, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(193, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(47, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "Logar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 202);
            button2.Name = "button2";
            button2.Size = new Size(88, 47);
            button2.TabIndex = 3;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 37);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 108);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // frmLogin
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cursoSelect;
        private ComboBox discipinaSelect;
        private Button adicionarDisciplina;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnSave;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}