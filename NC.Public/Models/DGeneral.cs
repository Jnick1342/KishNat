using MD.PersianDateTime;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NC.Public.Models
{
    public class DBGeneral
    {
        public string CompanyName { get; set; } = ConfigurationManager.AppSettings["Company"].ToString();
        public string TitleOftheSection { get; set; } = "TarazHesabresi";
        public string Logo
        {
            get
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                return @path + "\\logo.jpeg";
            }
        }
        public string Date { get; set; } = PersianDateTime.Now.ToLongDateTimeString();
        public string AdLogo
        {
            get
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                return @path + "\\AdLogo.jpeg";
            }
        }
        public string BasicInfoName { get; set; } = "";
    }
}
