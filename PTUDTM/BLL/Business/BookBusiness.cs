using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class BookBusiness
    {
        public BookBusiness()
        {
        }

        public List<book> GetAll()
        {
            List<book> books = Services.book.GetAll();
            return books;

        }

        public book GetByID(long id)
        {
            book book = Services.book.GetByID(id);
            return book;
        }

        public DataTable GetAllDataTable()
        {
            IEnumerable<book> books = Services.book.GetAll();

            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(book));
            for (int i = 0; i < props.Count; i++)
            {

                PropertyDescriptor prop = props[i];

                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);


            }
            object[] values = new object[props.Count];
            foreach (book t in books)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    var x = props[i].GetValue(t);
                    values[i] = x;




                }
                table.Rows.Add(values);
            }
            return table;
        }

        public long Create(book book)
        {
            long id = Services.book.Create(book);
            //1. Tao Book
            //2. Lay ID Book => Neu khong thanh cong return -1;
            if (id == -1)
            {
                return -1;
            }
            else
            {
                moderation_book modbook = new moderation_book();
                modbook.idbook = id;
                modbook.review = false;
                modbook.createdat = modbook.updatedat = DateTime.Now;
                long idmod = Services.modbook.Create(modbook);
                if (idmod == -1)
                {
                    return -1;
                }
                else
                {
                    return id;
                }
                
            }
            //3. Tao Mod Book => Neu khong thanh cong return -1;
            //4. Thang return ID Book
           
        }

        public bool Update(long idbook, book input)
        {
            return Services.book.Update(idbook, input);
        }

        public bool Delete(long idbook)
        {
            return Services.book.Delete(idbook);
        }
    }

  
}
