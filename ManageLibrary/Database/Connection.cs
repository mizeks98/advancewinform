using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.Database
{
    class Connection
    {
        public static ManageLibraryEntities1 connnection;
        public static ManageLibraryEntities1 db
        {
            get
            {
                if (connnection == null)
                {
                    connnection = new ManageLibraryEntities1();
                }
                return connnection;
            }
        }
    }
}
