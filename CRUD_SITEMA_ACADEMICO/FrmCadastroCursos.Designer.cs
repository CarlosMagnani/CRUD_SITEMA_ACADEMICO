namespace CRUD_SITEMA_ACADEMICO
{
    partial class FrmCadastroCursos
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
            components = new System.ComponentModel.Container();
            periodosSelect = new ComboBox();
            saveCurso = new Button();
            cursoNome = new TextBox();
            cursoObservacao = new TextBox();
            cursoSigla = new TextBox();
            clsPeriodosDalBindingSource = new BindingSource(components);
            limparRegistro = new Button();
            button1 = new Button();
            voltarMenu = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clsPeriodosDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // periodosSelect
            // 
            periodosSelect.FormattingEnabled = true;
            periodosSelect.Location = new Point(210, 104);
            periodosSelect.Name = "periodosSelect";
            periodosSelect.Size = new Size(129, 28);
            periodosSelect.TabIndex = 0;
            // 
            // saveCurso
            // 
            saveCurso.Location = new Point(12, 195);
            saveCurso.Name = "saveCurso";
            saveCurso.Size = new Size(94, 51);
            saveCurso.TabIndex = 1;
            saveCurso.Text = "Salvar";
            saveCurso.UseVisualStyleBackColor = true;
            saveCurso.Click += saveCurso_Click;
            // 
            // cursoNome
            // 
            cursoNome.Location = new Point(12, 45);
            cursoNome.Name = "cursoNome";
            cursoNome.Size = new Size(129, 27);
            cursoNome.TabIndex = 3;
            // 
            // cursoObservacao
            // 
            cursoObservacao.Location = new Point(12, 104);
            cursoObservacao.Multiline = true;
            cursoObservacao.Name = "cursoObservacao";
            cursoObservacao.Size = new Size(127, 55);
            cursoObservacao.TabIndex = 4;
            // 
            // cursoSigla
            // 
            cursoSigla.Location = new Point(210, 45);
            cursoSigla.Name = "cursoSigla";
            cursoSigla.Size = new Size(129, 27);
            cursoSigla.TabIndex = 5;
            // 
            // clsPeriodosDalBindingSource
            // 
            clsPeriodosDalBindingSource.DataSource = typeof(cls_dal.clsPeriodosDal);
            // 
            // limparRegistro
            // 
            limparRegistro.Location = new Point(112, 195);
            limparRegistro.Name = "limparRegistro";
            limparRegistro.Size = new Size(92, 51);
            limparRegistro.TabIndex = 6;
            limparRegistro.Text = "Limpar";
            limparRegistro.UseVisualStyleBackColor = true;
            limparRegistro.Click += limparRegistro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(248, 219);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // voltarMenu
            // 
            voltarMenu.Location = new Point(210, 198);
            voltarMenu.Name = "voltarMenu";
            voltarMenu.Size = new Size(92, 51);
            voltarMenu.TabIndex = 8;
            voltarMenu.Text = "Voltar";
            voltarMenu.UseVisualStyleBackColor = true;
            voltarMenu.Click += voltarMenu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(453, 203);
            dataGridView1.TabIndex = 9;
            // 
            // FrmCadastroCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 275);
            Controls.Add(dataGridView1);
            Controls.Add(voltarMenu);
            Controls.Add(button1);
            Controls.Add(limparRegistro);
            Controls.Add(cursoSigla);
            Controls.Add(cursoObservacao);
            Controls.Add(cursoNome);
            Controls.Add(saveCurso);
            Controls.Add(periodosSelect);
            Name = "FrmCadastroCursos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)clsPeriodosDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox periodosSelect;
        private Button saveCurso;
        private TextBox cursoNome;
        private TextBox cursoObservacao;
        private TextBox cursoSigla;
        private BindingSource clsPeriodosDalBindingSource;
        private Button limparRegistro;
        private Button button1;
        private Button voltarMenu;
        private DataGridView dataGridView1;
    }
}