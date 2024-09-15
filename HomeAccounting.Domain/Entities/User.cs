using HomeAccounting.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccounting.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }

        [NotMapped]
        public string FullName => $"{LastName} {Name} {Patronymic}";

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
