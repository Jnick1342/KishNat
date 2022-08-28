using static NC.Models.Tools.Enums;

namespace NC.Models.VModels
{
    public class AsnadTarazView
    {

        public int Id { get; set; }
        public int SanadId { get; set; }
        public string BasicInfoId { get; set; } = "";
        public string DorehName { get; set; } = "";
        public string GroupSanad { get; set; } = "";
        public string GroupName { get; set; } = "";
        public int Radif { get; set; } = 0;
        public int SanadMovaghat { get; set; } = 0;
        public string DateMovaghat { get; set; } = "";
        public double Bed { get; set; } = 0;
        public double Bes { get; set; } = 0;
        public string ExpRec { get; set; } = "";
        public string AccCode { get; set; } = "";
        public string TafsCode { get; set; } = "";
        public string MarCode { get; set; } = "";
        public string AccName { get; set; } = "";
        public string TafsName { get; set; } = "";
        public string MarName { get; set; } = "";
        public int ErjaId { get; set; } = 0;
        public string LetterId { get; set; } = "";
        public string UserId { get; set; } = "";
        public int SanadAsli { get; set; } = 0;
        public string DateAsli { get; set; } = "";
        public bool Protect { get; set; } = false;
        public KindsOfSanads KindOfSanad { get; set; }

        public string AccComment1 { get; set; } = "";
        public string AccComment2 { get; set; } = "";
        public string AccComment3 { get; set; } = "";

        public string TafsComment1 { get; set; } = "";
        public string TafsComment2 { get; set; } = "";
        public string TafsComment3 { get; set; } = "";

        public string MarComment1 { get; set; } = "";
        public string MarComment2 { get; set; } = "";
        public string MarComment3 { get; set; } = "";
        
        public string DateX { get; set; }

        public double MandehBed { get; set; } = 0d;
        public double MandehBes { get; set; } = 0d;


        public double Bed0 { get; set; } = 0d;
        public double Bes0 { get; set; } = 0d;

        public double Bed1 { get; set; } = 0d;
        public double Bes1 { get; set; } = 0d;

        public double Bed2 { get; set; } = 0d;
        public double Bes2 { get; set; } = 0d;

        public double Bed3 { get; set; } = 0d;
        public double Bes3 { get; set; } = 0d;


        public double BBed0 { get; set; } = 0d;
        public double BBes0 { get; set; } = 0d;

        public double BBed1 { get; set; } = 0d;
        public double BBes1 { get; set; } = 0d;

        public double BBed2 { get; set; } = 0d;
        public double BBes2 { get; set; } = 0d;

        public double BBed3 { get; set; } = 0d;
        public double BBes3 { get; set; } = 0d;





        public double MBed0 { get; set; } = 0d;
        public double MBes0 { get; set; } = 0d;

        public double MBed1 { get; set; } = 0d;
        public double MBes1 { get; set; } = 0d;

        public double MBed2 { get; set; } = 0d;
        public double MBes2 { get; set; } = 0d;

        public double MBed3 { get; set; } = 0d;
        public double MBes3 { get; set; } = 0d;


        public double MBBed0 { get; set; } = 0d;
        public double MBBes0 { get; set; } = 0d;

        public double MBBed1 { get; set; } = 0d;
        public double MBBes1 { get; set; } = 0d;

        public double MBBed2 { get; set; } = 0d;
        public double MBBes2 { get; set; } = 0d;

        public double MBBed3 { get; set; } = 0d;
        public double MBBes3 { get; set; } = 0d;
        public double ShowMandehBed
        {
            get
            {
                if (MandehBed > MandehBes)
                    return (MandehBed - MandehBes);
                else
                    return 0;
            }
        }
        public double ShowMandehBes
        {
            get
            {
                if (MandehBes > MandehBed)
                    return (MandehBes - MandehBed);
                else
                    return 0;
            }
        }

    }
}
