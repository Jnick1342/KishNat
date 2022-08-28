using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class CSanadMasterOk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SanadId { get; set; }


        [StringLength(3)]
        [ForeignKey("CBasicInfoMasterOk")]
        public string BasicInfoId { get; set; } = "";


        [StringLength(25)]
        [ForeignKey("CSanadGroupMasterOk")]
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

        public virtual ICollection<CSanadBodyOk> CSanadBodiesOk { get; set; }
        public virtual CBasicInfo CBasicInfoMasterOk { get; set; }
        public virtual CSanadGroup CSanadGroupMasterOk { get; set; }

        [NotMapped]
        public double Bed { get; set; } = 0;
        [NotMapped]
        public double Bes { get; set; } = 0;
    }
}
