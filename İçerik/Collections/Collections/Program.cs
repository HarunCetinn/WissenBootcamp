// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region ArrayList
//using System.Collections;

//ArrayList gunler = new ArrayList();

//gunler.Add("Pazartesi");
//gunler.Add("Salı");
//gunler.Add("Çarşamba");
//gunler.Add("Perşembe");
//gunler.Add("Cuma");
//gunler.Add("Cumartesi");
//gunler.Add("Pazar");

////int[] dizi = new int[] { 100, 200, 300, 400, 500 };
////gunler.AddRange(dizi);

//Console.WriteLine("---------------------- Eleman Sayısı ----------------------");
//Console.WriteLine($"Eleman Sayısı : {gunler.Count}");

//Console.WriteLine("---------------------- Kapasite Sayısı ----------------------");
//Console.WriteLine($"Kapasite Sayısı : {gunler.Capacity}");

//gunler.Add("John Doe");
//gunler.Add("John Doe");
//gunler.Add("John Doe");
//gunler.Add("John Doe");
//gunler.Add("John Doe");

//Console.WriteLine("---------------------- Eleman Sayısı ----------------------");
//Console.WriteLine($"Eleman Sayısı : {gunler.Count}");

//Console.WriteLine("---------------------- Kapasite Sayısı ----------------------");
//Console.WriteLine($"Kapasite Sayısı : {gunler.Capacity}");

//gunler.TrimToSize();
//Console.WriteLine("---------------------- Eleman Sayısı ----------------------");
//Console.WriteLine($"Eleman Sayısı : {gunler.Count}");

//Console.WriteLine("---------------------- Kapasite Sayısı ----------------------");
//Console.WriteLine($"Kapasite Sayısı : {gunler.Capacity}");

//gunler.Clear();

//Console.WriteLine("---------------------- Eleman Sayısı ----------------------");
//Console.WriteLine($"Eleman Sayısı : {gunler.Count}");

//Console.WriteLine("---------------------- Kapasite Sayısı ----------------------");
//Console.WriteLine($"Kapasite Sayısı : {gunler.Capacity}");


//gunler.Sort();
//foreach (var item in gunler)
//{
//    Console.WriteLine(item);
//}

//gunler.Reverse();

//foreach (var item in gunler)
//{
//    Console.WriteLine(item);
//}

//bool result1 = gunler.Contains("Salı");
//bool result2 = gunler.Contains("Sample Text");
//Console.WriteLine(result1);
//Console.WriteLine(result2);

//int firstINdex = gunler.IndexOf("John Doe");
//int lastIndex = gunler.LastIndexOf("John Doe");
//Console.WriteLine(firstINdex);
//Console.WriteLine(lastIndex);

//gunler.Remove("John Doe");
//gunler.RemoveAt(9);

//gunler.Insert(5, "Sample Text");
//gunler.InsertRange(1, new string[] { "Sample Text1", "Sample Text2" });

//gunler.RemoveRange(1, 2);

//string[] newString = new string[20];
////gunler.CopyTo(newString);
////gunler.CopyTo(newString, 10);
//gunler.CopyTo(3, newString, 5, 5);
//Console.ReadLine();
#endregion


#region Dictionary
//Dictionary<int,string> iller = new Dictionary<int,string>();
//iller.Add(1, "Adana");
//iller.Add(2, "Antalya");
//iller.Add(34, "İstanbul");
//iller.Add(35, "İzmir");
//iller.Add(61, "Trabzon");
//iller.Add(28, "Giresun");

//iller.Add(1, "Test");//Hata veriri key değeri unique olmalı
//iller.Clear();
//Console.WriteLine($"Elelman Sayısı : {iller.Count}");

//bool result1 = iller.ContainsKey(34);
//bool result2 = iller.ContainsValue("Antalya");

//Console.WriteLine(result1);
//Console.WriteLine(result2);

//Dictionary<int,string>.KeyCollection keys = iller.Keys;
//Dictionary<int,string>.ValueCollection values = iller.Values;
//foreach (int key in keys)
//{
//    Console.WriteLine($"[{key}] : [{iller[key]}]");
//}

//bool result1 = iller.TryGetValue(35, out string il1);
//bool result2 = iller.TryGetValue(68, out string il2);

//Console.WriteLine($"{result1} - {il1}");
//Console.WriteLine($"{result2} - {il2}");

//iller.Remove(1);
//iller.Remove(1, out string il);
//Console.WriteLine(il);
//Console.ReadLine();
#endregion

#region HashTable
//using System.Collections;

//Hashtable ogrenciList = new Hashtable();
//ogrenciList.Add("0013", "John Doe");
//ogrenciList.Add("0245", "Jeyn Doe");
//ogrenciList.Add("3464", "Tom Doe");
//ogrenciList.Add("0023", "Poul Doe");
//ogrenciList.Add("4536", "Hans Doe");
//ogrenciList.Add("0013", "John Doe");//aynı key tekrardan eklenemz

//ogrenciList.Clear();

//bool result1 = ogrenciList.Contains("0013");
//bool result2 = ogrenciList.ContainsKey("4536");
//bool result3 = ogrenciList.ContainsValue("Poul Doe");
//Console.WriteLine(result1);
//Console.WriteLine(result2);
//Console.WriteLine(result3);

//ICollection keys = ogrenciList.Keys;
//ICollection values = ogrenciList.Values;
//foreach (string key in keys)
//{
//    Console.WriteLine(key);
//}

//ogrenciList.Remove("0013");

//object newObject = ogrenciList.Clone();//Boxing
//Hashtable newOgrenci = newObject as Hashtable;//Unboxing
//foreach (DictionaryEntry  de in newOgrenci)
//{
//    Console.WriteLine($"[{de.Key}] :: [{de.Value}]");
//}
//Console.ReadLine();
#endregion

#region SortedList
//using System.Collections;

//SortedList iller = new SortedList();
////SortedList<int, string> _iller = new SortedList<int, string>();
//iller.Add(34, "İstanbul");
//iller.Add(7, "Antalya");
//iller.Add(6, "Ankara");

//iller.Clear();
//int elelmanSayisi = iller.Count;

//IList keys =  iller.GetKeyList();
//IList values = iller.GetValueList();
//foreach (int i in keys)
//{
//    Console.WriteLine(i);
//}

//iller.Remove(34);
//iller.RemoveAt(0);

//iller.Contains(34);
//iller.ContainsKey(34);
//iller.ContainsValue("Ankara");

//int key = (int)iller.GetKey(34);
#endregion
