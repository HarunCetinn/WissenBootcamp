//Kullanıcıdan alınan metni alt alta substring kullanarak yazıcaz 

//Console.WriteLine("Metin giriniz: ");
//string metin = Console.ReadLine();
//int start = 0;

//for (int i = 0; i <= metin.Length; i++)
//{
//    if (i == metin.Length || metin[i] == ' ')
//    {
//        int end = i;
//        string kelime = metin.Substring(start, end - start);
//        Console.WriteLine(kelime);

//        start = i + 1;
//    }
//}


//////////********////////"10 25 10 35 80 10 65 80 10 82 10 90 40 50 10" 
///BU STRİNGDE KAÇ ADET 10 BULUNUR 

//string sayılar = "10 25 10 35 80 10 65 80 10 82 10 90 40 50 10";

//string[] sayıDizisi = sayılar.Split(' ');

//// Her bir elemanı kontrol et ve "10" ise ekrana yazdır
//foreach (string sayı in sayıDizisi)
//{
//    if (sayı == "10")
//    {
//        Console.WriteLine(sayı);
//    }
//}

////****////büyükten küçüğe ve küçükten büyüğe kullanıcının girdiği sayıları
///sıralayan program 

//sayigir:

//Console.WriteLine("adet giriniz: ");
//int adet=int.Parse(Console.ReadLine());

//int eb=0, ek=0;

//for(int i = 0; i < adet; i++)
//{
//    Console.WriteLine("sayı giriniz: ");
//    int girilen =int.Parse(Console.ReadLine());
//    if (girilen < ek) ek = girilen;
//    else if (girilen > eb) eb = girilen;
//}
//Console.WriteLine($"Girilen en büyük: {eb}, en küçük: {ek}");

//goto sayigir;










