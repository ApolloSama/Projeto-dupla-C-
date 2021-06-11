using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Produto : iProduto
    {
        public int codigo;

        public string nomeProduto;

        public float preco;

        DateTime DataCadastro = DateTime.Now;

        Marca marca = new Marca();

        Usuario cadastradoPor = new Usuario();

        public List<Produto> listaDeProdutos = new List<Produto>();

        public string addProduto(Produto novoProduto)
        {
            listaDeProdutos.Add(novoProduto);
            
            return "Produto cadastrado" + novoProduto;
        }

        public string Cadastrar()
        {
            return "Produto cadastrado";
        }

        public string Deletar(Produto novoProduto)
        {
            listaDeProdutos.Remove(novoProduto);
            return "Produto deletado";
        }

    }
}