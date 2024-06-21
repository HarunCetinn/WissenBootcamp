// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region DataContractJsonSerializer Json Format
//using JsonSerialization;
//using System.Runtime.Serialization.Json;
//using System.Text;

//Article article = new Article()
//{
//    ArticleID = 1,
//    ArticleName = "101 C# Örnekli ders anlatım",
//    ArticleDescription = "Örnekleri ile beraber c# uygulamaları",
//    ArticleSiteList = new List<string>() { "www.medium.com", "www.codeproject.com", "www.csharpnedir.com"}
//};

//string jsonData = string.Empty;
//SerializeArticle(article,ref jsonData);
////Console.WriteLine(jsonData);

//Deserialize(jsonData);

//void Deserialize(string jsonData)
//{
//    using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonData)))
//    {
//        DataContractJsonSerializer deserializeJson = new DataContractJsonSerializer(typeof(Article));
//        Article article = deserializeJson.ReadObject(ms) as Article;
//        string str = string.Empty;
//        WriteArticle(article,ref str);
//        Console.WriteLine(str);
//    };
//}

//void WriteArticle(Article? article,ref string outStr)
//{
//    StringBuilder stringBuilder = new StringBuilder();
//    stringBuilder.Append($"Article ID : {article.ArticleID}\n");
//    stringBuilder.Append($"Article Name : {article.ArticleName}\n");
//    stringBuilder.Append($"Article Description : {article.ArticleDescription} \n");
//    stringBuilder.Append($"Article Sites : {string.Join(',',article.ArticleSiteList)}");
//    outStr = stringBuilder.ToString();

//}

//void SerializeArticle(Article article,ref string jsonData)
//{
//    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Article));
//    MemoryStream articleStream= new MemoryStream();
//    jsonSerializer.WriteObject(articleStream, article);
//    articleStream.Position = 0;

//    StreamReader strRead = new StreamReader(articleStream);
//    string json = strRead.ReadToEnd();
//    jsonData = json;
//}
#endregion

#region 
using JsonSerialization;
using System.Text.Json;

List<Kullanici> userList = new List<Kullanici>()
{
    new Kullanici()
    {
        KullaniciID = 1,
        KullaniciAdi = "mucidim58",
        Durum = true,
        LoginInfo = new List<LoginInformation>()
        {
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = true
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-3),
                LoginState = true
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-2),
                LoginState = false
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-1),
                LoginState = false
            }
        }
    },
    new Kullanici()
    {
        KullaniciID = 2,
        KullaniciAdi = "mucidim59",
        Durum = true,
        LoginInfo = new List<LoginInformation>()
        {
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = false
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-3),
                LoginState = true
            },new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-2),
                LoginState = true
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-1),
                LoginState = false
            }
        }
    }
};

var options = new JsonSerializerOptions
{
    WriteIndented = true,
};
string jsonData = JsonSerializer.Serialize(userList,options);
//Console.WriteLine(jsonData);

List<Kullanici> users =  JsonSerializer.Deserialize<List<Kullanici>>(jsonData);  
WriteUsers(users);

void WriteUsers(List<Kullanici>? users)
{
    if (users.Count == 0)
        Console.WriteLine("User Listesi Boş");
    else
    {
        foreach (Kullanici user in users)
        {
            Console.WriteLine($"User ID : {user.KullaniciID}");
            Console.WriteLine($"User Name : {user.KullaniciAdi}");
            Console.WriteLine($"Password : {user.Parola}");
            Console.WriteLine($"State : {user.Durum}");
            Console.WriteLine(new string('*', 100));
        }
    }
}

#endregion