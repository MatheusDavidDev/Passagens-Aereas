using System;

namespace Aula_26._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracao de variaveis

            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            //Menu
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-----Sistema de passagens aereas-----");
            Console.WriteLine("-------------------------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);

            } while (!senhaValida);

            //Criar o menu
            
            int escolha;
            int contador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Seleciona uma opcao");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        //Cadastrar a passagem
                        string resposta;
                        
                        do
                        {
                            if(contador<5)
                            {
                                Console.WriteLine($"Digite o nome do {contador+1} Passageiro");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite a origem do {contador+1} Passageiro");
                                origem[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite o destino do {contador+1} Passageiro");
                                destino[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite a data do voo do {contador+1} Passageiro");
                                data[contador] = Console.ReadLine();
                                contador++;
                            }else{
                                Console.WriteLine("Limite excedido de passagens");
                            }

                                Console.WriteLine("Gostaria de cadastrar um novo passageiro? s/n");
                                resposta = Console.ReadLine();
                        } while (resposta == "s");

                        break;

                    case 2:
                        //Listar as passagens
                                for (var i = 0; contador < 5; i++)
                                {
                                    Console.WriteLine($"Passageiro {nomes[i]}");
                                }
                        break;
                    case 0:
                        //Sair
                        Console.WriteLine("Obrigado! Volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
                
            } while (escolha != 0);



            //Funcoes
            bool EfetuarLogin(string senha){

                if (senha == "123456")
                {
                    Console.WriteLine("Achei");
                    return true;
                }else
                {
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }
        }
    }
}
