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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(285, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(460, 211);
            dataGridView1.TabIndex = 0;
            // 
            // cursoSelect
            // 
            cursoSelect.FormattingEnabled = true;
            cursoSelect.Location = new Point(17, 44);
            cursoSelect.Name = "cursoSelect";
            cursoSelect.Size = new Size(218, 28);
            cursoSelect.TabIndex = 1;
            // 
            // discipinaSelect
            // 
            discipinaSelect.FormattingEnabled = true;
            discipinaSelect.Location = new Point(17, 124);
            discipinaSelect.Name = "discipinaSelect";
            discipinaSelect.Size = new Size(218, 28);
            discipinaSelect.TabIndex = 2;
            // 
            // adicionarDisciplina
            // 
            adicionarDisciplina.Location = new Point(17, 208);
            adicionarDisciplina.Name = "adicionarDisciplina";
            adicionarDisciplina.Size = new Size(218, 44);
            adicionarDisciplina.TabIndex = 3;
            adicionarDisciplina.Text = "Adicionar";
            adicionarDisciplina.UseVisualStyleBackColor = true;
            adicionarDisciplina.Click += adicionarDisciplina_Click;
            // 
            // FrmDisciplinaECurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 286);
            Controls.Add(adicionarDisciplina);
            Controls.Add(discipinaSelect);
            Controls.Add(cursoSelect);
            Controls.Add(dataGridView1);
            Name = "FrmDisciplinaECurso";
            Text = "Form1";
            Load += FrmDisciplinaECurso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cursoSelect;
        private ComboBox discipinaSelect;
        private Button adicionarDisciplina;
    }
}