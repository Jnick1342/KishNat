namespace NC.Models.VModels
{
    public class VBAsnadBody
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int ChekSerial { get; set; }
        public string DateSarresid { get; set; }
        public string BankName { get; set; }
        public string Position { get; set; } = "100";
        public string PositionName { get; set; } = "نزد صندوق";
        public string ExpCheque { get; set; }
    }
}
