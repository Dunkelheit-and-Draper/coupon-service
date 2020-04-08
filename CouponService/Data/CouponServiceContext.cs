using CouponService.Domain;
using Microsoft.EntityFrameworkCore;

namespace CouponService.Data
{
    public class CouponServiceContext:DbContext
    {
        public CouponServiceContext(DbContextOptions<CouponServiceContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<BillingSystemInfo> BillingSystemInfos { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponConfig> CouponConfigs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}