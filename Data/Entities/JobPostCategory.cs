namespace jobPortalAPI.Data.Entities
{
    public class JobPostCategory : BaseEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string EeType { get; set; }
    }
}