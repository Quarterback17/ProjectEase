namespace ProjectEaseAPIWebApp.Models
{
    public class Task
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }    
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public virtual Project? Project { get; set; }
        public virtual User? User { get; set; }
        public virtual Status? Status { get; set;}
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
