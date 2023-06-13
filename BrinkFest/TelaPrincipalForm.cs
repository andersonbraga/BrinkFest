using BrinkFest.WinApp.Compartilhado;
using BrinkFest.WinApp.ModuloCliente;

namespace BrinkFest
{
    public partial class TelaPrincipalForm : Form
    {
        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private ControladorBase controlador;
        private static TelaPrincipalForm telaPrincipal;
        private IRepositorioCliente repositorioCliente = new RepositorioClienteEmArquivo(contextoDados);



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
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
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