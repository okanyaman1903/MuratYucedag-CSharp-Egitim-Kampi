using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");


            // Yemek Kategorileri Kartı Gibi Bir Uygulama

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion


            #region String Değişkenler

            //Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Okan";
            //Console.Write(name);

            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;

            //passengerName = "Okan";
            //passengerSurname = "Yaman";
            //passengerPhone = "+90 543 678 20 46";
            //passengerEmail = "deneme@hotmail.com";
            //district = "Montmartre";
            //city = "Paris";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine("Passenger Name: " + passengerName);
            //Console.WriteLine("Passenger Surname: " + passengerSurname);
            //Console.WriteLine("Passenger Phone: " + passengerPhone);
            //Console.WriteLine("Passenger Email: " + passengerEmail);
            //Console.WriteLine("District: " + district);
            //Console.WriteLine("City: " + city);
            //Console.WriteLine();


            //passengerName = "Halil";
            //passengerSurname = "Soysal";
            //passengerPhone = "+90 593 459 18 34";
            //passengerEmail = "test@gmail.com";
            //district = "Şişli";
            //city = "İstanbul";

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Passenger: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Passenger Information: " + passengerPhone + "/" + passengerEmail);
            //Console.WriteLine("Passenger Place: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("**** Rezervasyon Kartı ****");

            #endregion


            #region Int Değişkenler

            int number = 24;
            Console.WriteLine(number);

            //Müşterinin Yediği İçtiği İçin Ödeyeceği Tutarı Hesaplayacak Bir Program (Hesap)

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger Fiyatı: " + hamburgerPrice + " Tl");
            Console.WriteLine("Kola Fiyatı: " + cokePrice + " Tl");
            Console.WriteLine("Su Fiyatı: " + waterPrice + " Tl");
            Console.WriteLine("Kızartma Fiyatı: " + friesPrice + " Tl");
            Console.WriteLine("Pizza Fiyatı: " + pizzaPrice + " Tl");
            Console.WriteLine("Limonata Fiyatı: " + lemonadePrice + " Tl");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı = " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı = " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı = " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı = " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı = " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı = " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice= totalHamburgerPrice + totalCokePrice+ totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar = " + totalPrice + " TL");





            #endregion

            Console.Read();
        }
    }
}
