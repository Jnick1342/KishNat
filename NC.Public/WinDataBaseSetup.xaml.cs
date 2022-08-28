 
using NC.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NC.Public
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class WinDataBaseSetup : Window
    {
        public WinDataBaseSetup()
        {
            Style style = new Style();
            try
            {
                style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
            }
            catch
            {
                var foo = new Uri("pack://application:,,,/Style/DataBaseSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
            }
            InitializeComponent();
          
            this.DataContext = new NC.Public.ModelView.GlobalViewModel(this);
            this.WorkAreaControl.Style = style;
            this.WorkAreaControl.DataContext = new NC.Public.ModelView.DataBaseSetupModelView(this);
        }

    }
}
