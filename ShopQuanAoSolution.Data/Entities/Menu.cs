namespace ShopQuanAo.Models
{
    using System;
    public  class Menu
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public int parentid { get; set; }
        public int order { get; set; }
        public string position { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
    }
}
