using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SammyCloudData.Entities
{
    [Table("accounts", Schema = "public")]
    public class Account
    {
        [Key, Column("id")]
        public int ID { get; set; }

        [Column("account_name"), Required(AllowEmptyStrings = false)]
        public int AccountName { get; set; }

        [Column("billing_addr_1"), Required(AllowEmptyStrings = false)]
        public string BillingAddressLine1 { get; set; }


        [Column("billing_addr_2"), Required(AllowEmptyStrings = true)]
        public string BillingAddressLine2 { get; set; }

        [Column("billing_city"), Required(AllowEmptyStrings = false)]
        public string BillingAddressCity { get; set; }

        [Column("billing_state"), Required(AllowEmptyStrings = false)]
        public string BillingAddressState { get; set; }

        [Column("billing_zipcode"), Required(AllowEmptyStrings = false)]
        public string BillingAddressZipCode { get; set; }

        [Column("contact_phone"), Required(AllowEmptyStrings = false)]
        public string TelephoneNumber { get; set; }

        [Column("contact_phone_ext")]
        public string TelephoneExtension { get; set; }

        [Column("contact_fax"), Required(AllowEmptyStrings = false)]
        public string FaxNumber { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }




    }
}
