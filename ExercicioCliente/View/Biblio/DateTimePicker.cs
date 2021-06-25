using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio
    {
        class BiblioDateTimePicker : DateTimePicker
        {
            public BiblioDateTimePicker (
                Point Location,
                Size Size
            ) {
                this.Location = Location;
                this.Size = Size;
            }
        }
    }
}