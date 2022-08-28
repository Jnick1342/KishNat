using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.DBModels
{
    public class BADaryaftaniMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(3)]
        [ForeignKey("CBasicInfoMaster")]
        public string DorehId { get; set; }
        public int Serial { get; set; }
        [StringLength(10)]
        public string Date { get; set; }
        [StringLength(250)]
        public string Babat { get; set; }
        [StringLength(150)]
        public string Owner { get; set; }
        [StringLength(250)]
        public string Status { get; set; }
        [StringLength(500)]
        public string Exprec { get; set; }
        [StringLength(25)]
        public string IssuseByUserId { get; set; }
        [StringLength(50)]
        public string IssuseByUserDate { get; set; }
        [StringLength(150)]
        public string IssuseByUserName { get; set; }
        public virtual ICollection<BADaryaftaniBody> BADaryaftaniBodies { get; set; }
        public virtual ICollection<CBasicInfo> CBasicInfoMaster { get; set; }
    }
}
