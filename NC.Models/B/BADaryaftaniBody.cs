using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.DBModels
{
    public class BADaryaftaniBody
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("BADaryaftaniMaster")]
        public int MasterId { get; set; }
        public int ChekSerial { get; set; }
        public string DateSarresid { get; set; }
        [StringLength(150)]
        public string BankName { get; set; }
        public string Position { get; set; } = "100";
        [StringLength(100)]
        public string PositionName { get; set; } = "نزد صندوق";
        [StringLength(250)]
        public string ExpCheque { get; set; }
        public virtual BADaryaftaniMaster BADaryaftaniMaster { get; set; }
        public virtual ICollection<BADaryaftaniCycle> BADaryaftaniCyclies { get; set; }
        public virtual ICollection<CBasicInfo> CBasicInfoMaster1 { get; set; }
    }
}
