using BrinkFest.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    public interface IRepositorioTema2
    {
        void Inserir(Tema2 novoTema2);

        void Editar(int id, Tema2 tema2);

        void Excluir(Tema2 tema2Selecionado);

        List<Tema2> SelecionarTodos();

        Tema2 SelecionarPorId(int id);
    }
}
