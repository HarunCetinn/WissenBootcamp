/////Soru : string[] sehirler = { "Ankara","İzmir", "İstanbul", "Bursa",,"İzmir" "Erzurum","Ankara", "Çanakkale","İstanbul","Bursa", "Bilecik", "İzmir","Bursa","Ankara", "Kars" ,"İstanbul"};
//Hangi dizinin elemanı kaç adet tekrar etmiş. Bütün elemanlar bir kere olacak şekilde dizi yapılandıran program

// String dizisi tanımlanır
string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Bursa", "İzmir", "Erzurum", "Ankara", "Çanakkale", "İstanbul", "Bursa", "Bilecik", "İzmir", "Bursa", "Ankara", "Kars", "İstanbul" };

// Tekrar eden elemanlar listesi oluşturulur
Console.WriteLine("Tekrar eden elemanlar:");
for (int i = 0; i < sehirler.Length; i++)
{
    // Elemanın tekrar edip etmediğini kontrol etmek için bir bayrak (flag) kullanılır
    bool tekrarEden = false;
    int tekrarSayısı = 0;

    // Elemanın dizideki konumundan sonrasını kontrol ederek tekrar etmesini ararız
    for (int j = i + 1; j < sehirler.Length; j++)
    {
        if (sehirler[i] == sehirler[j])
        {
            tekrarEden = true;
            tekrarSayısı++;
            // Tekrar eden bir eleman bulduğumuzda iç döngüyü kırarız
        }
    }

    // Eğer eleman tekrar ediyorsa, o elemanı ekrana yazdırırız
    if (tekrarEden)
    {
        Console.WriteLine($"{sehirler[i]}: {tekrarSayısı + 1} kez");


    }


    if (!tekrarEden)
    {
        Console.WriteLine(sehirler[i]);
    }
}


