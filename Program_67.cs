using E_Bussiness_Command;

public class Program
{
    private static void Main(string[] args)
    {
        Database database = new Database(15.3, "MySQL");
        IDataBase database1 = new Save();
        database1.setDatabase(database);
        database1.Execute();
        database1.Repeat(); 
        database1.show();   

        IDataBase database2 = new Update();
        database2.setDatabase(database);
        database2.Execute();    
        database2.Revoke(); 

        IDataBase database3 = new Delete();
        database3.setDatabase(database);    
        database3.Execute();
        database3.show();
        database3.Revoke();
        
    }
}