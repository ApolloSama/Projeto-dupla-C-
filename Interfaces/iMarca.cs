using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface iMarca
    {

        string addMarca(Marca novaMarca)
        {            
            return "Marca cadastrado" + novaMarca;
        }
        string Cadastrar()
        {
            return "Marca cadastrada";
        }

        string Deletar(Marca novaMarca)
        {
            return "Marca deletada";
        }
    }
}