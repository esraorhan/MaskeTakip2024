using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas v = new Vatandas(); // instance demek. Yani bir tane  vatandas oluşturduk.
            v.Ad = "ESRA";
            SelamVer("Suat");
           int sonuc = Topla(5,7);
            //Diziler

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker"; // bu kısımda sadece ekranda ilkeri yazacak.
            //referans tip yasından kaynaklı oldugu için. yukarıdaki ogrenciler dizisi için
            //.referans tipleri kullanabilmek için newlemek gerek.
            // new i gördüğü anda tekrardan 4 alanlık bir heapde yer açıyor.
            // stack de yeni işaretlenen öğrenciler artık 4 birimlik alan kapladı.
            //Garbaje collecter ilk yazılan ögrencileri heapten atıyor. 
            //referans tip :array, class ,interface,abstractlar bellekte bu şekilde tutulur.
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine("Sehir" + sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;
            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Gaziantep");
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer( string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc; 
        }

        private static void Degiskenler()
        {
            string message = "Selam";
            double amount = 10000.0;
            int sayi = 10;
            bool girisYapmisMi = false;

            Console.WriteLine(message);
            Console.WriteLine(amount);
        }
    }

    public class Vatandas
    {
        //Classlar ve methodlar pascal case yazılır.
        public string Ad2 { get; set; }
        public string Ad { get; set; }
        private string Soyad { get; set; }
        private int DogumYili { get; set; }
        private long TcNo { get; set; }
    }
    //Solid
   
}
