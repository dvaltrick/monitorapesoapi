using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Height { get; set; }

        public float Target { get; set; }

        [NotMapped]
        public string Token { get; internal set; }

        public void GenerateId() {
            this.Id = Guid.NewGuid();
        }

    }
}
