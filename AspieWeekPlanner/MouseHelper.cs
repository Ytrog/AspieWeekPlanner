using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AspieWeekPlanner
{
    public static class MouseHelper
    {
        public static bool ValidateDragDrop(object control, MouseEventArgs e)
        {
            return control != null && e.LeftButton == MouseButtonState.Pressed;
        }
    }
}
