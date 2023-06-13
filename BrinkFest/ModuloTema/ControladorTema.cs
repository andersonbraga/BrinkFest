using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTema;
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar  Tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir  Tema existente"; } }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            
            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.Tema;

                repositorioTema.Inserir(tema);

                MessageBox.Show("Inserção completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Inserção Cancelada!");
            }
        }
        public override void Editar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            telaTema.Tema = tabelaTema.ObterIdSelecionado();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.Tema;

                repositorioTema.Editar(tema);

                MessageBox.Show("Edição completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Edição Cancelada!");
            }
        }
        public override void Excluir()
        {
            Tema tema = tabelaTema.ObterIdSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o Tema {tema.titulo} ?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(tema);

                MessageBox.Show("Exclusão completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Exclusão Cancelada!");
            }
        }
        private Tema ObterTarefaSelecionada()
        {
            
            int id = tabelaTema.ObterIdSelecionado();

            return SelecionarPorId(id);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTema();

            return tabelaTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
        public void CarregarTema()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }
    }
}