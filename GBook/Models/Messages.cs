using Humanizer.Localisation;
using GBook.Models;
using System.ComponentModel.DataAnnotations;

namespace GBook.Models
{
    public class Messages
    {   
        public int Id { get; set; }        
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateOnly MessageDate { get; set; }
        public User? User { get; set; }
        
    }
}
