using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri
            //2,4,6,7
            //sarı,kırmızı,mavi,yeşil
            //adana,ankara,istanbul,edirne
            //Değişken türü[] Dizi Adı=new Değiişken türü [elman sayısı]
            //string[] colors = new string[4];
            //colors[0] = "Lacivert";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Kırmızı";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //{
            //    cities[0] = "Milano";
            //    cities[1] = "Budapeşte";
            //    cities[2] = "Lyon";
            //    cities[3] = "Kahire";
            //    cities[4] = "Üsküp";
            //    Console.WriteLine(cities[5]);

            //}

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[9]);

            //string[] cities = { "Prag", "Roma", "Paris", "Atina" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elamanları Listeleme
            //string[] colors = { "sarı", "lacivert", "mavi", "yeşiil", "beyaz", "kırmızı" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 75, 125, 635, 488, 522, 7456, 2365, 1120,96 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber= myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber) 
            //    { 
            //        maxNumber = myArray[i]; 
            //    } 
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "veli", "osman", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 23, 47, 87, 65, 234, 98, 675 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 23, 47, 87, 65, 234, 98, 675 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 45, 23, 47, 87, 65, 234, 98, 675 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ece", "cevdet", "ahmet", "mehmet" };
            //int index = Array.IndexOf(customers, "cevdet");
            //Console.WriteLine(index);

            //int[] numbers = { 45,32,56,72,87,99,232,123,6};
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+numbers.Max()+" Dizinin en küçük elamanı: "+numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] citiies = new string[5];
            //for (int i = 0; i < citiies.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehir Giriniz: ");
            //    citiies[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for (int i = 0;i < citiies.Length; i++)
            //{
            //    Console.WriteLine(citiies[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar"); ;

            for (int i = 0; i < numbbers.Length; i++)
            {
                if (numbbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbbers[i]);
                }
            }
                Console.WriteLine("Tek Sayılar");
                for (int i = 0; i < numbbers.Length; i++)
                {
                    if (numbbers[i] % 2 == 1)
                    {
                        Console.WriteLine(numbbers[i]);
                    }
                }


            #endregion

            Console.Read();
        }
    }
}
