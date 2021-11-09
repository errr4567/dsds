using Albina.DataAcces.core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAcces.core.Models
{
    [Table("VirtualExpenseRto")]
   public class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }
        public float Cost { get; set; }

        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExpenseStatusRto Status { get; set; }

        public DateTimeOffset CreateDataTime { get; set; }
        public List<DateTimeOffset> ChangeDataTimes { get; set; }
    }
}
