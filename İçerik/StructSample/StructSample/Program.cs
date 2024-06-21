using System.Net.Http.Headers;

namespace StructSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //MyStruct myStruct = new MyStruct();
            //Console.WriteLine($"{myStruct.x} - {myStruct.y} - {myStruct.z}");

            //MyStruct myStruct;
            //myStruct.x = 3;
            //myStruct.y = true;
            //myStruct.z = "Sample Txt";
            //Console.WriteLine($"{myStruct.x} - {myStruct.y} - {myStruct.z}");

            //MyStruct ms = new MyStruct();
            //ms.x = 5;
            //ms.y = true;
            //ms.z = "2";
            //Console.WriteLine($"{ms.x} - {ms.y} - {ms.z}");
            //Console.WriteLine(ms.Islem());

            //Console.WriteLine(MyStruct.Isım());

            //MyStruct.MyCLass myClass = new MyStruct.MyCLass();
            //myClass.y = 100;
            //myClass.z = DateTime.Now.AddYears(-20);
            //Console.WriteLine($"{myClass.y} - {myClass.z.ToLongDateString()}");

            //MyClass.MyStruct ms = new MyClass.MyStruct();
            ////ms.y = 1;
            //Console.WriteLine(ms.y);

            //MyStruct ms = new MyStruct();
            //ms.x = 3;
            //ms.y = 4;

            //MyStruct ms2 = ms;
            //ms2.x = 13;
            //ms2.y = 14;
            //Console.WriteLine($"{ms.x} -  {ms.y}");
            //Console.WriteLine($"{ms2.x} -  {ms2.y}");

            //Console.WriteLine(new string('*', 100));

            //MyClass mc = new MyClass();
            //mc.x = 7;
            //mc.y = 8;
            //MyClass mc2 = mc;
            //mc2.x = 9;
            //mc2.y = 10;
            //Console.WriteLine($"{mc.x} -  {mc.y}");
            //Console.WriteLine($"{mc2.x} -  {mc2.y}");

            //Kitap k = new Kitap();
            //Console.WriteLine(k.ToString());

            //Kitap k = new Kitap(1, "Müptezeller", "Roman", "5464656", "Emrah Serbes");
            //Console.WriteLine(k.ToString());

            Kitap k = new Kitap(1, "Suç ve Ceza", "Roman");
            Console.WriteLine(k.ToString());

        }
    }

    public struct Kitap
    {
        //public Kitap() 
        //{
        //}

        public Kitap()
        {
            KitapID = 1;
            KitapAdi = "Nutuk";
            KitapTuru = "Roman";
            ISBN = "56446464646";
            YazarAdi = "MKA";
        }

        public Kitap(int kitapID, string kitapAdi, string kitapTuru)
        {
            KitapID = kitapID;
            KitapAdi = kitapAdi;
            KitapTuru = kitapTuru;
          //Constructor içinde property lere değerler atanmalıdır. property e bir değer atanmaz ise property nin veri tipinin başlangıç değerini alır. 
        }
        //public Kitap(int kitapID,string kitapAdi,string kitapTuru,string isbn,string yazarAdi)
        //{
        //    KitapID = kitapID;
        //    KitapAdi = kitapAdi;
        //    KitapTuru = kitapTuru;
        //    ISBN = isbn;
        //    YazarAdi = yazarAdi;
        //}
        public int KitapID { get; set; }
        public string KitapAdi {  get; set; }
        public string KitapTuru {  get; set; }
        public string ISBN {  get; set; }
        public string YazarAdi {  get; set; }

        public override string ToString()
        {
            return $"Kitap ID : {KitapID}\n" +
                $"Kİtap Adı : {KitapAdi}\n" +
                $"Kitap Türü : {KitapTuru}\n" +
                $"ISBN : {ISBN}\n" +
                $"Yazar Adı : {YazarAdi}";
        }
    }

    //class MyClass
    //{
    //    public int x;
    //    public int y;
    //}
    //struct MyStruct
    //{
    //    public int x;
    //    public int y;
    //}


    //class MyClass
    //{
    //    public int x;

    //    public struct MyStruct
    //    {
    //        public int y { get; set; }
    //    }
    //}
    //struct MyStruct
    //{
    //    public int x;

    //    public class MyCLass 
    //    {
    //        public int y { get; set; }
    //        public DateTime z { get; set; }
    //    }
    //}

    //struct MyStruct
    //{
    //    public int x;
    //    public bool y;

    //    public string z { get; set; }
    //    public double Islem()
    //    {
    //        if(y)
    //        {
    //            return x * int.Parse(z);
    //        }

    //        return -1;
    //    }

    //    public static string Isım()
    //    {
    //        return "John Doe";
    //    }
    //}
    //struct MyStruct
    //{
    //    public int x;
    //    public bool y;
    //    public string z;
    //}


    //interface IInterface
    //{
    //    void A();
    //    void B(bool c);
    //}

    //struct Struct3 : IInterface
    //{
    //    public void A()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void B(bool c)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //struct Struct1 : Struct2
    //{
    //    int x;
    //    bool y;
    //}

    //struct Struct2 : Class1
    //{
    //    int a;
    //    int b;
    //}

    //class Class1
    //{
    //    int z;
    //    bool w;
    //}
}
