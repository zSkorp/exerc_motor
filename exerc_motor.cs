using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_motor
{
    internal class Program
    {

        static double[] motores;
        static void valorReparo()
        {
            int motor;
            double valor;

            do
            {
                Console.Write("\nInsira o número do motor a ser reparado: ");
                motor = int.Parse(Console.ReadLine());
            } while (motor < 1 || motor > 15);

            Console.Write("\nInsira o valor do reparo: ");
            valor = double.Parse(Console.ReadLine());
            Console.Clear();

            motores[motor - 1] += valor;
            Console.WriteLine("Valor registrado com sucesso!\n");
        }

        static void mostrarValores()
        {
            double total = 0;
            int i;

            Console.Clear();
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("O Motor {0} tem o reparo no valor de: R${1}", i + 1, motores[i]);
                total += motores[i];
            }

            Console.WriteLine("\nO valor total dos reparos é de: R${0}\n", total);
        }

        static void maiorReparo()

        {
            int maisCaro = 0;
            int i;
            int gasto;
            gasto = (int)motores[maisCaro];
            Console.Clear();
            for (i = 1; i < 14; i++)

                if (motores[i] > gasto)
                {
                    maisCaro = i;
                    gasto = (int)motores[i];
                }
                if (gasto == 0)
                    Console.WriteLine("Nada gasto em reparos de motores\n");
                else
                    Console.WriteLine("O motor com o reparo mais caro é: {0}º motor\n", maisCaro + 1);
        }

        static void Main(string[] args)
        {
            motores = new double[15];
            int opcao;

            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar valor de reparo");
                Console.WriteLine("2. Mostrar todos os valores");
                Console.WriteLine("3. Informar o motor com maior gasto");
                Console.Write("\nEscolha sua opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                valorReparo();
                if (opcao == 2)
                mostrarValores();
                if (opcao == 3)
                maiorReparo();

            } while (opcao != 0);
        }
    }
}