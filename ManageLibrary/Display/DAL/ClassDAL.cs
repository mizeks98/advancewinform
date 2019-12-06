using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageLibrary.DAL;
using ManageLibrary.DataBase;

namespace ManageLibrary.DAL
{
    class ClassDAL
    {
        public static List<CLASS> getListReader()
        {
            List<CLASS> list = new List<CLASS>();
            using (var dtbEntity = new QLTVEntities1())
            {
                list = dtbEntity.CLASSES.ToList();
            }
            return list;
        }
    }
}
