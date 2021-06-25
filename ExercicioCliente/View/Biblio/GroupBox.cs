using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio {
        class BiblioGroupBox : GroupBox{
            public BiblioGroupBox(
                string Text,
                Point Location,
                Size Size
            ) {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
            }
        }
    }
}