using Projeto_RestFull.Model.Base;
using System.Collections.Generic;

namespace TRProjeto_RestFull.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        void Delete(long id);
        T FiendById(long id);
        List<T> FiendAll();
    }
}
