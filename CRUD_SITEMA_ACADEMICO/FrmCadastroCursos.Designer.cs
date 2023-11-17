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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)clsPeriodosDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // periodosSelect
            // 
            periodosSelect.FormattingEnabled = true;
            periodosSelect.Location = new Point(184, 85);
            periodosSelect.Margin = new Padding(3, 2, 3, 2);
            periodosSelect.Name = "periodosSelect";
            periodosSelect.Size = new Size(113, 23);
            periodosSelect.TabIndex = 0;
            // 
            // saveCurso
            // 
            saveCurso.Location = new Point(10, 146);
            saveCurso.Margin = new Padding(3, 2, 3, 2);
            saveCurso.Name = "saveCurso";
            saveCurso.Size = new Size(82, 38);
            saveCurso.TabIndex = 1;
            saveCurso.Text = "Salvar";
            saveCurso.UseVisualStyleBackColor = true;
            saveCurso.Click += saveCurso_Click;
            // 
            // cursoNome
            // 
            cursoNome.Location = new Point(10, 34);
            cursoNome.Margin = new Padding(3, 2, 3, 2);
            cursoNome.Name = "cursoNome";
            cursoNome.Size = new Size(113, 23);
            cursoNome.TabIndex = 3;
            // 
            // cursoObservacao
            // 
            cursoObservacao.Location = new Point(10, 85);
            cursoObservacao.Margin = new Padding(3, 2, 3, 2);
            cursoObservacao.Multiline = true;
            cursoObservacao.Name = "cursoObservacao";
            cursoObservacao.Size = new Size(112, 42);
            cursoObservacao.TabIndex = 4;
            // 
            // cursoSigla
            // 
            cursoSigla.Location = new Point(184, 34);
            cursoSigla.Margin = new Padding(3, 2, 3, 2);
            cursoSigla.Name = "cursoSigla";
            cursoSigla.Size = new Size(113, 23);
            cursoSigla.TabIndex = 5;
            // 
            // clsPeriodosDalBindingSource
            // 
            clsPeriodosDalBindingSource.DataSource = typeof(cls_dal.clsPeriodosDal);
            // 
            // limparRegistro
            // 
            limparRegistro.Location = new Point(98, 146);
            limparRegistro.Margin = new Padding(3, 2, 3, 2);
            limparRegistro.Name = "limparRegistro";
            limparRegistro.Size = new Size(80, 38);
            limparRegistro.TabIndex = 6;
            limparRegistro.Text = "Limpar";
            limparRegistro.UseVisualStyleBackColor = true;
            limparRegistro.Click += limparRegistro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 164);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(7, 6);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // voltarMenu
            // 
            voltarMenu.Location = new Point(184, 148);
            voltarMenu.Margin = new Padding(3, 2, 3, 2);
            voltarMenu.Name = "voltarMenu";
            voltarMenu.Size = new Size(80, 38);
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
            dataGridView1.Location = new Point(328, 32);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(462, 152);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Observações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 68);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 12;
            label3.Text = "Selecione um periodo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 13);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 13;
            label4.Text = "Sigla";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 120);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 14;
            // 
            // FrmCadastroCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 206);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(voltarMenu);
            Controls.Add(button1);
            Controls.Add(limparRegistro);
            Controls.Add(cursoSigla);
            Controls.Add(cursoObservacao);
            Controls.Add(cursoNome);
            Controls.Add(saveCurso);
            Controls.Add(periodosSelect);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}