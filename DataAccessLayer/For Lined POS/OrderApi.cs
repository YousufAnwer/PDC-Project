using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.For_Lined_POS
{
    class OrderApi
    {
    }


    public class Rootobject
    {
        public string idempotency_key { get; set; }
        public Order order { get; set; }
    }

    public class Order
    {
        public string location_id { get; set; }
        public string customer_id { get; set; }
        public Discount[] discounts { get; set; }
        public Line_Items[] line_items { get; set; }
        public Pricing_Options pricing_options { get; set; }
        public Service_Charges[] service_charges { get; set; }
        public Source source { get; set; }
        public string state { get; set; }
        public Tax[] taxes { get; set; }
    }

    public class Pricing_Options
    {
        public bool auto_apply_discounts { get; set; }
        public bool auto_apply_taxes { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
    }

    public class Discount
    {
        public Applied_Money applied_money { get; set; }
        public string name { get; set; }
        public string percentage { get; set; }
        public string scope { get; set; }
        public string type { get; set; }
        public string uid { get; set; }
    }

    public class Applied_Money
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Line_Items
    {
        public string quantity { get; set; }
        public Applied_Taxes[] applied_taxes { get; set; }
        public Base_Price_Money base_price_money { get; set; }
        public string item_type { get; set; }
        public Modifier[] modifiers { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public string variation_name { get; set; }
    }

    public class Base_Price_Money
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Applied_Taxes
    {
        public string tax_uid { get; set; }
        public string uid { get; set; }
    }

    public class Modifier
    {
        public Base_Price_Money1 base_price_money { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
    }

    public class Base_Price_Money1
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Service_Charges
    {
        public Applied_Taxes1[] applied_taxes { get; set; }
        public string calculation_phase { get; set; }
        public string name { get; set; }
        public string percentage { get; set; }
        public bool taxable { get; set; }
        public string uid { get; set; }
    }

    public class Applied_Taxes1
    {
        public string tax_uid { get; set; }
        public string uid { get; set; }
    }

    public class Tax
    {
        public Applied_Money1 applied_money { get; set; }
        public string name { get; set; }
        public string percentage { get; set; }
        public string scope { get; set; }
        public string type { get; set; }
        public string uid { get; set; }
    }

    public class Applied_Money1
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }


}
