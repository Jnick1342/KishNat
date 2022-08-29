using NC.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NC.AppSecurity.ModelView
{
    public partial class MenuViewModel : BaseViewModel
    {
        public ICommand UserCommand { get; set; }
        public MenuViewModel()
        {
            UserCommand = new RelayCommand(() =>
            {
                var d = "ddd";
            });
        }
    }

}
