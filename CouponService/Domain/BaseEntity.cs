using System;

namespace CouponService.Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            Id=new Guid();
            ModificationDate = DateTime.Now;
            CreationDate=DateTime.Now;
            IsDeleted = false;
        }
    }
}