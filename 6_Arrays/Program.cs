using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace arrays_diziler__6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region temel dizi öğeleri

            // değişken türü [] dizi adı=new değikentürü[eleman sayısı]

            //string[] colors = new string[4];


            //colors[0] = "beyaz";
            //colors[1] = "mavi";
            //colors[2] = "siyah";
            //colors[3] = "turuncu";

            //Console.WriteLine(colors[3]);

            //----------------------------------

            //string[] cities = new string[5];

            //cities[0] = " istanbul";
            //cities[1] = " amasya";
            //cities[2] = " erzurum";
            //cities[3] = " ankara";
            //cities[4] = " erzincan";

            //Console.WriteLine(cities[1]);

            //-----------------------------------

            //int[]numbers= new int[10];

            //numbers[0] = 50;
            //numbers[1] = 05;
            //numbers[2] = 25;
            //numbers[3] = 06;
            //numbers[4] = 1235;
            //numbers[7] = 789;
            //Console.WriteLine(numbers[7]);

            //------------------------------------

            //string[] cities = { "amasya", " istanbul", "erzrurum", "anGara", "tirabzon daa" };

            //Console.WriteLine(cities[4]);

            //-----------------------------------































            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = { "mavi", "pembe", "sarı", "lacivert", "kahverengi", "yasuo", "garen" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //----------------------------------------------------

            //int[] numbers = { 1, 54, 96, 528, 75, 108, 48, 80 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //-------------------------------------------------------

            //char[] sembol = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < sembol.Length; i++)
            //{ Console.WriteLine(sembol[i]); }

            //--------------------------------------------------------

            //int[] dizilerim = { 54, 75, 80, 94, 103, 105, 687, 857 };
            //int number= dizilerim[0];
            //for (int i = 0;i<dizilerim.Length;i++)
            //{
            //    if (dizilerim[i] > number)
            //    {
            //        number = dizilerim[i];
            //    }
            //}
            //Console.WriteLine(number);

            //--------------------------------------------------------------

            //string[] insanlar= { "öykü","ahmet", "zeynep", "berke"};

            //Console.WriteLine(insanlar.Length);

            //---------------------------------------------------------------


            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //---------------------------------------------------------------

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //---------------------------------------------------------------


























            #endregion

            #region Dizi Metotlar


            //string[] customers = { "ali", "mehmet", "ahmet", "samed", "bulut" };
            //int index = Array.IndexOf(customers, "bulut");
            //Console.WriteLine(index);

            //-------------------------------------------------------------------

            //int [] numbers= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            //-------------------------------------------------------------------


























            #endregion

            #region kullanıcan değer alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //-------------------------------------------------------------

            //int[] number = { 10, 20, 30, 40, 50, };
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++) 
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);  

            //-------------------------------------------------------------

            //int[] numbers = { 21, 42, 33, 54, 75, 86, 97, 58, 29,220 };

            //Console.WriteLine("*** ÇİFT SAYILAR ***");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) ;
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }
            //}

            //Console.WriteLine("*** TEK SAYILAR***");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}














































            #endregion









            Console.Read();










        }
    }
}
