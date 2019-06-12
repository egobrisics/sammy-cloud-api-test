using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SammyCloudData.Entities
{

    [Table("values", Schema = "public")]
    public class IndexedValue
    {
        [Key, Column("id")]
        public int ID { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
