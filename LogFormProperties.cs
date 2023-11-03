

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift
{
    internal class LogFormProperties
    {
        public static void SetFormProperties(Form form)
        {

            /*┌───────────────────────────────────┐
              │     Customize form properties     │
              └───────────────────────────────────┘*/
            form.Text = "International Food AB || Logs || Jensen 2023";
            form.MaximumSize = new Size(590, 500);
            form.MaximizeBox = false;
            //form.ControlBox = false;

        }
    }
}
