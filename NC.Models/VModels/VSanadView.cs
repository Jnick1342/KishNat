using System.Collections.Generic;

namespace NC.Models.VModels
{

    public class VSanadView
    {
        public VCSanadMaster SanadMaster { get; set; }
        public List<VCSanadBody> SanadaBodies { get; set; }
        public VSanadView()
        {
            SanadMaster = new VCSanadMaster();
            SanadaBodies = new List<VCSanadBody>();
        }


    }
    public class VAsnadView
    {
        public VBAsnadMaster SanadMaster { get; set; }
        public List<VBAsnadBody> SanadaBodies { get; set; }
        public VAsnadView()
        {
            SanadMaster = new VBAsnadMaster();
            SanadaBodies = new List<VBAsnadBody>();
        }


    }
}
