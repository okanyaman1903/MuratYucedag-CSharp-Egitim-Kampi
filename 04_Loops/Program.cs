using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bazı işlemlerin tekrar etmesi gerek ve bu tekrar etme sürecinde bazı işlemler gerçekleşecek.

            #region For Döngüsü

            //For (x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;

            //for(i=1; i<=5; i++) 
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i<=20;  i++)  //1 den 20 ye kadar olan sayıları listeler.
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i<= 10;  i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("----------------------");
            //Console.WriteLine(totalValue);

            //int count = 0; (Burdan sonra tekrar et yine) (Bir ara döngüler kısmındaki örnekleri tekrar et)
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //1-2-4-8-16... 24 saatin sonunda kaç bakteri. Saatte bir ikiye bölünüyorlar.

            //int bacterium = 1; //Başlangıçta tek bakteri var.

            //for (int i = 1; i <= 24; i++) //Saat
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(bacterium);

            #endregion

            #region While Döngüsü

            //Şart Sağlandığı Müddetçe Anlamı Taşır
            //While(Şart)
            //{
            //işlemler
            //}

            //Şart işlem sağlandığı müddetçe anlamı taşıyor.

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion



            Console.Read();
        }
    }
}
