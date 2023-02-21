using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TodoApi.Models{
#nullable disable

  public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Jwt
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }
    }
};
// public class User
// {
//     public User(){
//         Todo = new List<TodoItem>();
//     }
//     [Required]
//     [Key]
//     public int Id { get; set; }
//     [Required]
//     public string UserName { get; set; } = default!;
//     [Required]
//     public string FullName { get; set; } = string.Empty;
//     [Required]
//     public string Password { get; set; } = string.Empty;
//     public List<TodoItem> Todo { get; set; }
// }