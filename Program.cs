using System;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login();

            Usuario u = new Usuario();

            l.FazerLogin();
        }
    }
}
