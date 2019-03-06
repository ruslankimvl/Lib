using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    class ReaderService
    {
        public void CreateNewBookReader(Reader reader)
        {
            BookService.CreateBook(reader);
        }
        public void FindBook()
        {
            BookService.SearchBook();
        }

    }
}
