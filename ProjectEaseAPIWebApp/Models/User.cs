namespace ProjectEaseAPIWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
