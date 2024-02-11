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
            label3 = new Label();
            label4 = new Label();
            lstArquivosRenomeados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 57);
            label1.Name = "label1";
            label1.Size = new Size(57, 13);
            label1.TabIndex = 0;
            label1.Text = "Diretorio";
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(89, 72);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(491, 21);
            txtDiretorio.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(586, 71);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(81, 21);
            btnSelecionar.TabIndex = 2;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnRenomear
            // 
            btnRenomear.Location = new Point(251, 100);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(116, 42);
            btnRenomear.TabIndex = 3;
            btnRenomear.Text = "Renomear Arquivos";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 96);
            label2.Name = "label2";
            label2.Size = new Size(90, 13);
            label2.TabIndex = 4;
            label2.Text = "Pseudo-nome:";
            // 
            // txtPseudoNome
            // 
            txtPseudoNome.Location = new Point(89, 112);
            txtPseudoNome.Name = "txtPseudoNome";
            txtPseudoNome.Size = new Size(156, 21);
            txtPseudoNome.TabIndex = 5;
            // 
            // lstArquivos
            // 
            lstArquivos.FormattingEnabled = true;
            lstArquivos.ItemHeight = 13;
            lstArquivos.Location = new Point(89, 152);
            lstArquivos.Name = "lstArquivos";
            lstArquivos.Size = new Size(416, 134);
            lstArquivos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 13);
            label3.TabIndex = 7;
            label3.Text = "Arquivos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 289);
            label4.Name = "label4";
            label4.Size = new Size(132, 13);
            label4.TabIndex = 8;
            label4.Text = "Arquivos renomeados";
            // 
            // lstArquivosRenomeados
            // 
            lstArquivosRenomeados.FormattingEnabled = true;
            lstArquivosRenomeados.ItemHeight = 13;
            lstArquivosRenomeados.Location = new Point(89, 305);
            lstArquivosRenomeados.Name = "lstArquivosRenomeados";
            lstArquivosRenomeados.Size = new Size(416, 147);
            lstArquivosRenomeados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 527);
            Controls.Add(lstArquivosRenomeados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstArquivos);
            Controls.Add(txtPseudoNome);
            Controls.Add(label2);
            Controls.Add(btnRenomear);
            Controls.Add(btnSelecionar);
            Controls.Add(txtDiretorio);
            Controls.Add(label1);
            Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
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
        private Label label3;
        private Label label4;
        private ListBox lstArquivosRenomeados;
    }
}
