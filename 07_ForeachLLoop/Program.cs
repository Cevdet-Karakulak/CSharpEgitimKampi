using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //1.Değişken türü
            //2.Değişken adı
            //3.In
            //Liste,koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };


            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbbers = { 45, 34, 67, 37, 890, 654, 32, 12, 23, 66, 55, 79 };

            //foreach (int number in numbbers) 
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbbers = { 45, 34, 67, 37, 890, 654, 32, 12, 23, 66, 55, 79 };

            //foreach(int number  in numbbers)
            //{
            //    if(number %2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // int[] numbbers = { 45, 34, 67, 37, 890, 654, 32, 12, 23, 66, 55, 79 };

            // int total=0;

            // foreach (int i in numbbers)
            // {
            //     total+=i;
            // }
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{ 
            //    1,23,4,5,6,7,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemii Uygulaması

            Console.WriteLine("*****C# Egitim Kampi Sınav Uygullaması*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentsCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamlarını saklayacak diziler
            string[] studentsName=new string[studentsCount];
            double[] studentsExamAvg=new double[studentsCount];

            for(int i=0; i<studentsCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentsName[i] = Console.ReadLine();

                double totalExam = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsName[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz:");
                    double value=double.Parse(Console.ReadLine());
                    totalExam+= value;//notları topluyoruz
                }
                Console.WriteLine();
                studentsExamAvg[i]= totalExam/3;
            }
            
            //Sınav Ortalamaları
            for(int i=0;i<studentsCount;i++)
            {
                Console.WriteLine($"{studentsName[i]} adlı öğrencinin ortlaması: {studentsExamAvg[i]}") ;

                //Öğrencilerin ortalamasının geçiip geçmediğinin tespiti

                if (studentsExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersten kaldı");

                }
                Console.WriteLine("------------------------------");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****C# Egitim Kampi Sınav Uygullaması*****");


            #endregion

            Console.Read();
        }
    }
}

