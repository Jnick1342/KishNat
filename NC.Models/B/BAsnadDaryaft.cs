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
    public class BAsnadDaryaft
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Serial { get; set; } = 0;
        public string BasicInfoId { get; set; } = "";
        public string BasicInfoName { get; set; } = "";
        public string GroupSanad { get; set; } = "";
        public string DateSanad { get; set; } = "";
        public int Sanad { get; set; } = 0;
        public GhabzDaryafts GabzDaryaft { get; set; } = GhabzDaryafts.DaryaftAsnad;
        public string DateTime { get; set; } =PersianDateTime.Now.ToShortDateString();
        public string Babat { get; set; } = "";
        public string Owner { get; set; } = "";
        public string ExpRec { get; set; } = "";
        public string LetterNo { get; set; } = "";
        public int ErjaNo { get; set; } = 0;
        public string ConfirmedByUserId { get; set; } = "";
        public string ConfirmedByUserDate { get; set; } = "";
        public string ConfirmedByUser { get; set; } = "";

        public string IssueByUserId { get; set; } = "";
        public string IssueByUser { get; set; } = "";
        public string IssueByDate { get; set; } = "";
        public KartablStatus Kartablstatus { get; set; }= KartablStatus.Register;
        public string KartablstatusDate { get; set; } = "";
        public string KartablstatusUserName { get; set; } = "";
        public bool DeleteStatus { get; set; } = false;
        public virtual ICollection<BAsnadDaryaftBody> BAsnadDaryaftiBodies { get; set; }
        [NotMapped]
        public bool? IsChecked { get; set; } = false;

        [NotMapped]
        public long ControlNumber { get; set; } = 1;
        [NotMapped]
        public long ControlMab { get; set; } = 0;
        [NotMapped]
        public int Controlday { get; set; } = 0;
        [NotMapped]
        public bool SaveButton { get; set; } = false;
        [NotMapped]
        public long SumMab { get; set; } = 0;
    }
}
