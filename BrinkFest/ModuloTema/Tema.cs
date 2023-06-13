using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class Tema : EntidadeBase <Tema>
    {
        public string titulo;
        public string item;
        public int quantidade;
        public decimal valor;
        public Tema(string titulo, string item, int quantidade, decimal valor)
        {
            this.titulo = titulo;
            this.item = item;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"titulo {titulo}, item {item}, quantidade {quantidade}, valor {valor}";
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
