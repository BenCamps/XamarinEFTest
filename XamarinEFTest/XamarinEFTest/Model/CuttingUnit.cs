using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinEFTest.Model
{
    [Table("CuttingUnit")]
    public class CuttingUnit
    {
        [Key]
        public long? CuttingUnit_CN { get; set; }

        public string Code { get; set; }
        public double Area { get; set; }

        public string CreatedBy { get; set; } = "Default";
    }
}