using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Handle.DataBase;


namespace Handle.DAL
{
    public static class ReaderDAL
    {
        public static void addNewReader(READER reader)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                dtbEntity.READERS.Add(reader);
                dtbEntity.SaveChanges();
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
                  
                }
            }
        }

        public static List<READER> getListReader()
        {
            List<READER> list = new List<READER>();

            list = Connection.db.READERS.ToList();

            return list;
        }

         public static List<READER> getListReader1()
         {
            //var test1 = (from READER in Connection.db.READERS
            //             join CARD in Connection.db.CARDS
            //             on READER.idReader equals CARD.idReader
            //             select new
            //             {
            //                 idReader = READER.idReader,
            //                 idCard = CARD.idCard,
            //                 nameReader = READER.nameReader,
            //                 idClass = READER.idClass,
            //                 sex = READER.sex,
            //                 birthday = READER.birthday,
            //                 realeaseDate = CARD.realeassDate,
            //                 expiryDate = CARD.expiryDate,
            //             }).ToList();
            var test1 = from READER in Connection.db.READERS
                         join CARD in Connection.db.CARDS
                         on READER.idReader equals CARD.idReader
                         select new 
                         {
                             idReader = READER.idReader,
                             _idCard = CARD.idCard,
                             nameReader = READER.nameReader,
                             idClass = READER.idClass,
                             sex = READER.sex,
                             birthday = READER.birthday,
                             address = READER.address,
                             _realeaseDate = CARD.realeassDate,
                             _expiryDate = CARD.expiryDate,
                         };
            var kq = test1.ToList().ConvertAll(t => new READER()
            {
                idReader = t.idReader,
                idCard = t._idCard,
                nameReader = t.nameReader,
                idClass = t.idClass,
                sex = t.sex,
                birthday = t.birthday,
                address = t.address,
                realeaseDate = t._realeaseDate,
                expiryDate = t._expiryDate,
            });
            return kq.ToList<READER>();
        }
        

        public static void deleteReader(READER reader)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                var tempObject = dtbEntity.READERS.SingleOrDefault(n => n.idReader == reader.idReader);
                if (tempObject != null)
                {
                    dtbEntity.READERS.Remove(tempObject);
                    dtbEntity.SaveChanges();
                }
            }
        }
    }
}
