namespace ShopQuanAo.Models
{
    using System;
    public  class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int parentid { get; set; }
        public int orders { get; set; }
        public string? metakey { get; set; }
        public string? metadesc { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
