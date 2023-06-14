using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    public class Tema2 : EntidadeBase<Tema2>
    {
        public string tema2;
        public List<Item> itemRelacionado;

        public Tema2()
        {
        }

        public Tema2(string tema2)
        {
            this.tema2 = tema2;
            this.itemRelacionado = new List<Item>();
        }

        public Tema2(int id, string tema2)
        {
            this.id = id;
            this.tema2 = tema2;
            this.itemRelacionado = new List<Item>();
        }

        public override void AtualizarInformacoes(Tema2 registroAtualizado)
        {
            this.tema2 = registroAtualizado.tema2;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(tema2))
            {
                erros.Add("O Campo 'titulo' é obrigatório");

            }
            return erros.ToArray();
        }
    }
}
