using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Core
{
        public class JTextBox : TextBox
        {

            protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
            {
                if (Tag == null)
                {
                    InputLanguageManager.SetInputLanguage(this, CultureInfo.CreateSpecificCulture("fa-IR"));
                }
                else
                {
                    InputLanguageManager.SetInputLanguage(this, CultureInfo.CreateSpecificCulture("en-US"));
                    FlowDirection = FlowDirection.LeftToRight;
                }
            }
    }
}
