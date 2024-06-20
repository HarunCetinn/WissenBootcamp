// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using InheritanceSampleAnimal;

//Dog dog = new Dog();

//using InheritanceSampleAnimal;

//Animal animal = new Animal();
//animal.FootCount = 4;
//animal.Age = 2;
//animal.BirthDate = DateTime.Now.AddYears(-2);
//animal.Weight = 10;

//animal.Eat();
//int sonuc = animal.Run(20, 100, out int cal);
//TimeSpan restTime = animal.Rest(DateTime.Now, DateTime.Now.AddMinutes(30));

//List<HelthCare> list = new List<HelthCare>();
//for (int i = 0; i <= 100; i+=15)
//{
//    HelthCare healthCare = new HelthCare();
//    healthCare.Date = DateTime.Today.AddDays(-180).AddDays(i);
//    healthCare.Notes=$"Date : {healthCare.Date.ToString("yyyy-MM-dd")} - {i.ToString()}";

//    list.Add(healthCare);
//}

//animal.HealthCareHistory = list;

//Console.WriteLine("-------------------- Animal Bilgiler ---------------------------");
//Console.WriteLine(animal.AnimalInfo);
//Console.WriteLine("---------------- Animal Bilgiler Bitiş -------------------------");


//Console.WriteLine("---------------------- Türetilmiş - Inheritance Alan Class Yapılandırılması --------------------------");
//Cat cat = new Cat();
//cat.FootCount = 4;
//cat.Age = 3;
//cat.BirthDate = new DateTime(2021, 5, 8);
//cat.HealthCareHistory = list;
//cat.Weight = 8;
//cat.Eat();
//int sonucCat = cat.Run(20, 100, out int calCat);
//TimeSpan restTimeCat = cat.Rest(DateTime.Now ,DateTime.Now.AddMinutes(30));
//cat.CatHouse = "Büyük bir kedi evi";
//double catHousePrice = cat.CatHousePrice(HouseType.big);
//string info = cat.AnimalInfo;
//info += $"\n" +
//    $"Calori Hesabı Bilgileri : {sonucCat} - {calCat}\n" +
//    $"Dinlenme Zamanı : {restTimeCat}\n" +
//    $"Kedi Evi Fİyatı : {catHousePrice}";
//Console.WriteLine(info);


//StringBuilder
using System.Text;

string str = string.Empty;
DateTime beginTime = DateTime.Now;
for (int i = 0; i < 100000; i++)
{
    str += i.ToString();
}
DateTime endTime = DateTime.Now;
TimeSpan ts1 = endTime - beginTime;
Console.WriteLine(ts1);

StringBuilder strBuilder = new StringBuilder();
DateTime beginTime1 = DateTime.Now;
for (int i = 0; i < 100000; i++)
{
    strBuilder.Append(i.ToString());
}
DateTime endTime1 = DateTime.Now;
TimeSpan ts2 = endTime1 - beginTime1;
Console.WriteLine(ts2);


