using BrinkFest.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Inserir(Tema novoTema);

        void Editar(int id, Tema tema);

        void Excluir(Tema temaSelecionado);

        List<Tema> SelecionarTodos();

        Tema SelecionarPorId(int id);
    }
}
