using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.For_Lined_POS
{
    class InvoivceApi
    {
    }




    public class Invoice
    {
        public string id { get; set; }
        public int version { get; set; }
        public string location_id { get; set; }
        public string order_id { get; set; }
        public Payment_Requests[] payment_requests { get; set; }
        public string invoice_number { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public string timezone { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Primary_Recipient primary_recipient { get; set; }
        public Accepted_Payment_Methods accepted_payment_methods { get; set; }
        public Custom_Fields[] custom_fields { get; set; }
        public string delivery_method { get; set; }
    }

    public class Primary_Recipient
    {
        public string customer_id { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string email_address { get; set; }
        public string phone_number { get; set; }
        public string company_name { get; set; }
    }

    public class Accepted_Payment_Methods
    {
        public bool card { get; set; }
        public bool square_gift_card { get; set; }
        public bool bank_account { get; set; }
    }

    public class Payment_Requests
    {
        public string uid { get; set; }
        public string request_type { get; set; }
        public string due_date { get; set; }
        public bool tipping_enabled { get; set; }
        public Computed_Amount_Money computed_amount_money { get; set; }
        public Total_Completed_Amount_Money total_completed_amount_money { get; set; }
        public string automatic_payment_source { get; set; }
    }

    public class Computed_Amount_Money
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Total_Completed_Amount_Money
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Custom_Fields
    {
        public string label { get; set; }
        public string value { get; set; }
        public string placement { get; set; }
    }

}
