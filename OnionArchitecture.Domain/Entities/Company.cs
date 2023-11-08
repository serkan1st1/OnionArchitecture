using OnionArchitecture.Domain.Primitives;

namespace OnionArchitecture.Domain.Entities
{
    public sealed class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public bool Status { get; set; }
        public TimeSpan OrderStartTime { get; set; }
        public TimeSpan OrderFinishTime { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
