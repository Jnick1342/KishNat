using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class ZRole
    {
        [Key]
        [StringLength(3)]
        public string RoleId { get; set; } = string.Empty;
        [ForeignKey("ZApp")]
        [StringLength(1)]
        public string AppId { get; set; } = string.Empty;
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string EnName { get; set; } = string.Empty;
       
        public string Exp { get; set; } = string.Empty;
        
        public string EnExp { get; set; } = string.Empty;
        public virtual ZApp ZApp { get; set; }

        [NotMapped]
        public UserAccessPriority AccessPriority { get; set; }


    }
}
