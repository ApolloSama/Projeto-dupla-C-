using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface iUsuario
    {

        string Cadastrar(Usuario novoUsuario)
        {
            return "Usuário cadastrado" + novoUsuario;
        }

        string Deletar()
        {
            return "Usuário deletado";
        }
    }
}