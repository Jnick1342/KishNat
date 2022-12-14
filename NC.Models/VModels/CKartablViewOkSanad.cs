using System.ComponentModel.DataAnnotations;

namespace NC.Models.VModel
{
    public class CKartablViewOkSanad
    {


        [StringLength(3)]
        public string BasicInfoId { get; set; } = "";
        public string GroupSanad { get; set; } = "";
        public string GroupName { get; set; } = "";
        public double Bed { get; set; } = 0;
        public double Bes { get; set; } = 0;
        public int Count { get; set; } = 0;
        public string Problem
        {
            get
            {
                return Bed != Bes ? "*** Error ***" : "";
            }

        }
    }
}
