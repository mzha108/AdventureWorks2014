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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityId { get; set; }
        public Guid rowguid { get; set; } = Guid.NewGuid();

        [DisplayName("Modified Date")]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; } = DateTime.Today;


        public Person Person { get; set; }

    }
}