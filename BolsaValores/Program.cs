/* Programa deve calcular o preco medio das açoes compradas
 e caso o valor da açao atual for menor do que o preco medio das acoes ja adiquiridsa,
  deve retornar a quantidade de acoes que devem ser compradas, para que o preco medio
  se iguale ao valor da acao atual.

 Autor: Enio Santinelli Filho
*/

using System;

namespace Bolsa
{
    class Program 
    {
        static void Main(string[] args)
        {
             double quantidade, precoMPago, precoMedioAtual;
             double total;


            Console.Clear();
            Console.WriteLine("Menu para o cálculo da quantidade de açöes que devem ser adquridas");
            Console.WriteLine();
            Console.WriteLine("Nome da açao: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantidade de Açoes, que você possui:");
            quantidade = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Preco Medio Pago: ");
            precoMPago = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Preco Medio Atual :");
            precoMedioAtual = Convert.ToDouble(Console.ReadLine());

            

            total = (quantidade * precoMedioAtual) / precoMPago;

            Console.Write("Para igualar o preco atual, voce deve comprar " + nome + " no total de " + total + " acoes");
            
            // alterando


            

            

        }

    }

}



