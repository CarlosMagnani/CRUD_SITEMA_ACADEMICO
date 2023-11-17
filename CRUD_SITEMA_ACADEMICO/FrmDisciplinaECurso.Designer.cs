namespace CRUD_SITEMA_ACADEMICO
{
    partial class FrmDisciplinaECurso
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
            dataGridView1 = new DataGridView();
            cursoSelect = new ComboBox();
            discipinaSelect = new ComboBox();
            adicionarDisciplina = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 31);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(546, 158);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cursoSelect
            // 
            cursoSelect.FormattingEnabled = true;
            cursoSelect.Location = new Point(15, 33);
            cursoSelect.Margin = new Padding(3, 2, 3, 2);
            cursoSelect.Name = "cursoSelect";
            cursoSelect.Size = new Size(191, 23);
            cursoSelect.TabIndex = 1;
            // 
            // discipinaSelect
            // 
            discipinaSelect.FormattingEnabled = true;
            discipinaSelect.Location = new Point(15, 93);
            discipinaSelect.Margin = new Padding(3, 2, 3, 2);
            discipinaSelect.Name = "discipinaSelect";
            discipinaSelect.Size = new Size(191, 23);
            discipinaSelect.TabIndex = 2;
            // 
            // adicionarDisciplina
            // 
            adicionarDisciplina.Location = new Point(15, 156);
            adicionarDisciplina.Margin = new Padding(3, 2, 3, 2);
            adicionarDisciplina.Name = "adicionarDisciplina";
            adicionarDisciplina.Size = new Size(191, 33);
            adicionarDisciplina.TabIndex = 3;
            adicionarDisciplina.Text = "Adicionar";
            adicionarDisciplina.UseVisualStyleBackColor = true;
            adicionarDisciplina.Click += adicionarDisciplina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Selecione um curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 5;
            label2.Text = "Selecione uma disciplina";
            // 
            // FrmDisciplinaECurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 214);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adicionarDisciplina);
            Controls.Add(discipinaSelect);
            Controls.Add(cursoSelect);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDisciplinaECurso";
            Text = "Form1";
            Load += FrmDisciplinaECurso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}