using MD.PersianDateTime;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static NC.Models.Tools.Enums;

namespace NC.Models.DBModels
{
    public class CBasicInfo
    {
        [Key]
        [StringLength(3)]
        public string Id { get; set; } = "";
        [StringLength(100)]
        public string Name { get; set; } = "";

        [StringLength(10)]
        public string DStart { get; set ; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");
        [StringLength(10)]
        public string DEnd { get; set; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");
        [StringLength(10)]
        public string DOperationStart { get; set; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");
        [StringLength(10)]
        public string DOperationEnd { get; set; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");
        [StringLength(10)]
        public string DConfirmStart { get; set; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");
        [StringLength(10)]
        public string DConfirmEnd { get; set; } = PersianDateTime.Now.Date.ToString("yyyy/MM/dd");

        public DorehMaliStatus Status { get; set; } = DorehMaliStatus.باز;




        internal virtual ICollection<CSanadMaster> CSanadMasterBasicInfos { get; set; }
        internal virtual ICollection<CSanadMasterOk> CSanadMasterOkBasicInfos { get; set; }
    }
}
