using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks2014.Models
{

    [Table("EmailAddress", Schema = "Person")]
    public class EmailAddress
    {
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
        public string Email_Address { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
