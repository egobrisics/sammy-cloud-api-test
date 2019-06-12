using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SammyCloudData.Entities
{
    [Table("languages")]
    public class Language: ICodedValue
    {
        
        [Key,Column("id")]
        public int id { get; set; }

        [Column("code")]
        public string Code { get; set; }
        [Column("value")]
        public string Value { get; set; }
    }
}
