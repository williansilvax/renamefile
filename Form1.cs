namespace RenameFile
{
    public partial class Form1 : Form
    {
        public string Diretorio { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void ListarArquivosDoDiretorio(string? diretorio)
        {
            if (diretorio != null)
            {
                DirectoryInfo dinfo = new(diretorio);
                this.Text = " ";
                this.Text = this.Text + " - " + dinfo.Name;

                lstArquivos.Items.Clear();

                foreach (FileInfo fi in dinfo.GetFiles())
                {
                    lstArquivos.Items.Add(fi.Name);
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (txtDiretorio.Text.Equals(""))
            {
                var dialog = new FolderBrowserDialog();
                dialog.Description = "Selecione o diretório...";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Diretorio = dialog.SelectedPath.ToString();
                }
            }
            else
            {
                Diretorio = txtDiretorio.Text;
            }
            txtDiretorio.Text = Diretorio;
            ListarArquivosDoDiretorio(Diretorio);
        }

        private void RenomearTodosArquivos(string? diretorio)
        {
            if (diretorio != null)
            {
                DirectoryInfo dinfo = new(diretorio);

                lstArquivosRenomeados.Items.Clear();
                try
                {
                    foreach (FileInfo fi in dinfo.GetFiles())
                    {
                        string nome = Path.GetFileName(fi.Name);
                        string? novoNome = null;
                        if (!txtPseudoNome.Text.Equals(""))
                        {
                            novoNome = txtPseudoNome.Text + "_" + nome;
                        }
                        else
                        {
                            Random randNum = new Random();
                            novoNome = randNum.Next().ToString() + " _" + nome;
                        }
                        string novoCaminho = Path.Combine(diretorio, novoNome);
                        File.Move(fi.FullName, novoCaminho);
                        lstArquivosRenomeados.Items.Add(novoNome);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbTodos.Checked)
                {
                    RenomearTodosArquivos(Diretorio);
                }
                else if (rbUnico.Checked)
                {
                    RenomearUnicoArquivo(Diretorio);
                }

                MessageBox.Show("Operação realizada com sucess","Renomear",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RenomearUnicoArquivo(string diretorio)
        {
            string? arquivoSelecionado = lstArquivos.Items[lstArquivos.SelectedIndex].ToString();
            string? novoNome = null;

            if (!txtPseudoNome.Text.Equals(""))
            {
                novoNome = txtPseudoNome.Text + "_" + arquivoSelecionado;
            }
            else
            {
                Random randNum = new Random();
                novoNome = randNum.Next().ToString() + " _" + arquivoSelecionado;
            }

            string novoCaminho = Path.Combine(diretorio, novoNome);
            File.Move(Path.Combine(diretorio,arquivoSelecionado), novoCaminho);
            lstArquivosRenomeados.Items.Add(novoNome);

        }
    }
}
