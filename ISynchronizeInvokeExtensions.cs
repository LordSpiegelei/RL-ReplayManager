using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL_ReplayManager
{
    public static class ISynchronizeInvokeExtensions
    {

        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            try
            {
                if (@this.InvokeRequired)
                {
                    @this.Invoke(action, new object[] { @this });
                }
                else
                {
                    action(@this);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
