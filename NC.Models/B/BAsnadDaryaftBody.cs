using MD.PersianDateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class BAsnadDaryaftBody
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("BAsnadDaryaft")]
        public int Serial { get; set; } = 0;
        public int ChkSerial { get; set; } = 0;
        public long  Mab { get; set; } = 0;
        public string DateSarresid { get; set; } = PersianDateTime.Now.ToShortDateString();
        public string BankName { get; set; } = "";
        public string ExitCode { get; set; } = "";
        public string DateExit { get; set; } = "";
        public int Sanad { get; set; } = 0;
        public string DateTime { get; set; } =PersianDateTime.Now.ToShortDateString();
        public string Comment { get; set; } = "";
        
        public string ConfirmedByUserId { get; set; } = "";
        public string ConfirmedByUserDate { get; set; } = "";
        public string ConfirmedByUser { get; set; } = "";
        public virtual BAsnadDaryaft BAsnadDaryaft { get; set; }

    }
}
