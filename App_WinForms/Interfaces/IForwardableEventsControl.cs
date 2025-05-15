using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WinForms
{
    public interface IForwardableEventsControl
    {
        public void ForwardEvents(Control parent);
    }
}
