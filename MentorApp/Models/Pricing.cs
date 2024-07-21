namespace MentorApp.Models
{
    public class Pricing:BaseEntitiy
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
