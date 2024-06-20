// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ClassInstanceSample;

//Animal animal = new Animal();
//Animal animalType = new Animal("Sürüngen");

//animal.setAnimalTYpe("Sürüngen");
//Console.WriteLine(animal.getAnimalTYpe());

//animal.AnimalTYpe = "Sürüngen";
//Console.WriteLine(animal.AnimalTYpe);

//animal.AnimalTYpe = "Sürüngen";
//Console.WriteLine(animal.AnimalTYpe);

//animal.Speed = 100;
//Console.WriteLine(animal.Speed);

//for (int i = 0; i <= 100000; i++)
//{
//    Animal animal1 = new Animal();
//    animal1 = null;

//    GC.Collect();
//}


//Utu utu = new Utu();
//utu.Marka = "Roventa";
//utu.Renk = "Beyaz";
//utu.KazanliMi = true;
//utu.Sicaklik = 0;

//string utuBilgileri =
//               $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" +
//               $"Marka : {utu.Marka}\n" +
//               $"Renk : {utu.Renk}\n" +
//               $"Sıcaklık : {utu.Sicaklik}\n" +
//               $"Kazanlı mı? : {(utu.KazanliMi ? "Var" : "Yok")}";
//Console.WriteLine(utuBilgileri);

//Console.WriteLine(new string('*', 100));
//Utu newUtu = new Utu("Arçelik", "KIrmızı", 0, true);

//Console.WriteLine(new string('*', 100));
//Utu utuMarka = new Utu("Bosch");
//utuMarka.Renk = "Mavi";
//utuMarka.Sicaklik = 10;
//utuMarka.KazanliMi = false;

//Console.WriteLine(new string('*', 100));
//Utu utuSinif = new Utu()
//{
//    Marka = "Fakir",
//    Renk = "Yeşil",
//    KazanliMi = true,
//    Sicaklik = 0,
//};
//utuSinif.Isın(25);
Person person = new Person();
person.Ad = "John";
person.Soyad = "Doe";
person.DogumTarihi = DateTime.Now.AddYears(-35);
person.Cinsiyet = "Erkek";
person.Email = "john.doe@contoso.com";
person.Telefon = "555-475-98-98";
person.Adres = "1257 street NewYork ABD";


//string personInfo = person.ToString();
string personInfo = person.getPersonInfo;
Console.WriteLine(personInfo);