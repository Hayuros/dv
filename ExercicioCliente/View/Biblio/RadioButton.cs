using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio {
        class BiblioRadioButton : RadioButton{
            public BiblioRadioButton(
                string Text,
                Point Location,
                Font font
            ) {
                this.Text = Text;
                this.Location = Location;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            }
        }
    }
}