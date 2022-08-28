using System.ComponentModel.DataAnnotations;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class ZUser
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]

        public string Name { get; set; } = "";
        [StringLength(30)]
        public string Password { get; set; } = "";
        [StringLength(100)]
        public string Position { get; set; } = "";

        public UserStatus IsActive { get; set; } = UserStatus.فعال;

        [StringLength(20)]
        public string AccessToSystems { get; set; } = "";
        [StringLength(100)]
        public string RolesInSystemA { get; set; } = "";
        [StringLength(100)]
        public string RolesInSystemB { get; set; } = "";
        [StringLength(100)]
        public string RolesInSystemC { get; set; } = "";
        [StringLength(100)]
        public string RolesInSystemZ { get; set; } = "";
    }

}