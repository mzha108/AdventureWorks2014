using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Models
{
    [Table("BusinessEntity", Schema = "Person")]
    public class BusinessEntity:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }
        public Guid rowguid { get; set; }

        [DisplayName("Modified Date")]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }


        public Person Person { get; set; }

    }
}