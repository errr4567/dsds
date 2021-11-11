using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Albina.DataAcces.core.Enums;

namespace Albina.DataAcces.core.Models
{
    [Table("RejectExpense")]
    public class RejectExpenseRto

    {
        [Key] public int Id { get; set; }
        public float Cost { get; set; }

        public CostCurrencyRto CostCurrency { get; set; }
        public string WhereSpend { get; set; }
        public DateTimeOffset CreateDateTime { get; set; }
        public DateTimeOffset RejectDateTime { get; set; }

        public int AuthorId { get; set; }



    }
}
