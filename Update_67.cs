using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Command
{
    internal class Update : IDataBase
    {
        private const int end_versiyon = 22;
        Database database;
        double temp;
        public void Execute()
        {
            Console.WriteLine("Guncelleme Kontrol ediliyor...");
            if (database.version == end_versiyon)
                Console.WriteLine("Zaten en guncel durumda");
            else
            {
                Console.WriteLine("Guncelleme Mevcut");
                Console.WriteLine("Guncelleniyor...");
                temp = database.version;
                database.version = end_versiyon;
                Console.WriteLine("Basariyla Guncelledendi : versiyon--" + database.version);
            }
        }

        public void Repeat()
        {
            Execute();
        }

        public void Revoke()
        {
            Console.WriteLine("Islem Iptal talebi:");
            Console.WriteLine("Islem Geri Aliniyor...");
            database.version = temp;

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
