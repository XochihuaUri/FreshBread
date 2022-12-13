using System.ComponentModel.DataAnnotations;


namespace DB
{
    public class Office
    {
        [Key]
        public Guid OfficeId { get; set; }
        public OfficeType OfficeType { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }

    public enum OfficeType
    {
        MainOffice = 1,
        SecondOffice = 2,
    }
}
