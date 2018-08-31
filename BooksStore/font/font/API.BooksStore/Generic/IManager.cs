using System.Collections.Generic;

namespace API.BooksStore.Generic
{
    /***************************************************
    * @Project:      BooksStore
    * @Structure:    API
    * @Title:        IManager
    * @Description:  Interface de ações
    * @Author:       Ronaldo Torre
    * ------------------------------------------------
    ***************************************************/

    public interface IManager<E> where E : class
    {
        bool Insert(E entity);
        bool Update(E entity);
        bool Delete(E entity);
        E GetById(int id);
        E GetByName(string name);
        List<E> GetAll();
    }

}