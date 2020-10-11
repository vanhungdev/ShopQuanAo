namespace ShopQuanAo.Models
{
    using System;
    public  class Contact
    {
        public int ID { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
