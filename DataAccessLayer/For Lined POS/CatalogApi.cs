using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.For_Lined_POS
{
    class CatalogApi
    {
    }



    public class Catalog_Object
    {
        public string type { get; set; }
        public string id { get; set; }
        public DateTime updated_at { get; set; }
        public long version { get; set; }
        public bool is_deleted { get; set; }
        public bool present_at_all_locations { get; set; }
        public Item_Data item_data { get; set; }
    }

    public class Item_Data
    {
        public string name { get; set; }
        public string description { get; set; }
        public string abbreviation { get; set; }
        public Variation[] variations { get; set; }
        public string product_type { get; set; }
    }

    public class Variation
    {
        public string type { get; set; }
        public string id { get; set; }
        public DateTime updated_at { get; set; }
        public long version { get; set; }
        public bool is_deleted { get; set; }
        public bool present_at_all_locations { get; set; }
        public Item_Variation_Data item_variation_data { get; set; }
    }

    public class Item_Variation_Data
    {
        public string item_id { get; set; }
        public string name { get; set; }
        public int ordinal { get; set; }
        public string pricing_type { get; set; }
        public Price_Money price_money { get; set; }
        public bool stockable { get; set; }
    }

    public class Price_Money
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Id_Mappings
    {
        public string client_object_id { get; set; }
        public string object_id { get; set; }
    }

    /*======================================================*/


  




}
