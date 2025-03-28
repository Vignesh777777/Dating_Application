using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Dating_Application.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
