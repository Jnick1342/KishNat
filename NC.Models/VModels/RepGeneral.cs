using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.VModels
{
  
    public class RepgeneralExtend
    {
        public bool Ekhtetamieh { get; set; } = true;
        public bool Eftetahieh { get; set; } = true;
        public bool GhablAzDoreh { get; set; } = false;
        public bool TaeidShodeh { get; set; } = false;
        public bool Adi { get; set; } = true;
        public bool Amalkard { get; set; } = false;
        public bool TayDoreh { get; set; } = false;
        public bool TaeidNashodeh { get; set; } = true;
        public string DateEnd { get; set; } = "1400/1/1";
        public string DateStart { get; set; } = "1399/1/1";
        public bool CheckSum { get; set; } = true;
    }
}
