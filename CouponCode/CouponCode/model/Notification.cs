namespace CouponCode.model
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; }
    }
}
