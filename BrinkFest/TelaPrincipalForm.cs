namespace BrinkFest
{
    public partial class TelaPrincipalForm : Form
    {

        private ControladorBase controlador;
        private static TelaPrincipalForm telaPrincipal;


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