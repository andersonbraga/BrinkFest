using BrinkFest.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    public class ControladorTema2 : ControladorBase
    {
        private IRepositorioTema2 iRepositorioTema2;
        private TabelaTema2Control tabelaTema2;

        public override string ToolTipInserir => "Inserir novo Tema";

        public override string ToolTipEditar => "Editar Tema existente";

        public override string ToolTipExcluir => "Excluir Tema existente";

        public ControladorTema2(IRepositorioTema2 repositorioTema2)
        {
            this.iRepositorioTema2 = repositorioTema2;
        }
        private void CarregarTema2()
        {
            List<Tema2> tema2 = iRepositorioTema2.SelecionarTodos();

            tabelaTema2.AtualizarTema2(tema2);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tema2.Count}categoria(s)");

        }
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaTema2Form telaTema2 = new TelaTema2Form();
            DialogResult opcaoEscolhida = telaTema2.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema2 novaCategoria = telaTema2.ObterTema2();

                iRepositorioTema2.Inserir(novaCategoria);
            }

            CarregarTema2();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
