using System;

namespace CouponService.Domain
{
    public class Coupon:BaseEntity
    {
        public CouponConfig CouponConfig { get; set; }
        public double Amount { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsValid { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsPaid { get; set; }
    }
}