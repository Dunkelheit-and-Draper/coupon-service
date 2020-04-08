using System;
using System.Collections.Generic;

namespace CouponService.Domain
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Code { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string VatId { get; set; }
        public User Owner { get; set; }
        public Guid OwnerId { get; set; }
        public List<CouponConfig> CouponConfigs { get; set; }
        public BillingSystemInfo BillingSystemInfo { get; set; }
        public Guid BillingSystemInfoId { get; set; }
    }
}