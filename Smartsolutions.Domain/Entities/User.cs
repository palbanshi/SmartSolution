
using System.ComponentModel.DataAnnotations;

namespace Smartsolutions.Domain.Entities
{
    public class User
    {
        public int Id;
        public string Name { get; set; }=default!;
        public string Email { get; set; } = default!;
        public string password { get; set; } = default!;
        public Adress ? address { get; set; }

    }
}
