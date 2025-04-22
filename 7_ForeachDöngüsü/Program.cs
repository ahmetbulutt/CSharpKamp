using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_foreach_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region foreach döngüsü



            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //---------------------------------------------------

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}
            //---------------------------------------------------
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //foreach (int i in number)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //------------------------------------------------------

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //int total = 0;
            //foreach (int i in number)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            //-------------------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //----------------------------------------------------------
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            //-----------------------------------------------------------







            #endregion
            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("****** BULUT EĞİTİM KAMPI SINAV UYGULAMASI *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            ////Sınıftaki öğrenci sayısını kullanıcadan alma
            //Console.WriteLine("---------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var:");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");
            ////Öğrenci isimlerini ve not ortalamalarını saklaycak diziler
            //string[] studentName = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    double totalExamResult = 0;
            //    studentName[i] = Console.ReadLine();

            //    //Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;// notları toplama
            //    }
            //    Console.WriteLine("-------------------------------------");
            //    studentExamAvg[i] = totalExamResult / 3;


            //}

            ////Öğrencilerin ortalaması 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    //kalma durumu
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçemedi");
            //    }

            //    Console.WriteLine("---------------------------------");

            //}





























            #endregion
            //Console.Read();
        }
    }
}
