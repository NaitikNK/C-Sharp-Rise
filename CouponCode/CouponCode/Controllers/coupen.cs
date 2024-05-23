using CouponCode.context;
using CouponCode.model;
using CouponCode.model.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace CouponCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class coupen : ControllerBase
    {
        private readonly AppDbContext _authContext;

        public coupen(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("coupon")]
        public async Task<IActionResult> GetCoupon([FromBody] CoupenRequestDto request)
        {
            var createdTime = DateTime.Now;

            var coupon = new coupenDb
            {
                coupenCode = GenerateRandomAlphanumericCode(16),
                createdTime = createdTime,
                ExpirationTime = createdTime.AddMinutes(1),
            };

            _authContext.CoupenDbs.Add(coupon);
            await _authContext.SaveChangesAsync();

            return Ok(coupon);
        }

        private static string GenerateRandomAlphanumericCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {

                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }
    }

}