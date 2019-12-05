using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Handle.DataBase;

namespace Handle.DAL
{
    public static class ClassDAL
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
