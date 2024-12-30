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
            #region Yazdırma Komutları

            //Console.WriteLine("Hello Word");
            //Console.Write("Selam");
            //Console.WriteLine("****Yemek Kategorileri****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("****Yemek Kategorileri****");
            #endregion

            #region String Değişkenler
            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Cevdet";
            //Console.Write(name);

            //string customername;
            //string customerSurname;
            //string custumerPhone;
            //string customerEmail, district, city;

            //customername = "Efe";
            //customerSurname = "Karakulak";
            //custumerPhone = "5058232562";
            //customerEmail = "deneme@gmail.com";
            //district = "Uzunköprü";
            //city = "Edirne";


            //Console.WriteLine("****Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: "+customername+ " "+customerSurname);
            //Console.WriteLine("İletişim: " + custumerPhone);
            //Console.WriteLine("Mail: " + customerEmail);
            //Console.WriteLine("Adres: " + district+" / "+city);
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //customername = "Ayşe";
            //customerSurname = "Kara";
            //custumerPhone = "505 823 25 62";
            //customerEmail = "ababa@gmail.com";
            //district = "Çorlu";
            //city = "Tekirdağ";

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: " + customername + " " + customerSurname);
            //Console.WriteLine("İletişim: " + custumerPhone);
            //Console.WriteLine("Mail: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("****Rezervasyon Kartı****");




            //Console.WriteLine(customername);




            #endregion

            #region İnt Değişkenler
            int hamburgerPrice = 300;
            int cokePrice= 35;
            int waterPrice = 10;
            int friesPrize = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 50;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("----Hamburger: " + hamburgerPrice+ " TL");
            Console.WriteLine("----Cola: " + cokePrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine("----Limonta: " + lemonadePrice + " TL");
            Console.WriteLine("----Patates: " + friesPrize + " TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount; 
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int toplamTutar;


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
            totalCokePrice= cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrize;
            totalPizzaPrice=pizzaPrice*pizzaCount;
            totalLemonadePrice= lemonadePrice*lemonadeCount;


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesPrice+ "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");

            toplamTutar=totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice;
            
            Console.WriteLine();
            Console.WriteLine("Toplam Tutarı: " + toplamTutar + "TL");



            #endregion

            #region



            #endregion


            Console.Read();
        }
    }
}
