


using NC.Core.ModelView;
using NC.Public;
using NC.Security;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NC.Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaskDetails { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class DecimalConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return ((decimal)value).ToString("#,##0;(#,##0)");

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }



   
   



   



    public partial class MainWindow : Window
    {
        //public MainWindowView mainWindowView = new WindowViewModel();
        public MainWindow()
        {
            if (!NC.Public.Statics.StaticVariables.TokenValidate())
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentActivationSetUp") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Public;component/Style/ActivationSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentActivationSetUp") as Style;
                }
                WinActivationSetup win=new WinActivationSetup();
                win.ShowDialog();
                if (!NC.Public.Statics.StaticVariables.TokenValidate())
                    App.Current.Shutdown();

            }

            if (!NC.Public.Statics.StaticVariables.DBValidate())
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Public;component/Style/DataBaseSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                }
                WinDataBaseSetup win = new WinDataBaseSetup();
                win.ShowDialog();
                if (!NC.Public.Statics.StaticVariables.DBValidate())
                    App.Current.Shutdown();
                
            }
            InitializeComponent();
            this.DataContext = new WindowViewModel(this);
         //   this.ContentMenuControl.DataContext = new MainMenuViewModel();
        }





        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = (ToggleButton)sender;
            tb.Content = "Process Start";
            //mainWindowView.IsVisibleMainStatusBar = Visibility.Collapsed;

        }
        private void DApps_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = (ToggleButton)sender;
            tb.Content = "Process Stop";
            //mainWindowView.IsVisibleMainStatusBar = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is test");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            NC.Public.WinLogin mwin = new NC.Public.WinLogin(); 
            mwin.ShowDialog();
            // async;sld;asdk
        }
    }
}
