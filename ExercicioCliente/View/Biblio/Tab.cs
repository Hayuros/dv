using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View {
    namespace Biblio
    {
        class BiblioTabPage : TabPage
        {
            public BiblioTabPage(
                string Text,
                Size Size
            ) {
                this.Text = Text;
                this.Size = Size;
            }
        }

        class BiblioTabControl : TabControl
        {
            public BiblioTabControl(
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