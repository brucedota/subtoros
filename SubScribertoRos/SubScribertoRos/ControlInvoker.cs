using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SubScribertoRos
{
    public class ControlInvoker
    {
        public static void Invoke(Control ctl, ThreadStart thread)
        {
            try
            {
                if (!ctl.IsHandleCreated)
                    return;

                if (ctl.IsDisposed)
                    return;

                if (ctl.InvokeRequired)
                {
                    ctl.Invoke(thread);
                }
                else
                {
                    thread();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
