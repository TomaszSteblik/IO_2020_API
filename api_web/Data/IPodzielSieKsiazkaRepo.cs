using System.Collections;
using System.Collections.Generic;
using api.Models;

namespace api.Data
{
    public interface IPodzielSieKsiazkaRepo
    {
        bool SaveChanges();

        IEnumerable<Book> SearchBooks(string regexString,List<CategoryOfBook> categoriesOfBook,double longitude, double latitude, double radius);
        Book GetBookById(int id);
        void AddBook(Book book);
        
        User GetUserById(int id);
        User GetUserByLoginId(string loginId);
        void AddUser(User user);

        Transaction GetTransactionById(int id);
        void AddTransaction(Transaction transaction);
        IEnumerable<Transaction> GetAllTransactionsByUserId(int id);
    }
}
