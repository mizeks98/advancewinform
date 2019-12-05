using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Handle.DataBase;

namespace Handle.DAL
{
    public static class BookDAL
    {
        public static void addNewBook(BOOK book)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                dtbEntity.BOOKS.Add(book);
                dtbEntity.SaveChanges();
                
            }
        }

        public static void updateBook(BOOK book)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                var tempObject = dtbEntity.BOOKS.SingleOrDefault(n => n.idBook == book.idBook);
                if (tempObject != null)
                {
                    tempObject.nameBook = book.nameBook;
                    tempObject.idAuthor = book.idAuthor;
                    tempObject.idPublisher = book.idPublisher;
                    tempObject.idTypeOfBook = book.idTypeOfBook;
                    tempObject.numberBook = book.numberBook;
                    tempObject.yearRealeas = book.yearRealeas;
                    dtbEntity.SaveChanges();
                    
                }
            }
        }

        public static List<BOOK> getListReader()
        {
            List<BOOK> list = new List<BOOK>();

            list = Connection.db.BOOKS.ToList();

            return list;
        }

        public static void deleteReader(BOOK book)
        {
            using (var dtbEntity = new QLTVEntities1())
            {
                var tempObject = dtbEntity.BOOKS.SingleOrDefault(n => n.idBook == book.idBook);
                if (tempObject != null)
                {
                    dtbEntity.BOOKS.Remove(tempObject);
                    dtbEntity.SaveChanges();
                    
                }
            }
        }
    }
}
