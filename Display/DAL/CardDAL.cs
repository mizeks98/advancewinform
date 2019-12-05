using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ManageLibrary.DAL;
using ManageLibrary.DataBase;

namespace ManageLibrary.DAL
{
    class CardDAL
    {
        public static void addNewCard(CARD card)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                dtbEntity.CARDS.Add(card);
                dtbEntity.SaveChanges();
                MessageBox.Show("Add successfully!");
            }
        }
    }
}
