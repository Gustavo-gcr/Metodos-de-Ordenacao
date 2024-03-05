using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_11
{
    internal class Program
    {

        static int[] Copia(int[] vet)

        {

            int[] vetcopia = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)

            {

                vetcopia[i] = vet[i];

            }

            return vetcopia;

        }

        static void Selecao(int[] vet, string ordenar)

        {

            if (ordenar == "crescente")

            {

                for (int i = 0; i < vet.Length - 1; i++)

                {

                    int menor = i;

                    for (int j = (i + 1); j < vet.Length; j++)

                    {

                        if (vet[menor] > vet[j])

                        {

                            menor = j;

                        }

                    }

                    int temp = vet[i];

                    vet[i] = vet[menor];

                    vet[menor] = temp;

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }





            }

            else if (ordenar == "decrescente")

            {

                for (int i = 0; i < vet.Length - 1; i++)

                {

                    int maior = i;

                    for (int j = (i + 1); j < vet.Length; j++)

                    {

                        if (vet[maior] < vet[j])

                        {

                            maior = j;

                        }

                    }

                    int temp = vet[i];

                    vet[i] = vet[maior];

                    vet[maior] = temp;

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }

            }

            else

                Console.WriteLine("Palavra inválida");



        }

        static void Bolha(int[] vet, string ordenar)

        {

            if (ordenar == "crescente")

            {

                for (int i = (vet.Length - 1); i > 0; i--)

                {

                    for (int j = 0; j < i; j++)

                    {

                        if (vet[j] > vet[j + 1])

                        {



                            int temp = vet[j];

                            vet[j] = vet[j + 1];

                            vet[j + 1] = temp;

                        }

                    }

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }

            }



            else if (ordenar == "decrescente")

            {

                for (int i = (vet.Length - 1); i > 0; i--)

                {

                    for (int j = 0; j < i; j++)

                    {

                        if (vet[j] < vet[j + 1])

                        {



                            int temp = vet[j];

                            vet[j] = vet[j + 1];

                            vet[j + 1] = temp;

                        }

                    }

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }

            }

            else

                Console.WriteLine("Palavra inválida");



        }

        static void Insercao(int[] vet, string ordenar)

        {

            if (ordenar == "crescente")

            {



                for (int i = 1; i < vet.Length; i++)

                {

                    int tmp = vet[i];

                    int j = i - 1;



                    while ((j >= 0) && (vet[j] > tmp))

                    {

                        vet[j + 1] = vet[j];

                        j--;

                    }

                    vet[j + 1] = tmp;

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }

            }

            else if (ordenar == "decrescente")

            {



                for (int i = 1; i < vet.Length; i++)

                {

                    int tmp = vet[i];

                    int j = i - 1;



                    while ((j >= 0) && (vet[j] < tmp))

                    {

                        vet[j + 1] = vet[j];

                        j--;

                    }

                    vet[j + 1] = tmp;

                }

                for (int i = 0; i < vet.Length; i++)

                {

                    Console.Write(vet[i] + "\n");

                }

            }

            else

                Console.WriteLine("Palavra inválida");



        }

        static void QuickSort(int[] vet, string ordenar, int esq, int dir)
        {
            if (ordenar == "crescente")
            {
                if (esq < dir)
                {
                    for(int i=0; i < vet.Length; i++)
                    {
                        Console.WriteLine(vet[i]);
                    }
                    int part = Particao(vet, esq, dir);
                    QuickSort(vet, ordenar, esq, part - 1);
                    QuickSort(vet, ordenar, part + 1, dir);
                }
            }
            else if (ordenar == "decrescente")
            {
                if (esq < dir)
                {
                    for (int i = 0; i < vet.Length; i++)
                    {
                        Console.WriteLine(vet[i]);
                    }
                    int part = Particao(vet, esq, dir);
                    QuickSort(vet, ordenar, esq, part - 1);
                    QuickSort(vet, ordenar, part + 1, dir);
                }
            }
            else
            {
                Console.WriteLine("Palavra inválida");
            }
        }

        static int Particao(int[] vet, int inicio, int fim)
        {
            int pivot = vet[fim];
            int part = inicio - 1;

            for (int i = inicio; i < fim; i++)
            {
                if (vet[i] < pivot)
                {
                    part++;
                    Troca(vet, part, i);
                }
            }

            part++;
            Troca(vet, part, fim);
            return part;
        }

        static void Troca(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }
        static void Main(string[] args)

        {



            int[] vetcopia;

            string ordenar;

            int[] vet = new int[10];

            Console.WriteLine("Criando um vetor aleatório");

            Random numAleatorio = new Random(200);



            for (int i = 0; i < vet.Length; i++)

            {

                Console.WriteLine(vet[i] = numAleatorio.Next(1, 200));

            }



            int num;

            Console.WriteLine("Escolha um número para ser realizado\n1) Algoritmo Seleção\n2) Algoritmo da Bolha(Bubblesort)\n3) Algoritmo de Inserção\n4) Quicksort\n5)Sair");

            num = int.Parse(Console.ReadLine());

            do

            {

                switch (num)

                {

                    case 1:

                        Console.WriteLine("Escolha se a ordenação será crescente ou decrescente");

                        ordenar = Console.ReadLine();

                        ordenar = ordenar.ToLower();

                        vetcopia = Copia(vet);

                        Selecao(vet, ordenar);



                        break;



                    case 2:

                        Console.WriteLine("Escolha se a ordenação será crescente ou decrescente");

                        ordenar = Console.ReadLine();

                        ordenar = ordenar.ToLower();

                        vetcopia = Copia(vet);

                        Selecao(vet, ordenar);



                        break;

                    case 3:

                        Console.WriteLine("Escolha se a ordenação será crescente ou decrescente");

                        ordenar = Console.ReadLine();

                        ordenar = ordenar.ToLower();

                        vetcopia = Copia(vet);

                        Selecao(vet, ordenar);



                        break;



                    case 4:

                        Console.WriteLine("Escolha se a ordenação será crescente ou decrescente");

                        ordenar = Console.ReadLine();

                        ordenar = ordenar.ToLower();

                        vetcopia = Copia(vet);

                        Selecao(vet, ordenar);



                        break;

                    default:

                        Console.WriteLine("Numero inválido");

                        break;

                }







                Console.WriteLine("Escolha um número para ser realizado\n1) Algoritmo Seleção\n2) Algoritmo da Bolha(Bubblesort)\n3) Algoritmo de Inserção\n4) Quicksort\n5)Sair");

                num = int.Parse(Console.ReadLine());

            } while (num != 5);



            Console.ReadKey();

        }

    }

}



