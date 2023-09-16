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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // voltarMenu
            // 
            voltarMenu.Location = new Point(210, 169);
            voltarMenu.Name = "voltarMenu";
            voltarMenu.Size = new Size(95, 51);
            voltarMenu.TabIndex = 12;
            voltarMenu.Text = "Voltar";
            voltarMenu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(248, 193);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // limparRegistro
            // 
            limparRegistro.Location = new Point(112, 169);
            limparRegistro.Name = "limparRegistro";
            limparRegistro.Size = new Size(92, 51);
            limparRegistro.TabIndex = 10;
            limparRegistro.Text = "Limpar";
            limparRegistro.UseVisualStyleBackColor = true;
            // 
            // saveDisciplina
            // 
            saveDisciplina.Location = new Point(12, 169);
            saveDisciplina.Name = "saveDisciplina";
            saveDisciplina.Size = new Size(94, 51);
            saveDisciplina.TabIndex = 9;
            saveDisciplina.Text = "Salvar";
            saveDisciplina.UseVisualStyleBackColor = true;
            saveDisciplina.Click += saveDisciplina_Click;
            // 
            // disciplinaNome
            // 
            disciplinaNome.Location = new Point(30, 36);
            disciplinaNome.Name = "disciplinaNome";
            disciplinaNome.Size = new Size(115, 27);
            disciplinaNome.TabIndex = 13;
            // 
            // disciplinaObservacao
            // 
            disciplinaObservacao.Location = new Point(30, 95);
            disciplinaObservacao.Multiline = true;
            disciplinaObservacao.Name = "disciplinaObservacao";
            disciplinaObservacao.Size = new Size(115, 51);
            disciplinaObservacao.TabIndex = 14;
            // 
            // disciplinaSigla
            // 
            disciplinaSigla.Location = new Point(160, 36);
            disciplinaSigla.Name = "disciplinaSigla";
            disciplinaSigla.Size = new Size(115, 27);
            disciplinaSigla.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(426, 179);
            dataGridView1.TabIndex = 16;
            // 
            // FrmCadastroDisciplinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 235);
            Controls.Add(dataGridView1);
            Controls.Add(disciplinaSigla);
            Controls.Add(disciplinaObservacao);
            Controls.Add(disciplinaNome);
            Controls.Add(voltarMenu);
            Controls.Add(button1);
            Controls.Add(limparRegistro);
            Controls.Add(saveDisciplina);
            Name = "FrmCadastroDisciplinas";
            Text = "Form1";
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
    }
}