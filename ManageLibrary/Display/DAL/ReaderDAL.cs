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
    class ReaderDAL
    {
        public static void addNewReader(READER reader)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                dtbEntity.READERS.Add(reader);
                dtbEntity.SaveChanges();
                MessageBox.Show("Add successfully!");
            }
        }

        public static void updateReader(READER reader)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                var tempObject = dtbEntity.READERS.SingleOrDefault(n => n.idReader == reader.idReader);
                if (tempObject != null)
                {
                    tempObject.nameReader = reader.nameReader;
                    tempObject.idClass = reader.idClass;
                    tempObject.sex = reader.sex;
                    tempObject.address = reader.address;
                    tempObject.birthday = reader.birthday;
                    dtbEntity.SaveChanges();
                    MessageBox.Show("Update successfully!");
                }
            }
        }

        public static List<READER> getListReader()
        {
            List<READER> list = new List<READER>();

            list = Connection.db.READERS.ToList();

            return list;
        }

        /*
         public static List<> getListReader1()
        {
            var test1 = (from READER in Connection.db.READERS
                         join CARD in Connection.db.CARDS
                         on READER.idReader equals CARD.idReader
                         select new
                         {
                             idReader = READER.idReader,
                             idCard = CARD.idCard,
                             nameReader = READER.nameReader,
                             idClass = READER.idClass,
                             sex = READER.sex,
                             birthday = READER.birthday,
                             realeaseDate = CARD.realeassDate,
                             expiryDate = CARD.expiryDate,
                         }).ToList();
            return test1;
        }
        */

        public static void deleteReader(READER reader)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                var tempObject = dtbEntity.READERS.SingleOrDefault(n => n.idReader == reader.idReader);
                if (tempObject != null)
                {
                    dtbEntity.READERS.Remove(tempObject);
                    dtbEntity.SaveChanges();
                    MessageBox.Show("Delete successfully!");
                }
            }
        }
    }
}
