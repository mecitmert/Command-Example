using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Command
{
    public  interface IDataBase
    {
        public void show();
        public void setDatabase(Database database);
        public void Execute();
        public void Repeat();
        public void Revoke();



    }
}
