using CouponCode.context;
using CouponCode.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CouponCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public NotificationController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }           
        

        [HttpGet]
        public async Task<IActionResult> HandleNotifications(
        [FromQuery] string? userId = null,
        [FromQuery] int? markAsReadId = null,
        [FromQuery] string? createUserId = null,
        [FromQuery] string? message = null)
        {
            // Get notifications for a user
            if (!string.IsNullOrEmpty(userId))
            {
                var notifications = await _appDbContext.notifications
                    .Where(n => n.UserId == userId && !n.IsRead)
                    .ToListAsync();
                return Ok(notifications);
            }

            // Mark a notification as read
            if (markAsReadId.HasValue)
            {
                var notification = await _appDbContext.notifications.FindAsync(markAsReadId.Value);
                if (notification == null)
                {
                    return NotFound();
                }

                notification.IsRead = true;
                await _appDbContext.SaveChangesAsync();
                return NoContent();
            }

            // Create a new notification
            if (!string.IsNullOrEmpty(createUserId) && !string.IsNullOrEmpty(message))
            {
                var notification = new Notification
                {
                    UserId = createUserId,
                    Message = message,
                    TimeStamp = DateTime.Now,
                    IsRead = false
                };

                _appDbContext.notifications.Add(notification);
                await _appDbContext.SaveChangesAsync();

                return CreatedAtAction(nameof(HandleNotifications), new { userId = createUserId }, notification);
            }

            return BadRequest("Invalid parameters provided.");
        }

    }
}
