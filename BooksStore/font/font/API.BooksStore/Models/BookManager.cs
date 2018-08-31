using API.BooksStore.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.BooksStore.Models
{
    /***************************************************
     * @Project:      BooksStore
     * @Structure:    API
     * @Title:        BookManager
     * @Description:  Gerente de acesso a dados de 
     *                Livros.
     * @Author:       Ronaldo Torre
     * ------------------------------------------------
     ***************************************************/

    public class BookManager : Manager<Book>, IManager<Book>
    {
        public BookManager(){ }

        public List<Book> GetAll()
        {
            return this.db.Book.OrderBy(b => b.Name).ToList();
        }

        public Book GetById(int id)
        {
            if (id > 0)
            {
                return db.Book.Where(b => b.Id == id).FirstOrDefault();
            }
            else
            {
                throw new Exception("Error occurred in GetById, parameter invalid.");
            }
        }

        public Book GetByName(string name)
        {
            if ((!string.IsNullOrEmpty(name)) || (name != ""))
            {
                return db.Book.Where(b => b.Name == name).FirstOrDefault();
            }
            else
            {
                throw new Exception("Error occurred in GetAllByName, parameter invalid.");
            }
        }

        public List<Book> GetByParameter(string name)
        {
            if ((!string.IsNullOrEmpty(name)) || (name != ""))
            {
                return db.Book.Where(b => b.Name.StartsWith(name)).ToList();
            }
            else
            {
                throw new Exception("Error occurred in GetAllByName, parameter invalid.");
            }
        }

        public bool Insert(Book book)
        {
            if((!string.IsNullOrEmpty(book.Name)) && (!string.IsNullOrEmpty(book.Edition)) &&
               (!string.IsNullOrEmpty(book.Year.ToString())) && (!string.IsNullOrEmpty(book.Publishing))&&
               (!string.IsNullOrEmpty(book.Author)) && (!string.IsNullOrEmpty(book.Price.ToString()))
              )
            {
                if (this.GetByName(book.Name) == null)
                {
                    this.Create(book);
                    this.Save();

                    return true;
                }
                else
                {
                    throw new Exception("Warning: existing record!");
                }
            }
            else
            {
                throw new Exception("Error occurred in Insert, entity invalid.");
            }
        }

        public bool Update(Book book)
        {
            if((book.Id > 0) &&
               (!string.IsNullOrEmpty(book.Name)) && (!string.IsNullOrEmpty(book.Edition)) &&
               (!string.IsNullOrEmpty(book.Year.ToString())) && (!string.IsNullOrEmpty(book.Publishing)) &&
               (!string.IsNullOrEmpty(book.Author)) && (!string.IsNullOrEmpty(book.Price.ToString()))
             )
            {
                this.Change(book);
                this.Save();

                return true;
            }
            else
            {
                throw new Exception("Error occurred in Update, entity invalid.");
            }
        }

        public bool Delete(Book book)
        {
            if((book.Id > 0) || (!string.IsNullOrEmpty(Convert.ToString(book.Id))))
            {
                this.Remove(book);
                this.Save();

                return true;
            }
            else
            {
                throw new Exception("Error occurred in Delete, entity invalid.");
            }
        }

    }
}