using static NC.Models.Tools.Enums;

namespace NC.Models.VModels
{
    public class AccTrazView
    {
        public string XCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; } = "";
        public int Level { get; set; } = 0;
        public LayerEnd End { get; set; } = LayerEnd.خیر;
        public string RCode { get; set; } = "";
        public string Comment1 { get; set; } = "";
        public string Comment2 { get; set; } = "";
        public string Comment3 { get; set; } = "";
        public bool IsOpen { get; set; } = false;
        public bool IsChecked { get; set; } = false;
        public string FullName { get; set; } = "";
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






        public double BedEftetahieh { get; set; } = 0d;
        public double BesEftetahieh { get; set; } = 0d;


        public double BedAmalkard { get; set; } = 0d;
        public double BesAmalkard { get; set; } = 0d;

        public double BedAdy { get; set; } = 0d;
        public double BesAdy { get; set; } = 0d;

        public double BedEkhtetamieh { get; set; } = 0d;
        public double BesEkhtatamieh { get; set; } = 0d;

        public double Bed { get; set; } = 0d;
        public double Bes { get; set; } = 0d;
        public double BeforeBed { get { return BBed0+BBed1+BBed2+BBed3 - (BBes0+BBes1+BBes2+BBes3) > 0 ?   (BBes0 + BBes1 + BBes2 + BBes3)-(BBed0 + BBed1 + BBed2 + BBed3) : 0; } }
        public double BeforeBes { get { return (BBes0 + BBes1 + BBes2 + BBes3)-(BBed0 + BBed1 + BBed2 + BBed3) > 0 ?  (BBed0 + BBed1 + BBed2 + BBed3)- (BBes0 + BBes1 + BBes2 + BBes3) : 0; } }
        public double TeyBed { get { return Bed0 + Bed1 + Bed2 + Bed3 - (Bes0 + Bes1 + Bes2 + Bes3) > 0 ? (Bes0 + Bes1 + Bes2 + Bes3) - (Bed0 + Bed1 + Bed2 + Bed3) : 0; } }
        public double TeyBes { get { return (Bes0 + Bes1 + Bes2 + Bes3) - (Bed0 + Bed1 + Bed2 + Bed3) > 0 ? (Bed0 + Bed1 + Bed2 + Bed3) - (Bes0 + Bes1 + Bes2 + Bes3) : 0; } }
        public double MandehBed { get { return Bed - Bes > 0 ? Bed - Bes : 0; } }
        public double MandehBes { get { return Bes - Bed > 0 ? Bes - Bed : 0; } }
    }
}
