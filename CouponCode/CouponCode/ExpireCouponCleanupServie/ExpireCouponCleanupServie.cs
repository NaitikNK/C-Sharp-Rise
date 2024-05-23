using CouponCode.context;

namespace CouponCode.ExpireCouponCleanupServie
{
    public class ExpireCouponCleanupServie : IHostedService,IDisposable
    {
        private readonly IServiceProvider _serviceProvider;
        private Timer _timer;

        public ExpireCouponCleanupServie(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {   
            _timer = new Timer(DeleteExpiredCoupons, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
            return Task.CompletedTask;
        }

        private async void DeleteExpiredCoupons(object state)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var expiredCoupons = context.CoupenDbs.Where(c => c.ExpirationTime <= DateTime.Now).ToList();

                if (expiredCoupons.Any())
                {
                    context.CoupenDbs.RemoveRange(expiredCoupons);
                    await context.SaveChangesAsync();
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

    }
}
