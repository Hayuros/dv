using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View {
    namespace Biblio
    {
        class BiblioMonthCalendar : MonthCalendar
        {
            public BiblioMonthCalendar(
                Point Location
            ) {
                this.Location = Location;
            }
        }
    }
}