using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public User user { get; set; }

        public float weight { get; set; }

        public DateTime date { get; set; }

        public void GenerateId()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
