using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class EmailAddressService : BaseService<EmailAddress>
    {
        public EmailAddressService(AdventureContext db) : base(db)
        {
            
        }

    }
}
