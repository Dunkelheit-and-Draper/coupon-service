using System;
using System.Collections.Generic;

namespace CouponService.Domain
{
    public class CouponConfig:BaseEntity
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Coupon> Coupons { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ExpirationIntervalCount { get; set; }
        public DateTimeUnit ExpirationIntervalUnit { get; set; }
        public string EmailSubject { get; set; }
        public string GreetingsMessage { get; set; }
    }
}