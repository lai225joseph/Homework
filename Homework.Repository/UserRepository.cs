using Homework.Service;
using Homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Homework.Repository
{
    public class UserRepository
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
    }
}
