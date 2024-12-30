using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            // double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("*******Fiyat Listesi*******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice+ " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice+" ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice+" ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice+" ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice+" ₺");


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=applePrice*appleGram;
            //double orangeTotalPrice=orangePrice*orangeGram;
            //double strawbarryTotalPrice=strawberryPrice*strawberryGram;
            //double potatoTotalPrice=potatoPrice*potatoGram;
            //double tomatoTotalPrice=tomatoPrice*tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyatı: "+ applePrice + "- Gramaj: "+ appleGram+ " Toplam Tutar: " + appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyatı: "+ orangePrice + "- Gramaj: "+ orangeGram+ " Toplam Tutar: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyatı: "+ strawberryPrice + "- Gramaj: "+ strawberryGram+ " Toplam Tutar: " + strawbarryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyatı: "+ potatoPrice + "- Gramaj: "+ potatoGram+ " Toplam Tutar: " + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Domates - " + " Birim Fiyatı: "+ tomatoPrice + "- Gramaj: "+ tomatoGram+ " Toplam Tutar: " + tomatoTotalPrice + " ₺");

            //double totalShoppingPrice = appleTotalPrice + orangeTotalPrice + strawbarryTotalPrice + tomatoTotalPrice +  potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + totalShoppingPrice + "₺");


            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("****Efe Hava Yolları Yolcu Bilgileri****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentyNumber;

            //Console.Write("Yolcu Adını Girin:");
            //passangerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadını Girin:");
            //passangerSurname=Console.ReadLine();

            //Console.Write("İlç Bilgisi: ");
            //passangerDistrict=Console.ReadLine();

            //Console.Write("Yolcu Şehir: ");
            //passangerCity=Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge=Console.ReadLine();

            //Console.Write("Yolcu Kimlik No: ");
            //passangerIdentyNumber=Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("--------------");
            //Console.WriteLine("Yolcu Kimlik No: "+ passangerIdentyNumber+ "-Yolcu Ad Soyad: " + passangerName + " " + passangerSurname+ " "+passangerDistrict+ " /"+passangerCity+ " "+passangerAge );




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız tv sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine("Ödemeniz gereken tutar:" + totalPrice + "TL");






            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3;

            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz:");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());


            //double result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Not ortalamanız: "+ result);







            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.WriteLine("Lütfen Cinsiyet Seçiniz:");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            #endregion

            Console.Read();




            
        }
    }
}
