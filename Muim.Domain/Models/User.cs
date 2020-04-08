using System.ComponentModel.DataAnnotations;

namespace Muim.Domain.Models
{
    public class User 
    {
       [Key]
       public int UserId { get; set;}

       public string Name { get; set;}

       public string Password { get; set;}

       public int Tipo { get; set;}

    }
}
