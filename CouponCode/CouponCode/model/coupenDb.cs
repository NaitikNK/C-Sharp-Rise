using System.Security.Cryptography.X509Certificates;

namespace CouponCode.model
{
    public class coupenDb
    {
        public int Id { get; set; }
        public string? coupenCode { get; set; }
        public DateTime? createdTime { get; set; }        
        public DateTime? ExpirationTime { get; set; }
    }
}
