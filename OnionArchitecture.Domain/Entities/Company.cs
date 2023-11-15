using OnionArchitecture.Domain.Primitives;

namespace OnionArchitecture.Domain.Entities
{
    public sealed class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public bool Status { get; set; }
        public int OrderStartTimeHour { get; set; }
        public int OrderStartTimeMinute { get; set; }
        public int OrderFinishTimeHour { get; set; }
        public int OrderFinishTimeMinute { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
