using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.DBModels
{
   public  class CMask
    {
        [Key]
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Mask { get; set; }

    }
}
