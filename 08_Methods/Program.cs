using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar (Geriye Değer Döndürmeyen)

            //Hep hazır metotlar kullandık. Console.WriteLine(), Parse() vs ... Şimdi kendi metotlarımızı oluşturacağız
            //Metot olduğunu anlamak için = ()
            //Ve sol tarafında mor renkli küp
            //Db'de ekleme yaptınız ve listenin son halini görmek istiyorsunuz listeleyi tekrar çağırdın. 
            //BİR ŞEYİ TEKRAR TEKRAR ÇAĞIRMAK
            //Void   ---- Kilit sembolü private
            //Özellikle void metotlar belirli işleri tekrardan kurtarmak için önemli bir yapı

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();   //Çağırdık burada


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod (string customerName)
            //{
            //    Console.WriteLine (customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Okan", "Yaman");

            //Parametre kullanmamızın amacı metodu tek bir kişiye bağlı olmaktan kurtarmak: Aynı metot farklı değerlerle tekrar kullanılabiliyor.
            //Parametresiz yazarsan metodun içindeki isim sabit kalır.Başka isim yazdırmak için metodun kodunu değiştirmen gerekir. Parametreli yazınca ise kodu değiştirmeden sadece gönderdiğin değeri değiştirirsin.




            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(2, 3, 5);
            //Sum(3, 4, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //Geriye bir değer, değişken değeri, bir liste, bir koleksiyon vs birçok şey döndürebiliyor.

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayran Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            //Bağlama işlemi CountryCard(x, y, z) ile yapılıyor.

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,45));
            //Console.WriteLine(Sum(50,90));
            //Console.WriteLine(Sum(30,70));
            //Console.WriteLine(Sum(100,45));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı. " + "Ortalama: " + result;

                }
            }

            Console.WriteLine(ExamResult("Okan", 90, 41, 82));
            Console.WriteLine(ExamResult("Ahmet", 30, 15, 60));

            #endregion



            Console.Read();

        }
    }
}
