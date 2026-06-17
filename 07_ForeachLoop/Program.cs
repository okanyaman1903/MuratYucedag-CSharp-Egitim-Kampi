using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //4 Parametre alır. Bunlar;
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi adı

            //string[] cities = { "Madrid, Paris, Roma, New York, Viyana" };
            //foreach (string city in cities)  //city değişkeni cities'in içine gidip sırasıyla bütün değerleri üzerine alacak
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 1, 2, 7585, 38, 854, 10, 400, 954 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 48, 8404, 484, 94, 944, 10, 490, 14 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i; //Total'a i den gelen değeri ekleyeceğim.
            //}
            //Console.WriteLine(total);


            //Listeler bir koleksiyon öğesidir.
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alıyoruz.
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine();
            }


            #endregion

            Console.Read();
        }
    }
}
