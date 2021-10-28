using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAcces.core.Models
{
    [Table("User")]
    class UserRto
    {
        
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhoneNumberPrefex { get; set; }

        public string PhoneNumber { get; set; }

    }
}
