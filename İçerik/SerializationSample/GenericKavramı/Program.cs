// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using GenericKavramı;
using System.Collections;

//GenericOLmayanSınıf veri = new GenericOLmayanSınıf();
//veri.EkranaYaz<int>(1250);//Verilen tipte bir değer bekler.

//veri.EkranaYaz<string>("Merhaba");
//veri.EkranaYaz("Dünya");
/*
 * 1 - Generic, tip açısından güvenlidir. Hangi tipi belirtirseniz o tipte veriyi kabul eder. Aksi halde derleme zamanı hatası alınır..
 * 2 - Generic, boxing ve unboxing yapılmasına gerek kalmaz. Tip bağımlı olduğu için Bu da performans avantajı sağlar
 * 
 */


//GenericSinif<int> sinif = new GenericSinif<int>();
//sinif.ID = 1;
////sinif.ID = "123";//int olarak belirlenen ID'ye string değer verilemez
//sinif.Name = "John";
//sinif.SirName = "Doe";

//GenericSinif<Guid> sinif2 = new GenericSinif<Guid>();
//sinif2.ID = Guid.NewGuid();
//sinif2.Name = "Jeyn";
//sinif2.SirName = "Doe";

//Console.WriteLine($"ID : {sinif.ID}\nAdı : {sinif.Name}\nSoyadı : {sinif.SirName}");
//Console.WriteLine(new string('-', 100));
//Console.WriteLine($"ID : {sinif2.ID}\nAdı : {sinif2.Name}\nSoyadı : {sinif2.SirName}");

//GenericMetot<string> takimlar = new GenericMetot<string>();
//takimlar.VeriEkle(0, "Beşiktaş");
//takimlar.VeriEkle(1, "Galatasaray");
//takimlar.VeriEkle(2, "Fenerbahçe");
//takimlar.VeriEkle(3, "Trabzonspor");
//takimlar.VeriEkle(4, "Bursaspor");

//for (int i = 0; i < takimlar.dizi.Length; i++)
//{
//    Console.WriteLine($"Takım ID : {i} - Takım Adı : {takimlar.VeriyiGetir(i)}");
//}


//GenericMetot<int> yaslar = new GenericMetot<int>();
//yaslar.VeriEkle(0,18);
//yaslar.VeriEkle(1, 20);
//yaslar.VeriEkle(2, 50);
//yaslar.VeriEkle(3, 30);
//yaslar.VeriEkle(4, 46);

//for (int i = 0; i < yaslar.dizi.Length; i++)
//{
//    Console.WriteLine($"Yaş ID : {i} - Yaş Değeri : {yaslar.VeriyiGetir(i)}");
//}

AnahtarDegerIkilisi<int, string> kullanici = new AnahtarDegerIkilisi<int, string>();
kullanici.ID = 1;
kullanici.Name = "John Doe";
kullanici.BirthDate = new DateOnly(2000, 05, 01);
Console.WriteLine($"ID : {kullanici.ID}\nAdı : {kullanici.Name}\nDoğum Tarihi : {kullanici.BirthDate}");

//Dictionary<int,string> de = (Dictionary<int, string>)kullanici;