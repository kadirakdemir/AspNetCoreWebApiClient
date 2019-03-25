namespace AspNetCoreWebApi.Client.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
