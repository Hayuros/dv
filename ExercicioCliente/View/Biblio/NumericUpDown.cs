using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Biblio
    {
        class BiblioNumericUpDown : NumericUpDown
        {
            public BiblioNumericUpDown(
                Point Location,
                Size Size
            ) {
                this.Location = Location;
                this.Size = Size;
            }
        }
    }
}