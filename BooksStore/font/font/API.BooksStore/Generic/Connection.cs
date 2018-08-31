using API.BooksStore.Models;
using System.Data.Entity;

namespace API.BooksStore.Generic
{
 
    /***************************************************
    * @Project:      BooksStore
    * @Structure:    API
    * @Title:        Connection
    * @Description:  Contexto de acesso a dados
    * @Author:       Ronaldo Torre
    * ------------------------------------------------
    ***************************************************/

    public class Connection: DbContext
    {

        public Connection() : base("ConnectionDB")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public new IDbSet<E> Set<E>() where E : class
        {
            return base.Set<E>();
        }

        public DbSet<Book> Book { get; set; }
        
    }
}