using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks2014.Models
{

    [Table("Person", Schema = "Person")]

    public class Person : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("BusinessEntityId")]
        public int BusinessEntityId { get; set; }

        public string PersonType { get; set; }
        public bool NameStyle { get; set; } = false;

        public string Title { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Suffix { get; set; }

        [DisplayName("Email")]
        public int EmailPromotion { get; set; } = 0;
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; } = Guid.NewGuid();

        [DisplayName("Modified Date")]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; } = DateTime.Today;



        public BusinessEntity BusinessEntity { get; set; }
        public Employee Employee { get; set; }
        public EmailAddress EmailAddress { get; set; }
    }

}
