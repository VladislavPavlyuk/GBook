using Humanizer.Localisation;
using GBook.Models;
using System.ComponentModel.DataAnnotations;

namespace GBook.Models
{
    public class Messages
    {   
        public int Id { get; set; }        
        public int? Id_User { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
        virtual public User User { get; set; }
    }
}
