using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario : iUsuario
    {
        public int codigo;

        public string nome;

        public string email;

        public string senha;


        private DateTime DataCadastro = DateTime.Now;

        public List<Usuario> usuario = new List<Usuario>();

        public string Cadastrar(Usuario novoUsuario)
        {
            usuario.Add(novoUsuario);

            return "Usuário cadastrado";
        }

        public string Deletar(Usuario novoUsuario)
        {
            usuario.Remove(novoUsuario);

            return "Usuário deletado";
        }
    }
}