using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NC.Public.Component
{
    public class JTextBox: TextBox
    {
        public JTextBox()
        {
            
        }
        protected override void OnGotFocus(RoutedEventArgs e)
        {
            this.SelectAll();
            base.OnGotFocus(e);

        }
    }
}
