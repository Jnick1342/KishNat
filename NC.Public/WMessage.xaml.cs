using NC.Public.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using System.Windows.Shapes;

namespace NC.Public
{
    /// <summary>
    /// Interaction logic for WMessage.xaml
    /// </summary>
    public partial class WMessage : Window
    {
        public WMessage( string title,string message, Visibility confirmForm)
        {
            Style style = new Style();
            try
            {
                 style = Application.Current.MainWindow.FindResource("ContentWMessage") as Style;
            }
            catch 
            {
                var foo = new Uri("pack://application:,,,/NC.Public;component/Style/WMessageStyle.xaml", UriKind.RelativeOrAbsolute);
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                style = Application.Current.MainWindow.FindResource("ContentWMessage") as Style;
            }
            
            
            InitializeComponent();
           
            var f= new NC.Public.ModelView.GlobalViewModel(this);
            f.Title = title;
            this.DataContext = f;
            this.WorkAreaControl.Style = style;

            var m = new NC.Public.ModelView.WMessageViewModel(this);
            m.Message=message;
            m.ConfirmButton = confirmForm;
            this.WorkAreaControl.DataContext = m;
        }
        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    NC.Public.ModelView.WMessageViewModel m = this.WorkAreaControl.DataContext as NC.Public.ModelView.WMessageViewModel;
        //         DialogResult = m.FeedBackDialogResult;
        //    base.OnClosing(e);
        //}
        //protected override void OnClosed(EventArgs e)
        //{
        //    NC.Public.ModelView.WMessageViewModel m = this.WorkAreaControl.DataContext as NC.Public.ModelView.WMessageViewModel;
        //    DialogResult = m.FeedBackDialogResult;
        //    //base.OnClosed(e);
        //}
    }
}
