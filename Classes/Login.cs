using System;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Login : iLogin
    {
        private bool logado = false;

        private bool sair = false;

        private string escolha;

        Usuario usuarioEncontrado = null;
        Usuario u = new Usuario();
        Produto p = new Produto();
        Marca m = new Marca();

        public void FazerLogin()
        {
            do
            {
                Console.WriteLine(@"Bem vindo ao cadastrador 3000 de marcas e produtos! Para acessar o sistema, selecione as seguintes opções:
                    1. Cadastrar
                    2. Logar
                    3. Deslogar
                    4. Deletar usuário
                    5. Sair
                    ");

                escolha = (Console.ReadLine());

                switch (escolha)
                {
                    case "1":
                        Usuario novo = new Usuario();
                        Console.WriteLine("Crie o seu nome");
                        novo.nome = Console.ReadLine();
                        Console.WriteLine("Digite o seu Email");
                        novo.email = Console.ReadLine();
                        Console.WriteLine("Crie a sua senha");
                        novo.senha = Console.ReadLine();
                        novo.codigo += 1;

                        Console.WriteLine(u.Cadastrar(novo));

                        foreach (var item in u.usuario)
                        {
                            Console.WriteLine($"{item.email} {item.senha}");
                        }
                        break;


                    case "2":
                        do
                        {
                            Console.WriteLine("Digite o seu Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Digite a sua senha");
                            string senha = Console.ReadLine();

                            usuarioEncontrado = u.usuario.Find(x => x.email == email && x.senha == senha);

                            if (usuarioEncontrado != null)
                            {
                                logado = true;
                                Console.WriteLine(Logar());
                                Console.WriteLine($@"
                                Se deseja cadastrar um produto, aperte 1,
                                se deseja cadastrar uma marca, aperte 2,
                                se deseja listar um produto aperte 3,
                                se deseja listar uma marca aperte 4,
                                se deseja deletar um produto aperte 5,
                                se deseja deletar uma marca aperte 6
                                se deseja sair aperte 7.
                                ");
                            }
                            else
                            {
                                Console.WriteLine("email ou senha errados, tente novamente");
                            }

                            escolha = (Console.ReadLine());

                            switch (escolha)
                            {
                                case "1":
                                    Console.WriteLine("Qual produto você deseja cadastrar?");
                                    string nomeProduto = Console.ReadLine();
                                    Console.WriteLine("Qual será o preço do seu produto?");
                                    float preço = float.Parse(Console.ReadLine());
                                    p.codigo++;

                                    Produto novoP = new Produto();

                                    p.addProduto(novoP);
                                    Console.WriteLine(p.addProduto(novoP));
                                    Console.WriteLine(p.Cadastrar());
                                    break;


                                case "2":
                                    Console.WriteLine("Qual é o nome da sua marca?");
                                    string nomeMarca = Console.ReadLine();
                                    m.codigo++;

                                    Marca novaM = new Marca();

                                    m.addMarca(novaM);
                                    Console.WriteLine(m.addMarca(novaM));
                                    Console.WriteLine(m.Cadastrar());
                                    break;


                                case "3":
                                    foreach (var item in p.listaDeProdutos)
                                    {
                                        Console.WriteLine($"Nome: {p.nomeProduto} Preço: {p.preco}");
                                    }

                                    Usuario cadastradoPor = usuarioEncontrado;
                                    Console.WriteLine(usuarioEncontrado);
                                    break;

                                case "4":
                                    foreach (var item in m.List)
                                    {
                                        Console.WriteLine($"Nome: {m.nomeMarca}");
                                    }

                                    cadastradoPor = usuarioEncontrado;
                                    Console.WriteLine(usuarioEncontrado);
                                    break;

                                case "5":
                                    Console.WriteLine("Qual produto deseja deletar?");
                                    nomeProduto = Console.ReadLine();

                                    Produto produtoEncontrado = p.listaDeProdutos.Find(x => x.nomeProduto == nomeProduto);
                                    Console.WriteLine(p.Deletar(produtoEncontrado));
                                    break;


                                case "6":
                                    Console.WriteLine("Qual marca deseja deletar?");
                                    nomeMarca = Console.ReadLine();

                                    Marca marcaEncontrada = m.List.Find(x => x.nomeMarca == nomeMarca);
                                    Console.WriteLine(m.Deletar(marcaEncontrada));
                                    break;

                                case "7":
                                    Console.WriteLine("Você realmente deseja sair? (S/N)");
                                    escolha = Console.ReadLine().ToLower();
                                    if (escolha == "s"){
                                        Console.WriteLine("Obrigado por usar nosso site");
                                    }
                                    break;

                                default:
                                    break;
                            }
                        } while (escolha != "s");
                        break;


                    case "3":
                        Console.WriteLine("Você realmente deseja deslogar?");
                        Console.WriteLine(Deslogar());
                        escolha = (Console.ReadLine());

                        break;


                    case "4":
                        Console.WriteLine("Qual Usuario deseja deletar?");
                        string nome = Console.ReadLine();

                        usuarioEncontrado = u.usuario.Find(x => x.nome == nome);
                        Console.WriteLine(u.Deletar(usuarioEncontrado));
                        break;

                    case "5":
                        Console.WriteLine("Você realmente deseja sair? (S/N)");
                        escolha = (Console.ReadLine().ToLower());

                        if (escolha == "s")
                        {
                            Console.WriteLine("Obrigado por escolher nosso site, até uma próxima.");
                            sair = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (escolha != "s");
        }

        public string Logar()
        {
            return "Usuário foi logado";
        }

        public string Deslogar()
        {
            return "Usuário deslogado";
        }
    }
}