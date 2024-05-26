namespace ProjectEaseAPIWebApp.Models
{
    public class Status
    {
        public int Id { get; set; } 
        public string StatusName { get; set; }
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
