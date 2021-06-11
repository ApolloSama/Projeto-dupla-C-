using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Marca : iMarca
    {
        public int codigo;

        public string nomeMarca;

        DateTime DataCadastro = DateTime.Now;

        public List<Marca> List = new List<Marca>();

        public string addMarca(Marca novaMarca)
        {
            List.Add(novaMarca);
            
            return "Marca cadastrado" + novaMarca;
        }

        public string Cadastrar()
        {
            return "Marca cadastrada";
        }

        public string Deletar(Marca novaMarca)
        {
            List.Remove(novaMarca);
            return "Marca deletada";
        }
    }
}