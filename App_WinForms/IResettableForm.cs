using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App_WinForms
{
    internal interface IResettableForm : IContainerControl
    {
        public void Reset();
    }
}
