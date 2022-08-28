using NC.Models.DBModels;
using System.Collections.Generic;

namespace NC.Models.VModels
{
    public class SanadView
    {
        public CSanadMaster SanadMaster { get; set; }
        public List<CSanadBody> SanadaBodies { get; set; }
        public SanadView()
        {
            SanadMaster = new CSanadMaster();
            SanadaBodies = new List<CSanadBody>();
        }
    }

}
