using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.DBModels
{
    public class BADaryaftaniCycle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("BADaryaftaniBody")]
        public int ChekSerial { get; set; }
        [StringLength(10)]
        public string DateAction { get; set; }
        [StringLength(25)]
        public string CodeJabejaii { get; set; }
        [StringLength(100)]
        public string NameJabejaii { get; set; }
        [StringLength(10)]
        public string DateExit  { get; set; } = "100";
        [StringLength(100)]
        public string NameExit { get; set; } = "100";
        [StringLength(100)]
        public string CodeExit { get; set; } = "100";
        public int SanadExit { get; set; } = 0;
        [StringLength(10)]
        public string DateSanadExit { get; set; } = "";
        [StringLength(100)]
        public string PositionName { get; set; } = "نزد صندوق";
        [StringLength(250)]
        public string ExpCheque { get; set; }
        public virtual BADaryaftaniBody BADaryaftaniBody { get; set; }
    }
}
