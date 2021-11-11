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
    [Table("AcceptExpense")]
    public class AcceptExpenseRto
    {
        [Key] public int Id { get; set; }

        public float Cost { get; set; }

        public int AuthorId { get; set; }
        public string WhereSpend { get; set; }

        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExpenseStatusRto Status { get; set; }

        public DateTimeOffset CreateDataTime { get; set; }
        public List<DateTimeOffset> ChangeDataTimes { get; set; }
    }
}
