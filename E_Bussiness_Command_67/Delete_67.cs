using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Command
{
    public class Delete: IDataBase
    {
        Database database;
        private double temp_Version;
        private string name_temp;


        public void Execute()
        {
            Console.WriteLine("UYARI : Veri tabanini silmek istedignize eminmisiniz?");
            Console.WriteLine("1.Evet \n2.Hayir ");
            Console.WriteLine("Secim  :");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number ==1 )
            {
                Console.WriteLine("Veri Tabani Siliniyor....");
                temp_Version = database.version;
                name_temp = database.name;
                database.name = null;
                database.version = 0;
                Console.WriteLine("Veri Tabani Basariyla Silindi");
            }
            else
            {
                Console.WriteLine("Islem Iptal Ediliyor .... ");
                Console.WriteLine("Islem Iptal Edildi");
            }
            
        }

        public void Repeat()
        {

            Console.WriteLine("Tekrar Et ");
            Execute();
        }

        public void Revoke()
        {
            Console.WriteLine("Islem Geri Aliniyor");
            database.version = temp_Version;    
            database.name = name_temp;
            Console.WriteLine("Islem Geri ALindi");
            show();
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
