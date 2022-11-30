using System;
using System.Globalization;

namespace Deposito
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
           
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtdade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtdade);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtdade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtdade);
            Console.WriteLine();
            Console.WriteLine("Dados atusalizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Total de produtos em estoque: " + p.Quantidade);


        }
    }
}