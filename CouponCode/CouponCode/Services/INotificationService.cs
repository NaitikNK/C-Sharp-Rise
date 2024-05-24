using CouponCode.model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CouponCode.Services
{
    public interface INotificationService
    {
        Task<Notification> CreateNotification(Notification notification);
        Task<IEnumerable<Notification>> GetAllNotifications();
        Task<Notification> GetNotificationById(int id);
        Task DeleteNotification(int id);
        Task DeleteAllNotifications();
    }
}
