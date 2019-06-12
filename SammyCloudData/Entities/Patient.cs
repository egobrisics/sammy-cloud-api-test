using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SammyCloudData.Entities
{
    [Table("patients", Schema = "public")]
    public class Patient
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("suffix")]
        public string Suffix { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("gender")]
        public int Gender { get; set; } // just enum???


        //// support ehr races, navigation propeties?
        //public List<RaceConcept> Race { get; set; }

        //// support ehr races, navigation propeties?
        //public List<EthnicityConcept> Ethnicity { get; set; } // support ehr ethnicity
        //                                                  // they may have alternate addresses, (i.e. SnowBird)

        //// support ehr languages, navigation propeties?
        //public Language PreferredLanguage { get; set; }

        //// Graph or inline address?  
        //// an address can be marked as active during a range, i.e. snowbirds
        ////public Address PrimaryAddress { get; set; }
        ////public Address[] Addresses { get; set; } 

        //public List<string> TelephoneNumbers { get; set; } // number, type (i.e. Home, Work, Alternate, Mobile, Work) , default contact



    }
}
