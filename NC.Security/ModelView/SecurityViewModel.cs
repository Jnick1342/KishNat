
using NC.Public;
using NC.Public.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Security.ModelView
{
    public partial class SecurityViewModel : GlobalViewModel
    {


        public ICommand UserCommand { get; set; }

        //    #region Constructor
        public SecurityViewModel(Window window) : base(window)
        {


            UserCommand = new RelayCommand(() =>
            {
                //Style style = new Style();
                //try
                //{
                //    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                //}
                //catch
                //{
                //    var foo = new Uri("pack://application:,,,/Style/DataBaseSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                //    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                //    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                //}

                //WinDataBaseSetup win = new WinDataBaseSetup();
                //win.ShowDialog();
                MessageBox.Show("UserCommand Test");
            });

            //    #endregion

        }
    }
}
