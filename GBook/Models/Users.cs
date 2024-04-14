namespace GBook.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Password { get; set; }

        public string? Salt { get; set; }
        public Users()
        {
            this.Messages = new HashSet<Messages>();
        }
        public ICollection<Messages>? Messages { get; set; }

    }
}