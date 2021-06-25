using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio {
        class BiblioComboBox : ComboBox{
            public BiblioComboBox(
                Point Location,
                Size Size
            ) {
                this.Location = Location;
                this.Size = Size;
            }
        }
    }
}