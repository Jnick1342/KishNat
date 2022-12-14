using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NC.Models.DBModels
{
    public class CSanadBody
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("CSanadMasters"), ]
        public int SanadId { get; set; }


      




        public double Bed { get; set; } = 0;
        public double Bes { get; set; } = 0;
        [StringLength(250)]
        public string ExpRec { get; set; } = "";


        [StringLength(25)]
        //[ForeignKey("CAccs")]

        public string AccCode { get; set; } = "";


        [StringLength(25)]
        public string TafsCode { get; set; } = "";


        [StringLength(25)]
        public string MarCode { get; set; } = "";


        public int ErjaId { get; set; } = 0;
        [StringLength(50)]
        public string LetterId { get; set; } = "";

        [StringLength(50)]
        public string UserId { get; set; } = "";




        public bool Protect { get; set; } = false;

         public virtual CSanadMaster CSanadMasters { get; set; }
      

        //public virtual CAcc CAccs { get; set; }
        //public virtual CTafs CTafses { get; set; }
        //public virtual CMarkaz CMarkazes { get; set; }
        [NotMapped]

        public string AccName { get; set; } = "";
        [NotMapped]

        public string TafsName { get; set; } = "";
        [NotMapped]
        public string MarName { get; set; } = "";



    }
}
