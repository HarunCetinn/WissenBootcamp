// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using KurumsalMimari;

//int dbTYpe = 1;

//if(dbTYpe == 1)
//{
//    MSSQLOperations sqlServer = new MSSQLOperations();
//    sqlServer.Insert();
//    sqlServer.Update();
//    sqlServer.Delete();
//    sqlServer.Read();
//}
//else if(dbTYpe == 2)
//{
//    OracleOperatiıns oracleServer = new OracleOperatiıns();
//    oracleServer.Insert();
//    oracleServer.Update();
//    oracleServer.Delete();
//    oracleServer.Read();
//}


// ÇOK BİÇİMLİLİK POLİMORFİZM ÖRNEĞİ
DbOPerationsManager dbOpSQL = new DbOPerationsManager(new MSSQLOperations());
dbOpSQL.Insert();
dbOpSQL.Update();
dbOpSQL.Delete();
dbOpSQL.Read();


Console.WriteLine(new string('-', 100));

DbOPerationsManager dbOracle = new DbOPerationsManager(new OracleOperatiıns());
dbOracle.Insert();
dbOracle.Update();
dbOracle.Delete();
dbOracle.Read();

