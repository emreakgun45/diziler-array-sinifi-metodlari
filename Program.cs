using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            System.Console.WriteLine("**** Sirasiz Dizi ****");
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            System.Console.WriteLine("**** Sirali Dizi ****");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);
            
            //Clear
            System.Console.WriteLine("**** Array Clear ****");
            //sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach(var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //Reverse
            System.Console.WriteLine("**** Array Reverse ****");

            Array.Reverse(sayiDizisi);

            foreach(var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //IndexOf
            System.Console.WriteLine("**** Array IndexOf ****"); 
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            System.Console.WriteLine("**** Array Resize ****"); 
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach(var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);
            
            
                
            


        }
    }
}
