using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SammyCloudData.Entities
{
    [Table("users", Schema = "public")]
    public class User
    {
        [Key, Column("id")]
        public int ID { get; set; }

        [Column("account_id")]
        public int AccountID { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}
