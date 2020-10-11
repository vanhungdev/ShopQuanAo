namespace ShopQuanAo.Models
{
    using System;

    public class OrderDetail
    {
        public int ID { get; set; }
        public int orderid { get; set; }
        public int productid { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int priceSale { get; set; }
        public double amount { get; set; }
    }
}
