using System;
using System.Security.Principal;
using exercicio_generics.Entities;

namespace exercicio_generics.Repository
{
    public class Repository<T> : IRepository<T> where T: IEntity 
    {
        private readonly List<T> _itens = new List<T>();
        public void Add(T item) 
        {
            _itens.Add(item);
        
        }

        public void Remove(int Id)
        {
            var item = _itens.FirstOrDefault(x => x.Id == Id);
            if (item != null) 
            { 
                _itens.Remove(item);
            }
        }

        public void Update(T item) 
        {
            var index = _itens.FindIndex(i => i.Id == item.Id);
            if (index >= 0) 
            {
                _itens[index] = item;

            }

        }

        public T GetById(int Id)
        {
            return _itens.FirstOrDefault(i => i.Id == Id);

        }


        public List<T> GetAll() 
        {
            return _itens;
        
        }
    }
}