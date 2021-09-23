using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace estoque
{
    class Produto
    {
        //Criando a variavel Nome do produto
        private string _nome;
        //Criando a variavel Preco do produto
        private double _preco;
        //Criando a variavel Quantidade do produto
        private int _quantidade;

        //Criando um construtor vázio
        public Produto()
        {

        }

        //Criando construtor Produto e passando como parametro variaveis nome, preco e quantidade
        public Produto  (string nome, double preco, int quantidade)
        {
            //Igualando as variaveis da classe Produto com as variaveis do método Produto
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Declarando a propriedade de get (obter) and set (definir) da variavel Nome
        public string Nome{
            get {return _nome; }
            set{
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Declarando a propriedade get (obter) da variavel Preco
        public double Preco
        {
            get { return _preco;  }
        }

        //Declarando a propriedade get (obter) da variavel Preco 
        public int Quantidade
        {
            get { return _quantidade; }
        } 

        //Criando o método´para retornas o valor total do produto em estoque
        public double ValorTotalEmEstoque() 
        { 
            return _preco * _quantidade; 
        }

        //Criando método para adicionar a quantidade (que o usuario quiser) de produtos na variavel Quantidade
        public void AdicionarProduto(int quantidade) 
        { 
            _quantidade += quantidade; 
        }

        //Criando método para remover a quantidade (que o usuario quiser) de produtos na variavel Quantidade
        public void RemoverProduto(int quantidade) 
        { 
            _quantidade = _quantidade - quantidade; 
        }

        //retornando os dados das variaveis da classe Produto
        public override string ToString() 
        { 
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }
    }
}
