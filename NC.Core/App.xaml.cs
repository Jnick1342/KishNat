using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace NC.Core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            CultureInfo info = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentCulture = info;
            Thread.CurrentThread.CurrentUICulture = info;
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)));
            var flowDirection = CultureInfo.CurrentCulture.TextInfo.IsRightToLeft? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
            FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(flowDirection));
            //InputLanguageManager.SetInputLanguage(this, CultureInfo.CreateSpecificCulture("fa-IR"));
        }
    }
}
