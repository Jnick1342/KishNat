using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class BBabatDaryaft
    {
        [Key]
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; } = "";
        public int Level { get; set; } = 0;
        public LayerEnd End { get; set; } = LayerEnd.خیر;
        [StringLength(25)]
        public string RCode { get; set; } = "";
        [StringLength(150)]
        public string Comment1 { get; set; } = "";
        [StringLength(150)]
        public string Comment2 { get; set; } = "";
        [StringLength(150)]
        public string Comment3 { get; set; } = "";
        [NotMapped]
        public bool IsOpen { get; set; } = false;


    }
}
