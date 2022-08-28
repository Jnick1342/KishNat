using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.DBModels.BViews
{
    public class BVGozareshNaghdinegiBank
    {
        public string BankCode  { get; set; }
        public string BankName { get; set; }
        public long MabDaryaft { get; set; }
        public long MabPardakht { get; set; }
        public long Mandeh { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
