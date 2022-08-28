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
    public class BBankDaryaft
    {
        [Key]
        public int Id { get; set; }
        public int Serial { get; set; } = 0;
        [StringLength(3)]
        public string BasicInfoId { get; set; } = "";
        [StringLength(100)]
        public string BasicInfoName { get; set; } = "";
        [StringLength(25)]
        public string GroupSanad { get; set; } = "";
        [StringLength(10)]
        public string DateSanad { get; set; } = "";

        public int Sanad { get; set; } = 0;
        public GhabzDaryafts GabzDaryaft { get; set; } = GhabzDaryafts.DaryaftBank;
        [StringLength(10)]
        public string DateTime { get; set; } =PersianDateTime.Now.ToShortDateString();
        public long Price { get; set; } = 0;
        [StringLength(150)]
        public string PriceToString { get; set; } = "";
        [StringLength(10)]
        public string FishNo_CheckNo { get; set; } = "";
        [StringLength(10)]
        public string FishDate_CheckSarresid { get; set; } =PersianDateTime.Now.ToShortDateString();
        [StringLength(250)]
        public string Babat { get; set; } = "";
        [StringLength(250)]
        public string Owner { get; set; } = "";
        [StringLength(25)]
        public string BankCode { get; set; } = "";
        [StringLength(150)]
        public string BankName { get; set; } = "";
        [StringLength(250)]
        public string ExpRec { get; set; } = "";
        [StringLength(50)]
        public string LetterNo { get; set; } = "";
        public int ErjaNo { get; set; } = 0;
        [StringLength(50)]
        public string ConfirmedByUserId { get; set; } = "";
        [StringLength(50)]
        public string ConfirmedByUserDate { get; set; } = "";
        [StringLength(150)]
        public string ConfirmedByUser { get; set; } = "";
        [StringLength(50)]
        public string IssueByUserId { get; set; } = "";
        [StringLength(150)]
        public string IssueByUser { get; set; } = "";
        [StringLength(50)]
        public string IssueByDate { get; set; } = "";
        public KartablStatus Kartablstatus { get; set; }= KartablStatus.Register;
        [StringLength(50)]
        public string KartablstatusDate { get; set; } = "";
        [StringLength(150)]
        public string KartablstatusUserName { get; set; } = "";
        public bool DeleteStatus { get; set; } = false;
        public int ChekTypes { get; set; } = 0;
        [NotMapped]
        public bool? IsChecked { get; set; } = false;


    }
}
