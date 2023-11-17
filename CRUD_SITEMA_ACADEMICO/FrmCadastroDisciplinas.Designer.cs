namespace CRUD_SITEMA_ACADEMICO
{
    partial class FrmCadastroDisciplinas
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
            voltarMenu = new Button();
            button1 = new Button();
            limparRegistro = new Button();
            saveDisciplina = new Button();
            disciplinaNome = new TextBox();
            disciplinaObservacao = new TextBox();
            disciplinaSigla = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // voltarMenu
            // 
            voltarMenu.Location = new Point(184, 127);
            voltarMenu.Margin = new Padding(3, 2, 3, 2);
            voltarMenu.Name = "voltarMenu";
            voltarMenu.Size = new Size(83, 38);
            voltarMenu.TabIndex = 12;
            voltarMenu.Text = "Voltar";
            voltarMenu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(217, 145);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(7, 6);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // limparRegistro
            // 
            limparRegistro.Location = new Point(98, 127);
            limparRegistro.Margin = new Padding(3, 2, 3, 2);
            limparRegistro.Name = "limparRegistro";
            limparRegistro.Size = new Size(80, 38);
            limparRegistro.TabIndex = 10;
            limparRegistro.Text = "Limpar";
            limparRegistro.UseVisualStyleBackColor = true;
            // 
            // saveDisciplina
            // 
            saveDisciplina.Location = new Point(10, 127);
            saveDisciplina.Margin = new Padding(3, 2, 3, 2);
            saveDisciplina.Name = "saveDisciplina";
            saveDisciplina.Size = new Size(82, 38);
            saveDisciplina.TabIndex = 9;
            saveDisciplina.Text = "Salvar";
            saveDisciplina.UseVisualStyleBackColor = true;
            saveDisciplina.Click += saveDisciplina_Click;
            // 
            // disciplinaNome
            // 
            disciplinaNome.Location = new Point(26, 27);
            disciplinaNome.Margin = new Padding(3, 2, 3, 2);
            disciplinaNome.Name = "disciplinaNome";
            disciplinaNome.Size = new Size(101, 23);
            disciplinaNome.TabIndex = 13;
            // 
            // disciplinaObservacao
            // 
            disciplinaObservacao.Location = new Point(26, 78);
            disciplinaObservacao.Margin = new Padding(3, 2, 3, 2);
            disciplinaObservacao.Multiline = true;
            disciplinaObservacao.Name = "disciplinaObservacao";
            disciplinaObservacao.Size = new Size(101, 39);
            disciplinaObservacao.TabIndex = 14;
            // 
            // disciplinaSigla
            // 
            disciplinaSigla.Location = new Point(140, 27);
            disciplinaSigla.Margin = new Padding(3, 2, 3, 2);
            disciplinaSigla.Name = "disciplinaSigla";
            disciplinaSigla.Size = new Size(101, 23);
            disciplinaSigla.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 24);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(373, 134);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 17;
            label1.Text = "Nome disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 18;
            label2.Text = "Sigla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 61);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 19;
            label3.Text = "Observações";
            // 
            // FrmCadastroDisciplinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 176);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(disciplinaSigla);
            Controls.Add(disciplinaObservacao);
            Controls.Add(disciplinaNome);
            Controls.Add(voltarMenu);
            Controls.Add(button1);
            Controls.Add(limparRegistro);
            Controls.Add(saveDisciplina);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastroDisciplinas";
            Text = "Form1";
            Load += FrmCadastroDisciplinas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarMenu;
        private Button button1;
        private Button limparRegistro;
        private Button saveDisciplina;
        private TextBox disciplinaNome;
        private TextBox disciplinaObservacao;
        private TextBox disciplinaSigla;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}