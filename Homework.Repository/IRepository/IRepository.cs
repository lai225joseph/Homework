using Homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Repository
{
    public interface IRepository<Entity> : IDisposable
        where Entity : class
    {
        void Create(Entity instance);

        void Edit(Entity instance);

        void Delete(Guid id);

        User Get(Guid id);

        IQueryable<Entity> Index();
    }
}
