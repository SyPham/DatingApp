using System.ComponentModel.DataAnnotations.Schema;

namespace DATINGAPP.API.Models
{
    public class User
    {
        public int Id { get; set; }
        [Column("Username")]
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
    }
}