using BrinkFest.WinApp.Compartilhado;
using BrinkFest.WinApp.ModuloAluguel;
using BrinkFest.WinApp.ModuloCliente;
using BrinkFest.WinApp.ModuloTema;

namespace BrinkFest
{
    public partial class TelaPrincipalForm : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private ControladorBase controlador;
        private static TelaPrincipalForm telaPrincipal;
        private IRepositorioCliente repositorioCliente = new RepositorioClienteEmArquivo(contextoDados);
        private IRepositorioTema repositorioTema = new RepositorioTemaEmArquivo(contextoDados);
        private IRepositorioAluguel repositorioAluguel = new RepositorioAluguelEmArquivo(contextoDados);

        //static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);


            ConfigurarTelaPrincipal(controlador);
        }
        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
        }
        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            barraFerramentas.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarEstados(controlador);
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;


            panelRegistros.Controls.Clear();
            panelRegistros.Show();
            panelRegistros.Controls.Add(listagem);
        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            //btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            //btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            //btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;
        }
        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            //btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            //btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            //btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (controlador != null)
            {
                controlador.Inserir();
            }
            else
            {
                MessageBox.Show("Selecione uma opção do Menu");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador != null)
            {
                controlador.Editar();
            }
            else
            {
                MessageBox.Show("Selecione uma opção do Menu");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador != null)
            {
                controlador.Excluir();
            }
            else
            {
                MessageBox.Show("Selecione uma opção do Menu");
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            TelaPrincipalForm telaPrincipalForm = new TelaPrincipalForm();


            ConfigurarTelaPrincipal(controlador);
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm telaPrincipalForm = new TelaPrincipalForm();
            telaPrincipalForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioCliente, repositorioAluguel, repositorioTema);


            ConfigurarTelaPrincipal(controlador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioCliente, repositorioAluguel, repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.Adicionar();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao tentar abrir menu do tema");
            }
         
            
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }
    }
}