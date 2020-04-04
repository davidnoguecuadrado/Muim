using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Muim.Domain.Models
{
    public class User 
    {
        public int UserId { get; set;}

        [Key]
        public string Name { get; set;}

        public string Password { get; set;}

        public int Tipo { get; set;}

    }
}
