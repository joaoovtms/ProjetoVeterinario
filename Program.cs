using System;
using System.IO;

namespace Veterinario 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            while (opcao == "")
            {
                MenuPrincipal();
                opcao = Entrada();

                switch (opcao)
                {
                    case "1":                
                        MenuCadastro();
                        opcao = Entrada();
                        switch (opcao)
                        {
                            case "1":
                                Console.Clear();
                                Cabecalho();
                                Console.Write("Insira o nome do cliente: ");
                                string nome = Entrada();
                                Console.Write("Insira a idade do cliente: ");
                                int idade = int.Parse(Entrada());
                                Console.Write("Insira a Data de Nascimento do cliente: ");
                                DateTime datanascimento = DateTime.Parse(Entrada().ToString());
                                Console.Write("Insira o CPF do cliente: ");
                                string cpf = Entrada();
                                Pessoas pessoa = new Cliente(nome, idade, datanascimento, cpf);

                                using(StreamWriter writer = File.AppendText(@"C:\Users\User\Documents\EXs\Veterinario\banco_dados\Clientes"))
                                {
                                    string newLine = string.Format("{0};{1};{2};{3};{4}", pessoa.ID, pessoa.Nome, pessoa.Idade, pessoa.DataNascimento, pessoa.CPF);
                                    writer.WriteLine(newLine);
                                }
                                break;

                            case "2":
                                Console.Clear();
                                Cabecalho();
                                Console.Write("Insira o nome do funcionario: ");
                                nome = Entrada();
                                Console.Write("Insira a idade do funcionario: ");
                                idade = int.Parse(Entrada());
                                Console.Write("Insira a data de nascimento do funcionario: ");
                                datanascimento = DateTime.Parse(Entrada().ToString());
                                Console.Write("Insira o CPF do funcionario: ");
                                cpf = Entrada();
                                pessoa = new Funcionarios(nome, idade, datanascimento, cpf);

                                using (StreamWriter writer = File.AppendText(@"C:\Users\User\Documents\EXs\Veterinario\banco_dados\Funcionarios"))
                                {
                                    string newLine = string.Format("{0};{1};{2};{3}", pessoa.Nome, pessoa.Idade, pessoa.DataNascimento, pessoa.CPF);
                                    writer.WriteLine(newLine);
                                }
                                break;

                            case "3":
                                Console.Clear();
                                Cabecalho();
                                Console.Write("Qual animal deseja cadastrar? (Gato ou cachorro) ");
                                string animal = Entrada();

                                if (animal.ToLower() == "gato")
                                {
                                    Console.Write("Insira o nome do gato: ");
                                    nome = Entrada();
                                    Console.Write("Insira a idade do gato: ");
                                    idade = int.Parse(Entrada());
                                    Console.Write("Insira o porte do gato (Pequeno, Medio ou Grande): ");
                                    string porte = Entrada();
                                    Animais animais = new Gato(nome, idade, porte);

                                    using (StreamWriter writer = File.AppendText(@"C:\Users\User\Documents\EXs\Veterinario\banco_dados\Gatos"))
                                    {
                                        string newLine = string.Format("{0};{1};{2}", animais.Nome, animais.Idade, animais.Porte);
                                        writer.WriteLine(newLine);
                                    }
                                }
                                else
                                {
                                    Console.Write("Insira o nome do cachorro: ");
                                    nome = Entrada();
                                    Console.Write("Insira a idade do cachorro: ");
                                    idade = int.Parse(Entrada());
                                    Console.Write("Insira o porte do cachorro (Pequeno, Medio ou Grande): ");
                                    string porte = Entrada();
                                    Animais animais = new Cachorro(nome, idade, porte);

                                    using (StreamWriter writer = File.AppendText(@"C:\Users\User\Documents\EXs\Veterinario\banco_dados\Cachorros"))
                                    {
                                        string newLine = string.Format("{0};{1};{2}", animais.Nome, animais.Idade, animais.Porte);
                                        writer.WriteLine(newLine);
                                    }
                                }
                                break;
                        }
                        break;


                    case "2":
                
                        MenuPedido();
                        opcao = Entrada();
                        switch (opcao)
                        {
                            case "1":
                                break;
                        }
                        break;

                    case "3":
                        break;


                    default:
                        return;
                
                }
            
                opcao = "";
            }
            
        }

        static void Cabecalho()
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::  OsDoisAnimais  :::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }

        static void MenuPrincipal()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine(":::::::::::::| Escolha a opção desejada |::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::| 1 - Cadastrar Cliente/ Funcionario/ Animal    |:::");
            Console.WriteLine(":::| 2 - Realizar pedido (caso já possua cadastro) |:::");
            Console.WriteLine(":::| 3 - Imprimir Ordem de Serviço                 |:::");
            Console.WriteLine(":::| 4 - Finalizar                                 |:::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");            
        }

        static void MenuCadastro()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine(":::::::::::::| Escolha a opção desejada |::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::| 1 - Cadastrar Cliente                         |:::");
            Console.WriteLine(":::| 2 - Cadastrar Funcionario                     |:::");
            Console.WriteLine(":::| 3 - Cadastrar Animal                          |:::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }

        static void MenuPedido()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine(":::::::::::::| Escolha a opção desejada |::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::| 1 - Inserir Cliente                           |:::");
            Console.WriteLine(":::| 2 - Inserir Funcionario                       |:::");
            Console.WriteLine(":::| 3 - Inserir Animal                            |:::");
            Console.WriteLine(":::| 4 - Inserir serviço a ser prestado            |:::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }

        static string Entrada()
        {
            string texto = Console.ReadLine();
            return texto == "" || texto == null ? "0" : texto;
        }
    }
}