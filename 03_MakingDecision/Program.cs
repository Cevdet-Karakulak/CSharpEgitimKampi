using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;

            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara"& country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış veri girildi");
            //}

            //int sayi;
            //Console.WriteLine("Sayıyı girniz:");
            //sayi=int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result="";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam3 + exam2 + exam1) / 3;
            //Console.WriteLine("Ortalama: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    Console.WriteLine("Sonuç vasat");
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    Console.WriteLine("Sonuç orta");
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    Console.WriteLine("Sonuç iyi");
            //}
            //if (avarage > 84 & avarage <= 100)
            //{
            //    Console.WriteLine("Sonuç mükemmel");
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city=="bursa"|city=="edirne")
            //    {
            //    Console.WriteLine("Şehir mevcut");
            //    }

            //else
            //    { Console.WriteLine("Şehir mevcut değil");
            //    }

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: "+result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz:");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'g' |team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team =='f'| team=='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team=='b' | team=='B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion yapılar

            #region Örnek Proje Uygulaması


            //Console.WriteLine("*****Eğitim Kampı Restoran*****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını Görmek İstediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("3- Kelle Paça Çorbası");
            //    Console.WriteLine("4- İşkembe Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Bol Malzemos");
            //    Console.WriteLine("4- Sucuksever");
            //    Console.WriteLine("5- Avokadolu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Su");
            //    Console.WriteLine("3- Meyve Suyu");
            //    Console.WriteLine("4- Ayran");
            //    Console.WriteLine("5- İce Tea");
            //    Console.WriteLine("----------İçecekler----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Tirileçe");
            //    Console.WriteLine("3- Tiramisu");
            //    Console.WriteLine("4- Sütlaç");
            //    Console.WriteLine("5- Künefe");
            //    Console.WriteLine("----------Tatlılar----------");

            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result=number1 - number2; 
            //        Console.WriteLine("Fark: "+result);
            //        break;

            //    case '*':
            //        result=number1 * number2; 
            //        Console.WriteLine("Çarpım: "+result);
            //        break;

            //    case '/':
            //        result=number1 / number2; 
            //        Console.WriteLine("Bölüm: "+result);
            //        break;


        }

        #endregion



        Console.Read();
        }
    }
}
