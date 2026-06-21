using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sql veri tipleri

            //Sqldeki Veri Tipleri -------- C# Karşılığı
            //bit----bool
            //char----sabit uzunluktaki karakterler(örn:TC no)
            //decimal---- ondalıklı
            //int---int
            //varchar---veri uzunluğu sabit değilse(örn:Ayşe,Ali)
            //char---herkes için sabit uzunluktaki veriler
            //nvarchardaki n ne---Uluslararası ifade. Latin alfabesi dışındaki karakterlerde kullanılır. nvarchar varchar'a göre 2 kat fazla yer kaplıyor. Duruma göre uygun veri tipleri kullanılmalı.

            #endregion

            //Ado.net = C#'da sql verilerini kullanmak için bir çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------");


            //Sınıf,Nesne,Property(Nitelik)
            //Sınıf = properties'i/nitelikleri içerisinde barındıran yapılardır
            //Sınıflara erişim sağlamam için önce o sınıftan bir tane nesne örneği türetmem gerekiyor.
            //SqlConnection sınıfından connection isminde bir nesne örneği türetiyorum.
            //Sql bağlantısı için;
            SqlConnection connection = new SqlConnection("Data Source=PC\\OKANSQLSERVER;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            //Sorgu ifadem + Hangi Db tablosuna bağlandığımı ifade etmek için: connection
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //C# kodlarım ve Sql arasında köprü;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Verilerimi geçici belleğe almak için;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray) 
                { 
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            


            Console.Read();
        }
    }
}
