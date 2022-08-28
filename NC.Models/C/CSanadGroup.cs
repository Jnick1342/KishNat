using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NC.Models.DBModels
{
    public class CSanadGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; } = "";

    
        public virtual ICollection<CSanadMaster> CSanadMasters { get; set; }
        public virtual ICollection<CSanadMasterOk> CSanadMastersOk { get; set; }
         
    }
}
