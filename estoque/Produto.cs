﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace estoque
{
    class Produto
    {
        //Criando a variavel Nome do produto
        public string Nome;
        //Criando a variavel Preco do produto
        public double Preco;
        //Criando a variavel Quantidade do produto
        public int Quantidade;

        //Criando método Produto e passando como parametro variaveis nome, preco e quantidade
        public Produto  (string nome, double preco, int quantidade)
        {
            //Igualando as variaveis da classe Produto com as variaveis do método Produto
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Criando um construtor vázio
        public Produto()
        {

        }

        //Criando o método´para retornas o valor total do produto em estoque
        public double ValorTotalEmEstoque() 
        { 
            return Preco * Quantidade; 
        }

        //Criando método para adicionar a quantidade (que o usuario quiser) de produtos na variavel Quantidade
        public void AdicionarProduto(int quantidade) 
        { 
            Quantidade += quantidade; 
        }

        //Criando método para remover a quantidade (que o usuario quiser) de produtos na variavel Quantidade
        public void RemoverProduto(int quantidade) 
        { 
            Quantidade = Quantidade - quantidade; 
        }

        //retornando os dados das variaveis da classe Produto
        public override string ToString() 
        { 
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }
    }
}