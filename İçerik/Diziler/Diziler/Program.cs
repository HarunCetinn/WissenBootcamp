// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Diziler : Aynı tipdeki verileri bir arada tutmamızı sağlayan nesnelerdir.

//Dizi Tanımlama
//VeriTipi[] diziDeğişkenAdi = {Değer1, Değer2,Değer3,Değer4,Değer5.....} Eleman sayısını belirlemeden dizi tanımlama
//VeriTipi[] diziDeğişkenAdi = new VeriTipi[ElemanSayis] Eleman sayısı baştan belli olacak şekilde dizi tanımlama

//string[] dizi = new string[3] { "John Doe", "Jeyn Doe", "Tom Doe", "Poul Doe" };

//string[] names = { "John Doe", "Jeyn Doe", "Tom Doe", "Poul Doe" };

//Console.WriteLine(names.Length);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[5]);

//string[] names = new string[6];
//names[0] = "John Doe";
//names[1] = "Jeyn Doe";
//names[2] = "Tom Doe";
//names[3] = "Bill Doe";
//names[4] = "Poul Doe";
//names[5] = "Serahhn Doe";

//for (int i = 0; i < names.Length; i++)
//for (int i = 0; i <= names.Length - 1; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//string[] metinDizisi = metin.Split(' ');
//foreach (string met in metinDizisi)
//{
//    Console.WriteLine(met);
//}      //ödev sorusuna benzer

//Dizi Metotları
int[] sayilar = { 10, 20, 5, 85, 32, 15, 23 };
foreach (int sayi in sayilar)
{   
    Console.WriteLine(sayi);
}

Array.Sort(sayilar);
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Array.Reverse(sayilar);
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
//SORU : Kullanıcının gireceği adet kadar tam sayıları alıp bir dizi oluşturulduktan sonra dizi elemanları küçükten büyüğe ve büyükten küçüğe sıralamasını yapan program