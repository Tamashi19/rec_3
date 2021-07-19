using System;
using System.Collections.Generic;

namespace Tamashi_R_3
{
    class Program
    {
       static List<string> listaNomes=new List<string> ();
       static void ListarNomes(){
            foreach (string item in listaNomes)
                       {
                           Console.WriteLine($"Nome: {item}");
                       }

       }
        static void Main(string[] args)
        {
            bool condicao = false;




            do
            {
                Console.WriteLine(@"
|===================================|
|  Selecione uma das opções abaixo: |
|-----------------------------------|
|     1- cadastrar usuario          |
|     2- Listar usuario             |
|     0- Sair                       |
|===================================|
                ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":



                        Console.WriteLine("Coloque sua idade:");
                        int idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Coloque seu nome:");
                        string nome = Console.ReadLine();
                        if (idade < 16)
                        {

                            Console.WriteLine("Você tem só: " + idade + " anos");
                            Console.WriteLine(" Você está acompanhado por um responsavél ?: ");
                            string resposta = Console.ReadLine().ToLower();

                            if (resposta == "sim")
                            {
                                Console.WriteLine("Seu nome foi adicionado a lista de usuario ");
                                listaNomes.Add(nome); 
                            }
                            else
                            {
                                Console.WriteLine("Lamento você não atende os requisitos para continuar ");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Seu nome foi adicionado a lista de usuario ");
                            listaNomes.Add(nome);  
                        }

                            break;
                        case "2":
                        ListarNomes();
                      


                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema!!! ");
                        condicao = true;

                        break;
                    default:
                        Console.WriteLine("opção invalida ");

                        break;
                }

            } while (!condicao);
        }
    }
}
