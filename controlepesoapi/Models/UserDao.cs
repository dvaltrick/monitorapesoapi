using controlepesoapi.Database;
using controlepesoapi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Models
{
    public class UserDao : IDao<User>
    {
        private ApiDbContext _db;
        private IUserService _userService;

        public UserDao([FromServices] ApiDbContext db, [FromServices] IUserService userService) {
            this._db = db;
            this._userService = userService;
        }

        public User Add(User toSave)
        {
            toSave.GenerateId();
            _db.Users.Add(toSave);
            _db.SaveChanges();

            return toSave;
        }

        public User Auth(User toLoggin) {
            return _userService.Authenticate(_userService, _db, toLoggin.UserName, toLoggin.Password);
        }

        public void Delete(Guid toDelete)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList<User>();
        }

        public User GetOne(Guid toGet)
        {
            throw new NotImplementedException();
        }

        public User Update(User toSave)
        {
            throw new NotImplementedException();
        }
    }
}
