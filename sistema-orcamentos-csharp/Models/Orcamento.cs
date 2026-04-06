using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_orcamentos_csharp.Models
{
    internal class Orcamento
    {
        public Cliente cliente = new Cliente();

        public int Pedido;
        public string Problema;
        public string descricaoOrcamento;


        public void GerarOrcamento()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Id do Cliente: " + cliente.IdCliente);
            Console.WriteLine("Cliente: " + cliente.Nome + "Idade: " + cliente.Idade);
            Console.WriteLine("Pedido: " + Pedido);
            Console.WriteLine("Problema: " + Problema);
            Console.WriteLine(descricaoOrcamento);
            Console.WriteLine("--------------------");

        }
    }
}
