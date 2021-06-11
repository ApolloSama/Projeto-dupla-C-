using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface iProduto
    {

        string addProduto(Produto novoProduto)
        {            
            return "Produto cadastrado" + novoProduto;
        }

        string Cadastrar()
        {
            return "Sua conta foi cadastrada";
        }

        string Deletar(Produto novoProduto)
        {
            return "Produto deletado";
        }

    }
}
