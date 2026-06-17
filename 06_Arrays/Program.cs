using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //Aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemenSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[3] = 3;
            //numbers[6] = 4;
            //numbers[8] = 9;

            //Console.WriteLine(numbers[5]);   //Atama yapmadığımız indeksler default olarak 0 dönecek.

            //string[] cities = { "atina", "prag", "ankara" };
            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Mavi", "Mor", "Turuncu" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 5, 85, 858, 30, 57, 493 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'c', '%', '/' };

            //for (int i = 0;i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0]; 

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            //int[] numbers = { 45, 85, 52, 41, 86, 22, 10, 35 };
            //Array.Sort(numbers);

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Reverse() Diziyi olduğu gibi ters yazdırıyor.


            //string[] customers = { "Ali", "Buse", "Şengül", "Ahmet" };

            //int index = Array.IndexOf(customers, "Ahmet");     indexin numarasına erişebiliyoruz.
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 45, 86, 98 };

            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elamanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Dizi Oluşturmak için Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Dolar sembolü bir çift tırnak içerisinde parametresel ifadeler kullanmama olanak sağlar. Çift tırnakla yanında artılar kullanmadan istediğim gibi, çift tırnak bütünlüğünü bozmadan kullanabilmek adına bana kolaylık sağlayan sembol.

            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 21, 23, 45, 69, 78, 76, 74, 85 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion



            Console.Read();
        }
    }
}
