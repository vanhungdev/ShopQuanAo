﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopQuanAoSolution.Data.Entities
{
    public partial class Product
    {
        public int ID { get; set; }
        public int catid { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string img { get; set; }
        public string detail { get; set; }
        public int sold { get; set; }
        public int number { get; set; }
        public double price { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int? updated_by { get; set; }
        public int status { get; set; }
       
    }
}
