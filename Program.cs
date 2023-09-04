using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" Escolha uma opção do Menu: ");
            Console.WriteLine ("1-Contagem Crescente ");
            Console.WriteLine("2-Tabuada ");
            Console.WriteLine("3-Soma de Números ");
            Console.WriteLine("4-Adivinhe o número ");
            int menu= int.Parse(Console.ReadLine());
            Console.Clear();

            if (menu == 1)
            {
                int contador = 1;
                Console.WriteLine("Você escolheu Contagem Crescente ");
                Console.Write("Digite um número: ");
                int escolha_usuario =int.Parse(Console.ReadLine());

                while(contador <= escolha_usuario)
                {
                    Console.Write(contador);
                    contador = contador + 1;
                }
            }
            else if(menu == 2)
            {
                int contador_tabuada = 1;
                Console.WriteLine("Você escolheu Tabuada");
                Console.Write("Digite um número: ");
                int escolha_usuario = int.Parse(Console.ReadLine());

                while (contador_tabuada <=10)
                {
                    
                    Console.WriteLine(escolha_usuario + " X " + contador_tabuada + " = "+ escolha_usuario*contador_tabuada);
                    contador_tabuada = contador_tabuada + 1;
                }
            }
            else if( menu == 3)
            {
                int escolha_soma_usuario;
                int contador_soma = 1;
                int soma_total = 0;

                Console.WriteLine("Você escolheu soma de números");
                Console.Write("Escolha quantos números você quer somar: ");
                escolha_soma_usuario = int.Parse(Console.ReadLine());

                while(contador_soma <= escolha_soma_usuario)
                {
                    Console.Write("Digite o " + contador_soma + " numero: ");
                    soma_total += int.Parse(Console.ReadLine());

                    contador_soma++;
                }

                Console.WriteLine("O valor total da soma foi:" + soma_total);

           
            }
            else if(menu == 4)
            {
                Console.WriteLine("Você escolheu adivinha o número! ");
                Random random = new Random();
                int numero_aleatorio=random.Next(1,101);
                int tentativa = 0;

                while(tentativa != numero_aleatorio) 
                {
                    Console.WriteLine("Digite a tentativa: ");
                    tentativa= int.Parse(Console.ReadLine());

                    if (tentativa > numero_aleatorio)
                    {
                        Console.WriteLine("O número digitado é maior que o numero sorteado! ");
                    }
                    else if (tentativa < numero_aleatorio)
                    {
                        Console.WriteLine("O número digitado é menor que o número sorteado! ");
                    }
                    else
                        Console.WriteLine("Você ganhou!");
                }
                
                

            }


         
              

                 Console.ReadKey();
            }
        }
    }

