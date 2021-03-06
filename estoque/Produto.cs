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

        //Obtendo a variavel nome 
        public string GetNome()
        {
            return _nome;
        }

        //Definindo a variavel nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //Obtendo a variavel preço
        public double  GetPreco()
        {
            return _preco;
        }

        //Definindo a variavel preço
        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        //Obtendo a variavel quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }

        //Definindo a variavel qunatidade
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
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
