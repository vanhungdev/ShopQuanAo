namespace ShopQuanAo.Models
{
    using System;
    public  class Order
    {
        public int ID { get; set; }
        public int code { get; set; }
        public int userid { get; set; }
        public DateTime created_ate { get; set; }
        public DateTime? exportdate { get; set; }
        public string deliveryaddress { get; set; }
        public string deliveryname { get; set; }
        public string deliveryphone { get; set; }
        public string deliveryemail { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
