Console.WriteLine("Suyun sıcaklığını giriniz : ");

Derece:
//int suDerecesi = int.Parse(Console.ReadLine());
//if (suDerecesi <= 0 ) Console.WriteLine("Katı Haldedir.");
//if (suDerecesi >= 100) Console.WriteLine("Buhar Haldedir.");
//if (suDerecesi <= 100 && suDerecesi >=0) Console.WriteLine("Sıvı Haldedir.");
//goto Derece;

int suDerecesi = int.Parse(Console.ReadLine());
switch (suDerecesi)
{
    case <0:
        Console.WriteLine("Katı Haldedir");
        break;
    case >100:
        Console.WriteLine("Gaz Haldedir");
        break;
    case >0:
    case < 100:
        Console.WriteLine("Sıvı Haldedir");
        break;
}
goto Derece;   //goto eski usül metoda geri getirme





