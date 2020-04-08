namespace CouponService.Domain
{
    public class BillingSystemInfo:BaseEntity
    {
        //REDSYS
        public string DS_MERCHANT_CONSUMERLANGUAGE { get; set; }
        public string DS_MERCHANT_TERMINAL { get; set; }
        public string DS_MERCHANT_MERCHANTCODE { get; set; }
        //PAYPAL
    }
}