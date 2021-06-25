using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio {
        class BiblioTextBox : TextBox{
            public BiblioTextBox(
                Point Location,
                Size Size                
            ) {
                this.Location = Location;
                this.Size = Size;
            }
        }

        class BiblioMaskedTextBox : MaskedTextBox{
            public BiblioMaskedTextBox(
                Point Location,
                Size Size
            ) {
                this.Location = Location;
                this.Size = Size;
            }
        }
    }
}