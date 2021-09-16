/*
-----------------KAUAM SILVA BATISTA  - RA 210501-----------------------------
 */

using System;
using System.Globalization;

namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Pedindo para o usuário inforar os dados do produto e guardando eles nas variaveis criada no construtor Produto
            Console.WriteLine("Entre com os dados do produto;");       
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); 
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Instância do Objeto p com os parâmetros
            Produto p = new Produto(nome, preco, quantidade);

            //Escrevendo os dados do produto, pegando as respostas das variaveis da instancia p
            Console.WriteLine("Dados do produto: " + p);

            //Pedindo para o usuário informar a quantidade de produtos adicionados e chamando o método adicionar produtos com o parametro da quantidade que o usuário informou.
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            //Escrevendo os dados do produto, pegando as respostas das variaveis da instancia p
            Console.WriteLine("Dados do produto atualizados: " + p);

            //Pedindo para o usuário informar a quantidade de produtos removidos e chamando o método remover produtos com o parametro da quantidade que o usuário informou.
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            //Escrevendo os dados do produto, pegando as respostas das variaveis da instancia p
            Console.WriteLine("Dados do produto atualizados: " + p);
        }
    }
}
