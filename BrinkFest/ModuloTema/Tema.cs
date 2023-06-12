using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class Tema
    {
        public int id;
        public string titulo;
        public string item;
        public int quantidade;
        public int valor;
        public Tema(int id, string titulo, string item, int quantidade, int valor)
        {
            this.id = id;
            this.titulo = titulo;
            this.item = item;
            this.quantidade = quantidade;
            this.valor = valor;
        }
        public override string ToString()
        {
            return $"id {id}, titulo {titulo}, item {item}, quantidade {quantidade}, valor {valor}";
        }
    }
}
