using System.ComponentModel.DataAnnotations;
using static NC.Models.Tools.Enums;

namespace NC.Models.VModel
{
    public class CKartablView
    {
        public int SanadId { get; set; }
        [StringLength(3)]
        public string BasicInfoId { get; set; } = "";
        [StringLength(25)]
        public string GroupSanad { get; set; } = "";
        public int SanadMovaghat { get; set; } = 0;
        [StringLength(10)]
        public string DateMovaghat { get; set; } = "";

        [StringLength(250)]
        public string ExpRec { get; set; } = "";

        public KindsOfSanads KindOfSanad { get; set; }

        [StringLength(50)]
        public string KartablOfUserId { get; set; } = "";

        [StringLength(40)]
        public string DateKartabl { get; set; } = "";


        [StringLength(50)]
        public string IssueByUserid { get; set; } = "";

        [StringLength(40)]
        public string IssueDate { get; set; } = "";

        public int ErjaId { get; set; } = 0;
        [StringLength(50)]
        public string LetterId { get; set; } = "";

        public int SanadAsli { get; set; } = 0;

        [StringLength(10)]
        public string DateAsli { get; set; } = "";

        public bool isLock { get; set; } = false;

        //public virtual ICollection<CSanadBody> CSanadBodies { get; set; }


        public double Bed { get; set; } = 0;

        public double Bes { get; set; } = 0;

        public string Problem
        {
            get
            {
                return Bed != Bes ? "*** Error ***" : "";
            }

        }
    }
}
