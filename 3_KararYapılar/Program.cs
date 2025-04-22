using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapılar
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region mod ile karar ve if
            //Console.Write("LÜTFEN ŞİFREYİ GİRİNİZ:");
            //    string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            // Console.WriteLine("ŞİFRE DOĞRU");
            //}
            //else
            //{ Console.WriteLine("ŞİFRE YANLIŞ"); }


            //string capital, country;
            //Console.Write("BAŞKENTİ GİRİNİZ:");
            //capital = Console.ReadLine();
            //Console.Write("ÜLKEYİ GİRİNİZ:");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğru");
            //}
            //else
            //{ Console.Write("veriler yanlış"); }

            // int sayı;
            // Console.Write("SAYIYI GİRİNİZ:");
            // sayı = int.Parse(Console.ReadLine());
            // if (sayı == 5) 
            // {
            //     Console.WriteLine("SAYI DOĞRU");
            // }


            //else

            // {
            //     Console.WriteLine("SAYI YANLIŞ");
            // }

            //int exam1, exam2, exam3, average;
            //string result =  " " ;
            //Console.Write("SINAV 1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("SINAV 2:");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("SINAV 3:");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("SINAVLARIN ORTALAMASI : " + average);

            //if (average > 0 & average <= 50) 
            //{
            //    result = "SONUÇ KÖTÜ";
            //}
            //if (average > 50 & average <= 60
            //    ) 
            //{
            //    result = "SONUÇ ORTA";
            //}

            //if (average > 60 & average <= 70
            //    ) 
            //{
            //    result = "SONUÇ İYİ";
            //}
            //if (average > 70 & average <= 80) 
            //{
            //    result = "SONUÇ ÇOK İYİ";
            //}
            //if (average > 80 & average <= 100) 
            //{
            //    result = "SONUÇ SÜPER İYİ";
            //} 




            //Console.WriteLine(result);


            //string city;
            //Console.WriteLine("LÜTFEN BİR ŞEHİR GİRİN: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "bursa" | city == "ankara")

            //{
            //    Console.WriteLine("şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("LÜTFEN BİR KULLANICI ADI GİRİNİZ:");
            //string username = Console.ReadLine();
            //if (username != "admin") //!= değilse olur username != username adminden farklıysa demek

            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}















            //Console.Read();
















            //int number;
            //number = 26;
            //int result = number % 5; // bir tuşa tıklayınca çalışıyo bu komut
            //Console.WriteLine(result);


            //Console.Write("LÜTFEN BİRİNCİ SAYI GİRİNİZ:");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("LÜTFEN İKİNCİ SAYIYI GİRİNİZ:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number % number2;
            //Console.Write("BİRİNCİ SAYININ İKİNCİ SAYIYA BÖLÜMÜNDEN KALAN:" + result);


            //Console.Write("LÜTFEN SAYIYI GİRİNİZ: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("SAYI ÇİFT");
            //}
            //else
            //{
            //    Console.Write("SAYI TEKTİR");
            //}

            //char team;
            //Console.Write("LÜTFEN BİR TAKIM HARFİ GİRİNİZ: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FENERBAHÇE <3");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("beşiktaş");
            //    }




            #endregion mod ve 

            #region char ile karar yapılar

            //    Console.WriteLine("*** BULUT YEMEK RESTORANTI MENÜSÜ ***");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine("1-ANA YEMEK");
            //    Console.WriteLine("2-ÇORBALAR");
            //    Console.WriteLine("3-PİZZALAR");
            //    Console.WriteLine("4-TATLILAR");
            //    Console.WriteLine("5-İÇECEKLER");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------------------------");

            //    string menuItem;
            //    Console.Write("DETAYINI GÖRMEK İSTEDİĞİNİZ MENÜ SEÇİMİ: ");
            //    menuItem = Console.ReadLine();
            //    if (menuItem == "1")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("ANA YEMEKLER");
            //        Console.WriteLine();
            //        Console.WriteLine("KÖRİ SOSLU TAVUK");
            //        Console.WriteLine("BEŞAMAL SOSLU KÖFTE");
            //        Console.WriteLine("PİLAV ÜSTÜ ISPANAK");
            //        Console.WriteLine("YAPRAK SARMA");


            //    }
            //    if (menuItem == "2")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("ÇORBALAR");
            //        Console.WriteLine();
            //        Console.WriteLine("DOMATES ÇORBASI");
            //        Console.WriteLine("AYRAN AŞI ÇORBASI");
            //        Console.WriteLine("YAYLA ÇORBASI");
            //        Console.WriteLine("BROKOLİ ÇORBASI");
            //        Console.WriteLine("EZOGELİN ÇORBASI");

            //    }
            //    if (menuItem == "3")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("PİZZALAR");
            //        Console.WriteLine();
            //        Console.WriteLine("KARIŞIK PİZZA");
            //        Console.WriteLine("SUCUKLU PİZZA");
            //        Console.WriteLine("KAŞARLI PİZZA PİZZA");
            //        Console.WriteLine("MANTARLI PİZZA PİZZA");
            //        Console.WriteLine("HAMSİLİ PİZZA");
            //    }
            //     if (menuItem == "4")
            //    { Console.WriteLine();
            //    Console.WriteLine("TATLILAR");
            //    Console.WriteLine();
            //    Console.WriteLine("TİRAMİSU");
            //    Console.WriteLine("PUDİNG");
            //    Console.WriteLine("KAZANDİBİ");
            //    Console.WriteLine("SÜTLAÇ");
            //    Console.WriteLine("BAKLAVA");
            //}
            //    if (menuItem == "5")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("İÇECEKLER");
            //        Console.WriteLine();
            //        Console.WriteLine("SARIYER KOLA");
            //        Console.WriteLine("SARIYER GAZOZ");
            //        Console.WriteLine("SARIYER FANTA");
            //        Console.WriteLine("AYRAN");
            //        Console.WriteLine("SU");
            //        Console.WriteLine("SPRİTE");
            //        Console.WriteLine("ÇAY");
            //    }





















            #endregion

            #region switch case

            //Console.Write("LÜTFEN AY GİRİŞİ YAPINIZ : ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //        case 2: Console.WriteLine("Şubat"); break ;
            //        case 3: Console.WriteLine("Mart"); break;    
            //        case 4: Console.WriteLine("Nisan"); break;    
            //        case 5: Console.WriteLine("Mayıs"); break;    
            //        case 6: Console.WriteLine("Haziran"); break;    
            //        case 7: Console.WriteLine("Temmuz"); break;    
            //        case 8: Console.WriteLine("Ağustos"); break;    
            //        case 9: Console.WriteLine("Eylül"); break;    
            //        case 10: Console.WriteLine("Ekim"); break;    
            //        case 11: Console.WriteLine("Kasım"); break;    
            //        case 12: Console.WriteLine("Aralık"); break;
            //        default: Console.WriteLine("VERİ GİRİŞİ HATALI !!"); break;

            //}









            #endregion

            #region  switch case ile hesap machine
            //int number1, number2, result;
            //char symbol;
            //Console.Write("birinci sayıyı giriniz:");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("ikinci sayıyı giriniz:");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("yapmak istediğiniz işlem:");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;

            //    case '-':
            //            result = number1 - number2;
            //        Console.WriteLine("Çıkarma:"+result);
            //        break
            //            ;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:"+result);
            //        break;
            //        case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;

            //}
                




            
            
            
            
            
            
            #endregion


















            Console.Read();





        }
    }
}

