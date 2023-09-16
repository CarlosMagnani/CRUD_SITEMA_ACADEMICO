namespace CRUD_SITEMA_ACADEMICO
{
    partial class FrmCadastroPeriodos
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
            perNome = new TextBox();
            perSigla = new TextBox();
            salvarPeriodo = new Button();
            label1 = new Label();
            label2 = new Label();
            cadastrarCurso = new Button();
            Voltar = new Button();
            SuspendLayout();
            // 
            // perNome
            // 
            perNome.Location = new Point(39, 36);
            perNome.Margin = new Padding(3, 4, 3, 4);
            perNome.Name = "perNome";
            perNome.Size = new Size(148, 27);
            perNome.TabIndex = 0;
            // 
            // perSigla
            // 
            perSigla.Location = new Point(236, 36);
            perSigla.Margin = new Padding(3, 4, 3, 4);
            perSigla.Name = "perSigla";
            perSigla.Size = new Size(148, 27);
            perSigla.TabIndex = 1;
            // 
            // salvarPeriodo
            // 
            salvarPeriodo.Location = new Point(39, 102);
            salvarPeriodo.Margin = new Padding(3, 4, 3, 4);
            salvarPeriodo.Name = "salvarPeriodo";
            salvarPeriodo.Size = new Size(103, 61);
            salvarPeriodo.TabIndex = 2;
            salvarPeriodo.Text = "Salvar";
            salvarPeriodo.UseVisualStyleBackColor = true;
            salvarPeriodo.Click += salvarPeriodo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome do Periodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 12);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Sigla";
            // 
            // cadastrarCurso
            // 
            cadastrarCurso.Location = new Point(168, 102);
            cadastrarCurso.Margin = new Padding(3, 4, 3, 4);
            cadastrarCurso.Name = "cadastrarCurso";
            cadastrarCurso.Size = new Size(144, 61);
            cadastrarCurso.TabIndex = 5;
            cadastrarCurso.Text = "Cadastrar curso";
            cadastrarCurso.UseVisualStyleBackColor = true;
            cadastrarCurso.Click += cadastrarCurso_Click;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(337, 102);
            Voltar.Margin = new Padding(3, 4, 3, 4);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(102, 61);
            Voltar.TabIndex = 6;
            Voltar.Text = "voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // FrmCadastroPeriodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 176);
            Controls.Add(Voltar);
            Controls.Add(cadastrarCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salvarPeriodo);
            Controls.Add(perSigla);
            Controls.Add(perNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCadastroPeriodos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox perNome;
        private TextBox perSigla;
        private Button salvarPeriodo;
        private Label label1;
        private Label label2;
        private Button cadastrarCurso;
        private Button Voltar;
    }
}