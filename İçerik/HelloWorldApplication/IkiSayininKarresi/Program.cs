// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int number;
int sqrtNumber;

Console.Write("Karesini hesaplamak istediğiniz tamsayıyı giriniz : ");
string strNumber = Console.ReadLine();

//number = Convert.ToInt32(strNumber);
number = int.Parse(strNumber);
sqrtNumber = number * number;

Console.WriteLine("Girdiğiniz sayının karesi : " + sqrtNumber);
Console.ReadLine();