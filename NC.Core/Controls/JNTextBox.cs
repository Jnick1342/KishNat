using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NC.Core
{
    public class JNTextBox: JTextBox
    {
            protected override void OnPreviewTextInput(TextCompositionEventArgs e)
            {
                if (!long.TryParse(Text + e.Text, out long result))
                {
                    e.Handled = true;

                }
                else
                {
                    //   Text = result.ToString("N0");
                    //   e.Handled = true;
                }
                base.OnPreviewTextInput(e);
            }
        
    }
}
