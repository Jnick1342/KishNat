namespace NC.Models.VModels
{
    public class VCSanadBody
    {

        public int Id { get; set; }

        //  [ForeignKey("CSanadMasters"), ]
        public int SanadId { get; set; }
        public string BasicInfoId { get; set; } = "";


        public string GroupSanad { get; set; } = "";
        public int Radif { get; set; } = 0;


        public int SanadMovaghat { get; set; } = 0;

        public string DateMovaghat { get; set; } = "";

        public double Bed { get; set; } = 0;
        public double Bes { get; set; } = 0;

        public string ExpRec { get; set; } = "";




        public string AccCode { get; set; } = "";



        public string TafsCode { get; set; } = "";


        public string MarCode { get; set; } = "";


        public int ErjaId { get; set; } = 0;

        public string LetterId { get; set; } = "";


        public string UserId { get; set; } = "";



        public int SanadAsli { get; set; } = 0;


        public string DateAsli { get; set; } = "";

        public bool Protect { get; set; } = false;



        public string AccName { get; set; } = " ";


        public string TafsName { get; set; } = "";

        public string MarName { get; set; } = "";


        public string Comment1 { get; set; } = " ";


        public string Comment2 { get; set; } = "";

        public string Comment3 { get; set; } = "";

    }
}
