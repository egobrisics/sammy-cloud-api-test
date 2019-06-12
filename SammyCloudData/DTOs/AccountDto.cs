using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData.DTOs
{
    public class AccountDto
    {
        public int ID { get; set; }
        public int AccountName { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressZipCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string TelephoneExtension { get; set; }
        public string FaxNumber { get; set; }
        public bool Active { get; set; }
        public bool Enabled { get; set; }
    }
}
