using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NC.Models.DBModels

{
    public class ZApp
    {
        [Key]
        [StringLength(1)]
        public string AppId { get; set; } = string.Empty;
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string EnName { get; set; } = string.Empty;
        public virtual ICollection<ZRole> ZRoles { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; } = false;

    }
}
