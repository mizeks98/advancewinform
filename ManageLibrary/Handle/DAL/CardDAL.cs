using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Handle.DataBase;

namespace Handle.DAL
{
    public static class CardDAL
    {
        public static void addNewCard(CARD card)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                dtbEntity.CARDS.Add(card);
                dtbEntity.SaveChanges();
                
            }
        }
    }
}
