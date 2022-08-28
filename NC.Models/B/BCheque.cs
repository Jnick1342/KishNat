using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    
    public class BCheque
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        //[Index("IX_FirstAndSecond", 1, IsUnique = true)]
        public string BankId { get; set; }
        //[Index("IX_FirstAndSecond", 2, IsUnique = true)]
        [StringLength(10)]
        public string SerialNumber { get; set; }
        public AsnadPardakhtaniStatus AsnadPardakhtaniStatus { get; set; }

    }
}
