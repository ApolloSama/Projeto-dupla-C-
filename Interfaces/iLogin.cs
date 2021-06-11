using System;

namespace Projeto_de_Produtos.Interfaces
{
    public interface iLogin
    {
        void Login()
        {
            Console.WriteLine(@"
            Seja bem vindo ao cadastrador de marcas 2000, para acessar o sistema você deve logar.
            Aperte o número 1 se deseja logar 
            Caso contrário aperte o 2 para deslogar.

            1. Logar
            2. Deslogar
            ");
        }

        string Logar()
        {
            return "Usuário foi logado";
        }

        string Deslogar()
        {
            return "Usuário deslogado";
        }
    }
}