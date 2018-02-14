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
            int[] dizi = new int[] { 15, 5, 3, 21, 12, 4, 6 };
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
