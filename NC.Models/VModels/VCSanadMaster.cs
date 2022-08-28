using static NC.Models.Tools.Enums;

namespace NC.Models.VModels
{
    public class VCSanadMaster
    {

        public int SanadId { get; set; }



        public string BasicInfoId { get; set; } = "";



        public string GroupSanad { get; set; } = "";
        public int SanadMovaghat { get; set; } = 0;

        public string DateMovaghat { get; set; } = "";



        public string ExpRec { get; set; } = "";

        public KindsOfSanads KindOfSanad { get; set; } = KindsOfSanads.عادی;


        public string KartablOfUserId { get; set; } = "";


        public string DateKartabl { get; set; } = "";



        public string IssueByUserid { get; set; } = "";


        public string IssueDate { get; set; } = "";

        public int ErjaId { get; set; } = 0;

        public string LetterId { get; set; } = "";

        public int SanadAsli { get; set; } = 0;


        public string DateAsli { get; set; } = "";

        public bool isLock { get; set; } = false;



        public double SumBed { get; set; } = 0;

        public double SumBes { get; set; } = 0;

        public string GroupSanadName { get; set; } = "";

        public string BasicInfoName { get; set; } = "";
    }
}
