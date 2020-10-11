namespace ShopQuanAo.Models
{
    using System;
    public class Slider
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string position { get; set; }
        public string img { get; set; }
        public int orders { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
