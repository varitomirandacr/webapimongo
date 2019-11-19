using System.Collections.Generic;
using WebApiMongo.Models;

namespace WebApiMongo.Contracts
{
    public interface IBookService
    {
        Book Create(Book book);
        List<Book> Get();
        Book Get(string id);
        void Remove(Book bookIn);
        void Remove(string id);
        void Update(string id, Book bookIn);
    }
}