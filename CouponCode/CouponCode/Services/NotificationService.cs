using CouponCode.context;
using CouponCode.model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CouponCode.Services
{
    public class NotificationService : INotificationService
    {
        private readonly AppDbContext _appDbContext;

        public NotificationService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Notification> CreateNotification(Notification notification)
        {
            _appDbContext.Notifications.Add(notification);
            await _appDbContext.SaveChangesAsync();
            return notification;
        }

        public async Task<IEnumerable<Notification>> GetAllNotifications()
        {
            return await _appDbContext.Notifications.ToListAsync();
        }

        public async Task<Notification> GetNotificationById(int id)
        {
            return await _appDbContext.Notifications.FindAsync(id);
        }

        public async Task DeleteNotification(int id)
        {
            var notification = await _appDbContext.Notifications.FindAsync(id);
            if (notification != null)
            {
                _appDbContext.Notifications.Remove(notification);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAllNotifications()
        {
            _appDbContext.Notifications.RemoveRange(_appDbContext.Notifications);
            await _appDbContext.SaveChangesAsync();
        }
    }
}