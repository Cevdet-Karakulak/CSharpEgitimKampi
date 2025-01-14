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
            #region Void Metotlar
            //()
            //Geriye değer döndürmeyen metotlar
            //Customer-->Listele,ekle, sili güncelle

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Veli Yıldız");
            //    Console.WriteLine("Murat Yıldız");
            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void sum() 
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}  
            //sum();



            #endregion

            #region Geriye Döndürmeyen String Parametreli Metotlar
            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Mehmet Yıldız");

            //void customerCArd(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //customerCArd("Ali", "Veli");
            //customerCArd("Ayşe", "Fatma");


            #endregion

            #region Geriye Döndürmeyen Int Parametreli Metotlar
            //void sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2+number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 3, 7);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name+ " "+ surname;

            //}
            //Console.WriteLine(studentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string CountryCard(string CountryName, string capital, string flagcolor)
            //{
            //    string cardInfo="Ülke: "+CountryName+" "+"Başkent: "+capital+" "+"Bayrak rengi: "+flagcolor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak rengiini giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int sum(int number1, int number2) 
            //{
            //    int result=number1 + number2;
            //    return result;


            //}
            //Console.WriteLine(sum(98, 45));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));
            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2,int exam3) 
            //{
            //    int result=(exam1 + exam2+exam3)/3;
            //    if(result >= 50) 
            //    {
            //        return student + " isimli öğrenci sınavı geçti "+ "Ortalama: "+ result;
            //    }
            //    else 
            //    {
            //        return student + " isimli öğrenci sınadan kaldı " + "Ortalama: " + result;
                    
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 45));

            #endregion

            Console.Read();
        }
    }
}
