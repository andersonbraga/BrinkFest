using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using BrinkFest.WinApp.ModuloCliente;
using BrinkFest.WinApp.ModuloTema;
using BrinkFest.WinApp.ModuloAluguel;

namespace BrinkFest.WinApp.Compartilhado
{
    public class ContextoDados //container
    {
        private const string NOME_ARQUIVO = "BrinkFest.json";

        public List<Cliente> clientes;
        public List<Tema> temas;
        public List<Aluguel> aluguel;

     

        public ContextoDados()
        {
            clientes = new List<Cliente>();
            temas = new List<Tema>();   
            aluguel = new List<Aluguel>();
      
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.clientes = ctx.clientes;
                    this.temas = ctx.temas;
                    this.aluguel = ctx.aluguel;
                  
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
