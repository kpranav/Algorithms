using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Please enter the number of items to be sorted: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter item no {0}", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            //BubbleSort(A);
            BubbleSort_SwappedFlag(A);

            Console.Clear();
            Console.WriteLine("The sorted array :");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.ReadKey();
        }

        public static void BubbleSort(int[] A)
        {
            int temp = 0;
            int N = A.Length;
            for (int i = 0; i < N - 1; i++)
            { 
                for(int j = i+1; j< N ;j++)
                {  
                    if(A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

        }

        public static void BubbleSort_SwappedFlag(int[] A)
        {
            bool swapped = true;
            int temp = 0;
            int N = A.Length;
            int i = 0;
            while(swapped)
            {
                swapped = false;
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        swapped = true;
                    }
                } i++;
            }
        }

    public static void Bidirectional_Bubble(int[] A)
        {


        }

    }
}
