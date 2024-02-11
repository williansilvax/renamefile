namespace RenameFile
{
    partial class Form1
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
            label1 = new Label();
            txtDiretorio = new TextBox();
            btnSelecionar = new Button();
            btnRenomear = new Button();
            label2 = new Label();
            txtPseudoNome = new TextBox();
            lstArquivos = new ListBox();
            lstArquivosRenomeados = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            rbTodos = new RadioButton();
            rbUnico = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(57, 13);
            label1.TabIndex = 0;
            label1.Text = "Diretorio";
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(12, 21);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(491, 21);
            txtDiretorio.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(509, 20);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(81, 21);
            btnSelecionar.TabIndex = 2;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnRenomear
            // 
            btnRenomear.BackColor = Color.FromArgb(192, 255, 255);
            btnRenomear.Location = new Point(201, 88);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(96, 36);
            btnRenomear.TabIndex = 3;
            btnRenomear.Text = "Renomear Arquivos";
            btnRenomear.UseVisualStyleBackColor = false;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(90, 13);
            label2.TabIndex = 4;
            label2.Text = "Pseudo-nome:";
            // 
            // txtPseudoNome
            // 
            txtPseudoNome.Location = new Point(12, 61);
            txtPseudoNome.Name = "txtPseudoNome";
            txtPseudoNome.Size = new Size(156, 21);
            txtPseudoNome.TabIndex = 5;
            // 
            // lstArquivos
            // 
            lstArquivos.Dock = DockStyle.Fill;
            lstArquivos.FormattingEnabled = true;
            lstArquivos.ItemHeight = 13;
            lstArquivos.Location = new Point(3, 17);
            lstArquivos.Name = "lstArquivos";
            lstArquivos.Size = new Size(394, 358);
            lstArquivos.TabIndex = 6;
            // 
            // lstArquivosRenomeados
            // 
            lstArquivosRenomeados.Dock = DockStyle.Fill;
            lstArquivosRenomeados.FormattingEnabled = true;
            lstArquivosRenomeados.ItemHeight = 13;
            lstArquivosRenomeados.Location = new Point(3, 17);
            lstArquivosRenomeados.Name = "lstArquivosRenomeados";
            lstArquivosRenomeados.Size = new Size(394, 358);
            lstArquivosRenomeados.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstArquivosRenomeados);
            groupBox1.Location = new Point(418, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 378);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arquivos renomeados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstArquivos);
            groupBox2.Location = new Point(12, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 378);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arquivos do diretório";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(rbTodos);
            groupBox3.Controls.Add(rbUnico);
            groupBox3.Location = new Point(12, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(183, 36);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Checked = true;
            rbTodos.Location = new Point(115, 10);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(58, 17);
            rbTodos.TabIndex = 1;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbUnico
            // 
            rbUnico.AutoSize = true;
            rbUnico.Location = new Point(6, 10);
            rbUnico.Name = "rbUnico";
            rbUnico.Size = new Size(103, 17);
            rbUnico.TabIndex = 0;
            rbUnico.Text = "Único arquivo";
            rbUnico.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(828, 517);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtPseudoNome);
            Controls.Add(label2);
            Controls.Add(btnRenomear);
            Controls.Add(btnSelecionar);
            Controls.Add(txtDiretorio);
            Controls.Add(label1);
            Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Rename Files";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDiretorio;
        private Button btnSelecionar;
        private Button btnRenomear;
        private Label label2;
        private TextBox txtPseudoNome;
        private ListBox lstArquivos;
        private ListBox lstArquivosRenomeados;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rbTodos;
        private RadioButton rbUnico;
    }
}
