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
            connectionDatabase.Location = new Point(86, 24);
            connectionDatabase.Margin = new Padding(3, 4, 3, 4);
            connectionDatabase.Name = "connectionDatabase";
            connectionDatabase.Size = new Size(137, 67);
            connectionDatabase.TabIndex = 1;
            connectionDatabase.Text = "Conectar no banco";
            connectionDatabase.UseVisualStyleBackColor = true;
            connectionDatabase.Click += connectionDatabase_Click_1;
            // 
            // cadastroPeriodo
            // 
            cadastroPeriodo.Location = new Point(86, 115);
            cadastroPeriodo.Name = "cadastroPeriodo";
            cadastroPeriodo.Size = new Size(137, 68);
            cadastroPeriodo.TabIndex = 2;
            cadastroPeriodo.Text = "Cadastrar periodo";
            cadastroPeriodo.UseVisualStyleBackColor = true;
            cadastroPeriodo.Click += cadastroPeriodo_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 230);
            Controls.Add(cadastroPeriodo);
            Controls.Add(connectionDatabase);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "Form principal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button cadastrarCurso;
        private Button connectionDatabase;
        private Button cadastroPeriodo;
    }
}