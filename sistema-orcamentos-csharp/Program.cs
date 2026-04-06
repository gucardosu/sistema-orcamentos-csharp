using sistema_orcamentos_csharp.Models;
using System;

namespace sistema_orcamentos_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Criamos o orçamento (ele já cria o cliente dentro dele automaticamente!)
            Orcamento meuOrcamento = new Orcamento();

            // 2. Preenchemos os dados do Orçamento
            meuOrcamento.Pedido = 101;
            meuOrcamento.Problema = "Computador não liga";
            meuOrcamento.descricaoOrcamento = "Troca da fonte de alimentação";

            // 3. Preenchemos os dados do Cliente acessando ele DENTRO do orçamento
            meuOrcamento.cliente.IdCliente = "CLI-001";
            meuOrcamento.cliente.Nome = "Gustavo";
            meuOrcamento.cliente.Idade = 25;

            // 4. Chamamos o método que você criou para imprimir tudo na tela!
            meuOrcamento.GerarOrcamento();

            // Evita que a tela do console feche sozinha muito rápido
            Console.ReadLine();
        }
    }
}