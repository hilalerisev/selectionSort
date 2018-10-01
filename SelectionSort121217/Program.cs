using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort121217
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı gireceksiniz?");
	    int count = int.Parse(Console.ReadLine());
	    int dizi[] = new int[count];

	    for(int i = 0; i < count; i++)
	    {
		    Console.Write(i + 1 + ". sayıyı giriniz:");
		    dizi[i] = int.Parse(Console.ReadLine());
	    }

            selectionSort(dizi);
            print(dizi);
        }
        public static void print(int []dizi)
        {
            for(int i=0; i<dizi.Length;i++)
            {
                Console.Write(dizi[i]+" ");
            }
        }
        public static void selectionSort(int []d)
        {
            for(int i=0;i<d.Length;i++)
            {
                int min = i;
                for(int j=i+1;j<d.Length;j++)
                {
                    if (d[j] < d[min])
                        min = j;
                }
                int gecici = d[i];
                d[i] = d[min];
                d[min] = gecici;

            }
        }
    }
}
