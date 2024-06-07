using System.ComponentModel.DataAnnotations.Schema;

namespace practice.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
