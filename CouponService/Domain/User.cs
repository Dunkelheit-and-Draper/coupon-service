using System;

namespace CouponService.Domain
{
    public class User:BaseEntity
    {
        public Company Company { get; set; }
        public Guid? CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
    }
}