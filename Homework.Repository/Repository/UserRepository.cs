using Homework.Service;
using Homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Homework.Repository;

namespace Homework.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserContext db;

        public UserRepository(UserContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> Index()
        {
            return db.User.ToList();
        }

        public void Create(User user)
        {
            user.UserID = Guid.NewGuid();
            db.User.Add(user);
            db.SaveChanges();
        }

        public void Edit(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
            db.SaveChanges();
        }


        public void Update(User instance)
        {
            db.Entry(instance).State = EntityState.Modified;
            db.SaveChanges();
        }

        public User Get(Guid id)
        {
            return db.User.Find(id);
        }

        IQueryable<User> IRepository<User>.Index()
        {
            return db.User.AsQueryable();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
