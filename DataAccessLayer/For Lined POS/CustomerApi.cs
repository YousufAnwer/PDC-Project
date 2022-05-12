using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.For_Lined_POS
{
    class CustomerApi
    {
    }

   

    public class Customer
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string given_name { get; set; }
        public string email_address { get; set; }
        public string phone_number { get; set; }
        public string company_name { get; set; }
        public Preferences preferences { get; set; }
        public string creation_source { get; set; }
        public DateTime birthday { get; set; }
        public int version { get; set; }
    }

    public class Preferences
    {
        public bool email_unsubscribed { get; set; }
    }

}
