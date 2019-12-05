using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageLibrary.DAL;
using ManageLibrary.DataBase;

namespace ManageLibrary.DataBase
{
    class Connection
    {
        public static QLTVEntities1 connnection;
        public static QLTVEntities1 db
        {
            get
            {
                if (connnection == null)
                {
                    connnection = new QLTVEntities1();
                }
                return connnection;
            }
        }
    }
}
