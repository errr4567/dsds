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
    public class UserRto
    {
        #region данные ползв

        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string ImageName { get; set; }
        
        
        [Required] public string PhoneNumberPrefex { get; set; }

        [Required] public string PhoneNumber { get; set; }

        [Required, MinLength(7)] public string Password { get; set; }
        #endregion

        #region Внешние ключи
        public List<VirtualExpenseRto> VirtualExpenses { get; set; }
        public List<RejectExpenseRto> RejectExpenses { get; set; }
        public List<AcceptExpenseRto> AcceptExpenses { get; set; }
        #endregion
    }
}
