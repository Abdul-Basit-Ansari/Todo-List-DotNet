using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;
#nullable disable
public class TodoItem
{
     [Required]
     [Key]
    public int Id { get; set; }
     [Required]
    public string Title { get; set; }
     [Required]
    public string Desc { get; set; }
     [Required]
    //  [ForeignKey("User")]
    //  public int UserId { get; set; }
    //  [Required]
    public bool IsComplete { get; set; }

    // public virtual User User { get; set; }
}