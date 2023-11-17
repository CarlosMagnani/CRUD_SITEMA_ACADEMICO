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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // perNome
            // 
            perNome.Location = new Point(24, 27);
            perNome.Name = "perNome";
            perNome.Size = new Size(130, 23);
            perNome.TabIndex = 0;
            // 
            // perSigla
            // 
            perSigla.Location = new Point(206, 27);
            perSigla.Name = "perSigla";
            perSigla.Size = new Size(130, 23);
            perSigla.TabIndex = 1;
            // 
            // salvarPeriodo
            // 
            salvarPeriodo.Location = new Point(24, 76);
            salvarPeriodo.Name = "salvarPeriodo";
            salvarPeriodo.Size = new Size(90, 46);
            salvarPeriodo.TabIndex = 2;
            salvarPeriodo.Text = "Salvar";
            salvarPeriodo.UseVisualStyleBackColor = true;
            salvarPeriodo.Click += salvarPeriodo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome do Periodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Sigla";
            // 
            // cadastrarCurso
            // 
            cadastrarCurso.Location = new Point(120, 76);
            cadastrarCurso.Name = "cadastrarCurso";
            cadastrarCurso.Size = new Size(126, 46);
            cadastrarCurso.TabIndex = 5;
            cadastrarCurso.Text = "Cadastrar curso";
            cadastrarCurso.UseVisualStyleBackColor = true;
            cadastrarCurso.Click += cadastrarCurso_Click;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(252, 76);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(89, 46);
            Voltar.TabIndex = 6;
            Voltar.Text = "voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(692, 227);
            dataGridView1.TabIndex = 7;
            // 
            // FrmCadastroPeriodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 421);
            Controls.Add(dataGridView1);
            Controls.Add(Voltar);
            Controls.Add(cadastrarCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salvarPeriodo);
            Controls.Add(perSigla);
            Controls.Add(perNome);
            Name = "FrmCadastroPeriodos";
            Text = "Form1";
            Load += FrmCadastroPeriodos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}