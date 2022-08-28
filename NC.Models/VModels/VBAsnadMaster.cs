using static NC.Models.Tools.Enums;

namespace NC.Models.VModels
{
    public class VBAsnadMaster
    {
        public int Id { get; set; }
        public string DorehId { get; set; }
        public int Serial { get; set; }
        public string Date { get; set; }
        public string Babat { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public string Exprec { get; set; }
        public string IssuseByUserId { get; set; }
        public string IssuseByUserDate { get; set; }
        public string IssuseByUserName { get; set; }
        public int CountItems { get; set; } = 0;
        public long TotalPrice { get; set; } = 0;
    }
}
