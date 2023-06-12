using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class RepositorioTema
    {
        List<Tema> temas = new List<Tema>();
        private static int contador;
        public void Inserir(Tema tema)
        {
            contador++;
            tema.id = contador;
            temas.Add(tema);
        }
        public void Editar(Tema tema)
        {
            Tema temaSelecionado = SelecionarPorID(tema.id);

            temaSelecionado.titulo = tema.titulo;
            temaSelecionado.item = tema.item;
            temaSelecionado.quantidade = tema.quantidade;
            temaSelecionado.valor = tema.valor;
        }
        public void Excluir(Tema tema)
        {
            temas.Remove(tema);
        }
        public List<Tema> SelecionarTodos()
        {
            return temas;
        }
        public Tema SelecionarPorID(int id)
        {
            return temas.FirstOrDefault(x => x.id == id);
        }
    }
}
