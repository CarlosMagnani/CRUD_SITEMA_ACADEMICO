namespace CRUD_SITEMA_ACADEMICO
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cadastrarCurso = new Button();
            connectionDatabase = new Button();
            cadastroPeriodo = new Button();
            cadastroCurso = new Button();
            cadastroDisciplina = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cadastrarCurso
            // 
            cadastrarCurso.Location = new Point(0, 0);
            cadastrarCurso.Name = "cadastrarCurso";
            cadastrarCurso.Size = new Size(75, 23);
            cadastrarCurso.TabIndex = 0;
            // 
            // connectionDatabase
            // 
            connectionDatabase.Location = new Point(10, 23);
            connectionDatabase.Name = "connectionDatabase";
            connectionDatabase.Size = new Size(120, 50);
            connectionDatabase.TabIndex = 1;
            connectionDatabase.Text = "Conectar no banco";
            connectionDatabase.UseVisualStyleBackColor = true;
            connectionDatabase.Click += connectionDatabase_Click_1;
            // 
            // cadastroPeriodo
            // 
            cadastroPeriodo.Location = new Point(136, 23);
            cadastroPeriodo.Margin = new Padding(3, 2, 3, 2);
            cadastroPeriodo.Name = "cadastroPeriodo";
            cadastroPeriodo.Size = new Size(120, 51);
            cadastroPeriodo.TabIndex = 2;
            cadastroPeriodo.Text = "Cadastrar periodo";
            cadastroPeriodo.UseVisualStyleBackColor = true;
            cadastroPeriodo.Click += cadastroPeriodo_Click;
            // 
            // cadastroCurso
            // 
            cadastroCurso.Location = new Point(261, 24);
            cadastroCurso.Name = "cadastroCurso";
            cadastroCurso.Size = new Size(120, 50);
            cadastroCurso.TabIndex = 3;
            cadastroCurso.Text = "Cadastrar curso";
            cadastroCurso.UseVisualStyleBackColor = true;
            cadastroCurso.Click += cadastroCurso_Click;
            // 
            // cadastroDisciplina
            // 
            cadastroDisciplina.Location = new Point(10, 80);
            cadastroDisciplina.Name = "cadastroDisciplina";
            cadastroDisciplina.Size = new Size(120, 50);
            cadastroDisciplina.TabIndex = 4;
            cadastroDisciplina.Text = "Cadastrar disciplina";
            cadastroDisciplina.UseVisualStyleBackColor = true;
            cadastroDisciplina.Click += cadastroDisciplina_Click;
            // 
            // button1
            // 
            button1.Location = new Point(136, 80);
            button1.Name = "button1";
            button1.Size = new Size(183, 50);
            button1.TabIndex = 5;
            button1.Text = "Adicionar disciplina ao curso";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 136);
            Controls.Add(button1);
            Controls.Add(cadastroDisciplina);
            Controls.Add(cadastroCurso);
            Controls.Add(cadastroPeriodo);
            Controls.Add(connectionDatabase);
            Name = "FrmPrincipal";
            Text = "CARLOS EDUARDO DOS SANTOS MAGNANI G500DJ4";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button cadastrarCurso;
        private Button connectionDatabase;
        private Button cadastroPeriodo;
        private Button cadastroCurso;
        private Button cadastroDisciplina;
    }
}