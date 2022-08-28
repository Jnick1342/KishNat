
 
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
    public partial class WinLogin : Window
    {
        public WinLogin()
        {
            Style style = new Style();
            try
            {
                style = Application.Current.MainWindow.FindResource("ContentLogin") as Style;
            }
            catch
            {
                var foo = new Uri("pack://application:,,,/NC.Public;component/Style/LoginStyle.xaml", UriKind.RelativeOrAbsolute);
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                style = Application.Current.MainWindow.FindResource("ContentLogin") as Style;
            }

            InitializeComponent();

            this.DataContext = new NC.Public.ModelView.GlobalViewModel(this);
            this.WorkAreaControl.Style = style;
            this.WorkAreaControl.DataContext = new NC.Public.ModelView.LoginView(this);
        }




    }
}

