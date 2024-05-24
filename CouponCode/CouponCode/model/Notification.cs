namespace CouponCode.model
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public string MealId { get; set; }
        public DateTime TimeStamp { get; set; }        
    }
}
