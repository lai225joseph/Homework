using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework.Domain;
using Homework.Service;
using Homework.Repository;

namespace Homework.Test
{
    [TestClass]
    public class UserTest
    {
        private UserContext db = new UserContext();

        [TestMethod]
        public void TestCreate()
        {
            User user = new User();
            user.UserID = Guid.NewGuid();
            user.UserName = "jjj";
            user.Passwork = "jjj";
            user.Birthday = DateTime.Today;
            user.UserEmailAddress = "111@mail.com";
            db.User.Add(user);
            db.SaveChanges();
        }
    }
}
