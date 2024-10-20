using System;
using exercicio_generics.Entities;

namespace exercicio_generics.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        void Remove(int Id);
        void Update(T item);

        T GetById(int Id);

        List<T> GetAll();

    }
}
