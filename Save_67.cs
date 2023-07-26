using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Command
{
    internal class Save : IDataBase
    {
        Database database;
        public void Execute()
        {
            Console.WriteLine("Kayit Islmei:");
            Console.WriteLine("Veri Tabani Kaydediliyor...");
            Console.WriteLine("Veri Tabani Basariyla Kaydedildi");
        }

        public void Repeat()
        {
            Console.WriteLine("Tekrar Et");
            Execute();
        }

        public void Revoke()
        {
            Console.WriteLine("Iptal Islemi :");
            Console.WriteLine("Iptal Ediliyor....");
            Console.WriteLine("Iptal Edildi.");
        }

        public void setDatabase(Database database)
        {
            this.database = database;
        }
        public void show()
        {
            Console.WriteLine(database.name + "version -  " + database.version);
        }
    }
}
