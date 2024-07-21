namespace MentorApp.Models
{
    public class Service:BaseEntitiy
    {
        public string Name { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
