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
        private ListagemTemaControl listagemTema;
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar  Tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir  Tema existente"; } }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }
        public override void Editar()
        {
            throw new NotImplementedException();
        }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public override UserControl ObterListagem()
        {
            if (listagemTema == null)
                listagemTema = new ListagemTemaControl();

            CarregarTema();

            return listagemTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
        public void CarregarTema()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            listagemTema.AtualizarRegistro(temas);
        }
    }
}