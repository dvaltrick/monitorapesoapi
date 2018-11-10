using controlepesoapi.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Models
{
    public class PostDao : IDao<Post>
    {
        private ApiDbContext _db;

        public PostDao([FromServices] ApiDbContext db)
        {
            this._db = db;
        }

        public Post Add(Post toSave)
        {
            toSave.GenerateId();

            toSave.user = _db.Users.Find(toSave.user.Id);

            _db.Posts.Add(toSave);
            _db.SaveChanges();

            return toSave;
        }

        public void Delete(Guid toDelete)
        {
            var toDeletePost = _db.Posts.Find(toDelete);
            _db.Posts.Remove(toDeletePost);
        }

        public List<Post> GetAll()
        {
            return _db.Posts.ToList<Post>();
        }

        public List<Post> GetByUser(Guid id)
        {
            return _db.Posts.Where(us => us.user.Id == id).ToList<Post>();
        }

        public Post GetOne(Guid toGet)
        {
            return _db.Posts.Find(toGet);
        }

        public Post Update(Post toSave)
        {
            _db.Posts.Update(toSave);
            _db.SaveChanges();

            return toSave;
        }
    }
}
