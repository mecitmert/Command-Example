using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Command
{
    public class Database
    {
      public  double version;
       public String name;
        public Database(double version , string name) 
        {
            this.version = version; 
            this.name = name;   
        }   
    }
}
